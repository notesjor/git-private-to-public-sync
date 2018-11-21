using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using gitsync.Forms.Abstract;
using gitsync.Model;
using gitsync.Properties;
using Telerik.WinControls.UI;

namespace gitsync.Forms
{
  public partial class MainForm : AbstractForm
  {
    private bool enableAutoCheck;

    public MainForm()
    {
      InitializeComponent();
    }

    private void btn_private_Click(object sender, System.EventArgs e)
    {
      var fbdPriv = new FolderBrowserDialog { Description = "Privates Repository" };
      if (fbdPriv.ShowDialog() != DialogResult.OK)
        return;
      DiscoverDirectory(fbdPriv.SelectedPath, fbdPriv.SelectedPath, tree_private);
      SecureCopy.LoadCryptoStatus(fbdPriv.SelectedPath);

      var fbdPub = new FolderBrowserDialog { Description = "Öffentliches Repository" };
      if (fbdPub.ShowDialog() != DialogResult.OK)
        return;
      DiscoverDirectory(fbdPub.SelectedPath, fbdPub.SelectedPath, tree_public);

      privatePath = fbdPriv.SelectedPath;
      publicPath = fbdPub.SelectedPath;

      SelectAllExsistingItems();

      btn_secure.Visibility = Telerik.WinControls.ElementVisibility.Visible;
      btn_sync.Visibility = Telerik.WinControls.ElementVisibility.Visible;
    }

    private void SelectAllExsistingItems()
    {
      var selected = new HashSet<string>();
      RecursiveSelectExsisting(ref selected, tree_public.Nodes);
      RecursiveSelect(ref selected, tree_private.Nodes);
    }

    private void RecursiveSelect(ref HashSet<string> selected, RadTreeNodeCollection nodes)
    {
      foreach (var node in nodes)
      {
        if (selected.Contains((string)node.Tag))
          node.Checked = true;
        RecursiveSelect(ref selected, node.Nodes);
      }
    }

    private void RecursiveSelectExsisting(ref HashSet<string> selected, RadTreeNodeCollection nodes)
    {
      foreach (var node in nodes)
      {
        selected.Add((string)node.Tag);
        RecursiveSelectExsisting(ref selected, node.Nodes);
      }
    }

    private void btn_sync_Click(object sender, System.EventArgs e)
    {
      Hide();
      RecursiveSync(tree_private.Nodes);
      MessageBox.Show("FERTIG!");
      Close();
    }

    private void RecursiveSync(RadTreeNodeCollection nodes)
    {
      foreach (var node in nodes)
      {
        try
        {
          if (!node.Checked)
            continue;

          if (node.Nodes != null && node.Nodes.Count > 0)
          {
            var destination = publicPath + (string)node.Tag;
            if (!Directory.Exists(destination))
              Directory.CreateDirectory(destination);

            var source = privatePath + (string)node.Tag;
            var sourceFiles = new HashSet<string>(Directory.GetFiles(source).Select(x => x.Replace(source, "")));
            foreach (var file in Directory.GetFiles(destination).Select(x => x.Replace(destination, "").Replace(".aes", "")))
            {
              if (!sourceFiles.Contains(file))
                File.Delete(destination + file);
            }

            RecursiveSync(node.Nodes);
          }
          else
          {
            try
            {
              SecureCopy.Copy(privatePath + (string)node.Tag, publicPath + (string)node.Tag);
            }
            catch (IOException)
            {
              // ignore
            }
          }
        }
        catch (UnauthorizedAccessException)
        {
          // ignore
        }
        catch (Exception)
        {
          // ignore
        }
      }
    }

    private void txt_private_TextChanged(object sender, System.EventArgs e)
    {
      tree_private.Filter = txt_private.Text;
    }

    private void txt_public_TextChanged(object sender, System.EventArgs e)
    {
      tree_public.Filter = txt_public.Text;
    }

    private void DiscoverDirectory(string basePath, string path, RadTreeView tree)
    {
      tree.Nodes.Clear();

      var root = new RadTreeNode();
      DiscoverDirectory(basePath, path, root);

      tree.Nodes.AddRange(root.Nodes);
    }

    private void DiscoverDirectory(string basePath, string path, RadTreeNode root)
    {
      foreach (var directory in Directory.GetDirectories(path))
      {
        if (directory.Contains(".git"))
          continue;

        var node = root.Nodes.Add(directory.Replace(path, "").Replace(@"\", ""));
        node.Image = Resources.folder_open;
        node.Tag = directory.Replace(basePath, "");
        DiscoverDirectory(basePath, directory, node);
      }

      foreach (var file in Directory.GetFiles(path))
      {
        var node = root.Nodes.Add(file.Replace(path, "").Replace(@"\", ""));
        node.Tag = file.Replace(basePath, "");
        node.Image = Resources.file_binary;
      }
    }

    private bool nodeCheckedChangedLock;
    private string privatePath;
    private string publicPath;

    private void tree_private_NodeCheckedChanged(object sender, TreeNodeCheckedEventArgs e)
    {
      if (nodeCheckedChangedLock)
        return;

      nodeCheckedChangedLock = true;
      RecursiveCheck(e.Node);
      nodeCheckedChangedLock = false;
    }

    private void RecursiveCheck(RadTreeNode node)
    {
      node.Checked = true;
      foreach (var n in node.Nodes)
        RecursiveCheck(n);
    }

    private void btn_secure_Click(object sender, EventArgs e)
    {
      var form = new PasswortForm(privatePath);
      form.ShowDialog();
    }
  }
}
