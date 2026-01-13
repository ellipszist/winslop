using System;
using System.Drawing;
using System.IO;
using System.Management.Automation;
using System.Windows.Forms;
using Winslop.Extensions;
using Winslop.Views;

namespace Winslop
{
    public partial class MainForm : Form
    {
        // Apps manager service
        private readonly AppManager _appManager = new AppManager();

        // Lazy instances (created only when needed)
        private FeaturesView _featureView;

        private AppsView _appsView;
        private ExtensionsView _extensionsView;

        // Logger and log actions
        private LogActions _logActions;

        private LogActionsController _logActionsController;

        public MainForm()
        {
            InitializeComponent();

            // Global logger output stays in the shell
            Logger.OutputBox = rtbLogger;

            _logActions = new LogActions(rtbLogger);

            // Lazy-load tab content when user switches tabs
            tabControl.SelectedIndexChanged += (s, e) => EnsureTabLoaded(tabControl.SelectedTab);
            // Update action buttons when user switches tabs
            tabControl.SelectedIndexChanged += (s, e) => UpdateActionButtons();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            btnMenu.Text = "\uE700"; // menu icon
            btnAbout.Text = "\uEB52"; // heart icon

            // Menu navigation: just select tabs
            //toolStripMenuTools.Click += (s, _) => tabControl.SelectedTab = Windows;
            btnAbout.Click += (s, _) => new AboutForm().ShowDialog();

            // Initialize log actions controller
            _logActionsController = new LogActionsController(comboLogActions, _logActions);

            // Set app version information
            toolStripMenuAbout.Text = $"Release {Program.GetAppVersion()}";
            // Set Windows version information
            var windowsTab = tabControl.TabPages["Windows"];
            if (windowsTab == null)
                return;
            windowsTab.Text = "Checking local configuration mode...";
            string osVersion = await OSHelper.OSHelper.GetWindowsVersion();
            windowsTab.Text = osVersion;

            // Ensure initial tab content exists
            EnsureTabLoaded(tabControl.SelectedTab);
            TryAutoLoadSelection();
        }

        /// <summary>
        /// Creates and hosts the view for the given tab (only once).
        /// </summary>
        private void EnsureTabLoaded(TabPage tab)
        {
            if (tab == null) return;

            if (ReferenceEquals(tab, Windows))
            {
                if (_featureView == null)
                {
                    _featureView = new FeaturesView { Dock = DockStyle.Fill };
                    Windows.Controls.Clear();
                    Windows.Controls.Add(_featureView);

                    // Initialize feature tree once
                    _featureView.InitializeAppState();
                }
            }
            else if (ReferenceEquals(tab, Apps))
            {
                if (_appsView == null)
                {
                    _appsView = new AppsView(_appManager) { Dock = DockStyle.Fill };
                    Apps.Controls.Clear();
                    Apps.Controls.Add(_appsView);
                }
            }
            else if (ReferenceEquals(tab, Extensions))
            {
                if (_extensionsView == null)
                {
                    _extensionsView = new ExtensionsView { Dock = DockStyle.Fill };
                    Extensions.Controls.Clear();
                    Extensions.Controls.Add(_extensionsView);
                }
            }
        }

        /// <summary>
        /// Returns the active tab content as IMainActions (Analyze/Fix).
        /// </summary>
        private IMainActions CurrentActions()
        {
            EnsureTabLoaded(tabControl.SelectedTab);

            return tabControl.SelectedTab != null && tabControl.SelectedTab.Controls.Count > 0
                ? tabControl.SelectedTab.Controls[0] as IMainActions
                : null;
        }

        // ---------------- Shell buttons ----------------

        // Enable buttons only if the active tab content supports actions
        private void UpdateActionButtons()
        {
            var actions = CurrentActions();
            bool hasActions = actions != null;

            btnAnalyze.Enabled = hasActions;
            btnFix.Enabled = hasActions;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            contextMenu.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            var actions = CurrentActions();
            if (actions != null)
                await actions.AnalyzeAsync();
        }

        private async void btnFix_Click(object sender, EventArgs e)
        {
            var actions = CurrentActions();
            if (actions != null)
                await actions.FixAsync();
        }

        private void toolStripMenuRestore_Click(object sender, EventArgs e)
        {
            EnsureTabLoaded(Windows);
            _featureView?.RestoreCheckedWithConfirmation();
        }

        // Toggle selection in the current view
        private void toolStripMenuSelection_Click(object sender, EventArgs e)
        {
            EnsureTabLoaded(tabControl.SelectedTab);

            var page = tabControl.SelectedTab;
            if (page == null || page.Controls.Count == 0) return;

            var hosted = page.Controls[0];

            if (hosted is FeaturesView fv) fv.ToggleSelection();
            else if (hosted is AppsView av) av.ToggleSelection();
        }

        // ---------------- Host Plugins ----------------

        private void ShowPluginsDialog()
        {
            using (var dlg = new Form())
            {
                dlg.Text = "Plugins";
                dlg.StartPosition = FormStartPosition.Manual;
                dlg.Location = new Point(this.Left + 20, this.Top + 20);
                dlg.FormBorderStyle = FormBorderStyle.Sizable;
                dlg.MinimizeBox = false;
                dlg.ShowInTaskbar = false;
                dlg.ShowIcon = false;
                dlg.ClientSize = new Size(500, 500);
                var view = new PluginsView { Dock = DockStyle.Fill };

                dlg.Controls.Add(view);
                dlg.ShowDialog(this);
            }
        }

        private void toolStripMenuPlugins_Click(object sender, EventArgs e)
        {
            ShowPluginsDialog();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            EnsureTabLoaded(tabControl.SelectedTab);

            // Forward the search query to the active view if it supports search
            var tab = tabControl.SelectedTab;
            if (tab == null || tab.Controls.Count == 0)
                return;

            (tab.Controls[0] as ISearchable)?.ApplySearch(textSearch.Text);
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            textSearch.Text = string.Empty;
        }

        // ---------------- Import / Export ----------------

        private void TryAutoLoadSelection()
        {
            // Look for "selection.sel" next to the executable
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(dir, "winslop-selection.sel");

            if (!File.Exists(path))
                return;

            // Optional: Ask user (so its always opt-in)
            var result = MessageBox.Show(
                "A selection file was found next to the app:\n\nselection.sel\n\nLoad it now?",
                "Load selection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // Ensure FeaturesView exists (lazy load)
            EnsureTabLoaded(Windows);

            // Import and show the result immediately
            int checkedCount = _featureView.ImportSelection(path);
            Logger.Log($"✅ Loaded selection.sel ({checkedCount} items checked).", LogLevel.Info);

            tabControl.SelectedTab = Windows;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnsureTabLoaded(Windows);
            if (_featureView == null) return;

            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Import selection";
                dlg.Filter = "Selection files (*.sel)|*.sel|Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                _featureView.ImportSelection(dlg.FileName);
                Logger.Log($"✅ Selection imported: {dlg.FileName}", LogLevel.Info);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnsureTabLoaded(Windows);
            if (_featureView == null) return;

            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export selection";
                dlg.Filter = "Selection files (*.sel)|*.sel|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dlg.DefaultExt = "sel";
                dlg.AddExtension = true;
                dlg.FileName = "winslop-selection.sel";

                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                _featureView.ExportSelection(dlg.FileName);
                Logger.Log($"✅ Selection exported: {dlg.FileName}", LogLevel.Info);
            }
        }
    }
}