using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// TreeView selection export/import (text file).
/// Exports ONLY checked nodes to keep the file small and readable.
///
/// Format:
///   WINSLOP_TREE_SELECTION_V2
///   1;Issues/Basic Disk Cleanup
///   1;MS Edge/Disable Start Boost
/// </summary>
public static class TreeSelectionTransferV1
{
    private const string Header = "WINSLOP_SELECTION_V1";
    private const char Sep = ';';
    private const char PathSep = '/';

    public static void ExportChecked(string filePath, TreeView tree)
    {
        if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("filePath is required.", nameof(filePath));
        if (tree == null) throw new ArgumentNullException(nameof(tree));

        using (var writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
        {
            writer.WriteLine(Header);

            // Write only checked nodes (leaves and/or parents whatever is checked)
            foreach (TreeNode node in EnumerateNodes(tree.Nodes).Where(n => n.Checked))
            {
                writer.WriteLine($"1{Sep}{GetNormalizedNodePath(node)}");
            }
        }
    }

    public static void ImportChecked(string filePath, TreeView tree, bool clearFirst = true)
    {
        if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("filePath is required.", nameof(filePath));
        if (tree == null) throw new ArgumentNullException(nameof(tree));
        if (!File.Exists(filePath)) throw new FileNotFoundException("Selection file not found.", filePath);

        var lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
        if (lines.Length == 0 || !string.Equals(lines[0].Trim(), Header, StringComparison.Ordinal))
            throw new InvalidOperationException("Invalid selection file format.");

        // Build lookup: normalized path > node 
        var lookup = EnumerateNodes(tree.Nodes)
            .ToDictionary(n => GetNormalizedNodePath(n), n => n, StringComparer.OrdinalIgnoreCase);

        tree.BeginUpdate();
        try
        {
            if (clearFirst)
            {
                foreach (TreeNode n in EnumerateNodes(tree.Nodes))
                    n.Checked = false;
            }

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (line.Length == 0) continue;

                int sepIndex = line.IndexOf(Sep);
                if (sepIndex <= 0) continue;

                // Expect: "1;path"
                string flag = line.Substring(0, sepIndex).Trim();
                if (flag != "1") continue;

                string path = NormalizePath(line.Substring(sepIndex + 1));

                if (lookup.TryGetValue(path, out var node))
                    node.Checked = true;
            }
        }
        finally
        {
            tree.EndUpdate();
        }
    }

    // -------- helpers --------

    private static IEnumerable<TreeNode> EnumerateNodes(TreeNodeCollection nodes)
    {
        foreach (TreeNode n in nodes)
        {
            yield return n;
            foreach (var c in EnumerateNodes(n.Nodes))
                yield return c;
        }
    }

    private static string GetNormalizedNodePath(TreeNode node)
    {
        // Build a stable path from root to leaf: Root/Child/Leaf
        var stack = new Stack<string>();
        var cur = node;
        while (cur != null)
        {
            stack.Push((cur.Text ?? string.Empty).Trim());
            cur = cur.Parent;
        }
        return string.Join(PathSep.ToString(), stack);
    }

    private static string NormalizePath(string raw)
    {
        // Normalize user file input: trim and trim each segment
        var parts = (raw ?? string.Empty)
            .Trim()
            .Split(new[] { PathSep }, StringSplitOptions.None)
            .Select(p => p.Trim())
            .Where(p => p.Length > 0);

        return string.Join(PathSep.ToString(), parts);
    }
}
