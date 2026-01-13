using System;
using System.Diagnostics;
using System.Windows.Forms;

/// <summary>
/// Provides actions for interacting with and managing the content of a log displayed in a <see cref="RichTextBox"/>.
/// </summary>
/// <remarks>This class allows users to perform common operations on a log, such as copying its content to the
/// clipboard, analyzing it using the Winslopo nline inspector tool, or clearing the log. It is designed to work with a <see
/// cref="RichTextBox"/> control that serves as the log display.</remarks>
public sealed class LogActions
{
    private readonly RichTextBox _logBox;

    public LogActions(RichTextBox logBox)
    {
        _logBox = logBox ?? throw new ArgumentNullException(nameof(logBox));
    }

    /// <summary>Copies the whole log to the clipboard.</summary>
    public void CopyToClipboard()
    {
        var text = _logBox.Text;
        if (!string.IsNullOrEmpty(text))
            Clipboard.SetText(text);
    }

    /// <summary>Opens Winslop online inspector tool and passes the log via URL‑encoded GET parameter.</summary>
    public void AnalyzeOnline(string baseUrl)
    {
        if (string.IsNullOrWhiteSpace(baseUrl)) return;

        // Get the current log text
        var logText = _logBox.Text;

        if (string.IsNullOrWhiteSpace(logText))
        {
            MessageBox.Show(
                "There's nothing to analyze yet.\n\nRun an inspection first, then try again.",
                "Nothing to analyze (yet)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        // Copy the log to the clipboard
        Clipboard.SetText(logText);

        Process.Start(baseUrl);

        MessageBox.Show(
            "The log has been copied to the clipboard.\n" +
            "Click “Paste log from clipboard” on the log inspector page, or simply press CTRL+V,\n" +
            "to insert it into the inspector.",
            "Log copied",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }


    /// <summary>Clears the logger output.</summary>
    public void Clear()
        => _logBox.Clear();
}