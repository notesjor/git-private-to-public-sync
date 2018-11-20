namespace gitsync.Forms
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
      this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
      this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
      this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
      this.tree_private = new Telerik.WinControls.UI.RadTreeView();
      this.txt_private = new Telerik.WinControls.UI.RadTextBox();
      this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
      this.tree_public = new Telerik.WinControls.UI.RadTreeView();
      this.txt_public = new Telerik.WinControls.UI.RadTextBox();
      this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
      this.btn_private = new Telerik.WinControls.UI.CommandBarButton();
      this.btn_secure = new Telerik.WinControls.UI.CommandBarButton();
      this.btn_sync = new Telerik.WinControls.UI.CommandBarButton();
      ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
      this.radSplitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
      this.splitPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tree_private)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_private)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
      this.splitPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tree_public)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_public)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radCommandBar1
      // 
      this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
      this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
      this.radCommandBar1.Name = "radCommandBar1";
      this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
      this.radCommandBar1.Size = new System.Drawing.Size(764, 73);
      this.radCommandBar1.TabIndex = 0;
      // 
      // commandBarRowElement1
      // 
      this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
      this.commandBarRowElement1.Name = "commandBarRowElement1";
      this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
      // 
      // radSplitContainer1
      // 
      this.radSplitContainer1.Controls.Add(this.splitPanel1);
      this.radSplitContainer1.Controls.Add(this.splitPanel2);
      this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radSplitContainer1.Location = new System.Drawing.Point(0, 73);
      this.radSplitContainer1.Name = "radSplitContainer1";
      // 
      // 
      // 
      this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
      this.radSplitContainer1.Size = new System.Drawing.Size(764, 435);
      this.radSplitContainer1.SplitterWidth = 8;
      this.radSplitContainer1.TabIndex = 1;
      this.radSplitContainer1.TabStop = false;
      // 
      // splitPanel1
      // 
      this.splitPanel1.Controls.Add(this.tree_private);
      this.splitPanel1.Controls.Add(this.txt_private);
      this.splitPanel1.Location = new System.Drawing.Point(0, 0);
      this.splitPanel1.Name = "splitPanel1";
      // 
      // 
      // 
      this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
      this.splitPanel1.Size = new System.Drawing.Size(378, 435);
      this.splitPanel1.TabIndex = 0;
      this.splitPanel1.TabStop = false;
      this.splitPanel1.Text = "splitPanel1";
      // 
      // tree_private
      // 
      this.tree_private.CheckBoxes = true;
      this.tree_private.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tree_private.ItemHeight = 36;
      this.tree_private.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
      this.tree_private.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
      this.tree_private.Location = new System.Drawing.Point(0, 36);
      this.tree_private.Name = "tree_private";
      this.tree_private.Size = new System.Drawing.Size(378, 399);
      this.tree_private.TabIndex = 1;
      this.tree_private.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.tree_private_NodeCheckedChanged);
      // 
      // txt_private
      // 
      this.txt_private.Dock = System.Windows.Forms.DockStyle.Top;
      this.txt_private.Location = new System.Drawing.Point(0, 0);
      this.txt_private.Name = "txt_private";
      this.txt_private.NullText = "Suchbegriff hier eingeben...";
      this.txt_private.Size = new System.Drawing.Size(378, 36);
      this.txt_private.TabIndex = 0;
      this.txt_private.TextChanged += new System.EventHandler(this.txt_private_TextChanged);
      // 
      // splitPanel2
      // 
      this.splitPanel2.Controls.Add(this.tree_public);
      this.splitPanel2.Controls.Add(this.txt_public);
      this.splitPanel2.Location = new System.Drawing.Point(386, 0);
      this.splitPanel2.Name = "splitPanel2";
      // 
      // 
      // 
      this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
      this.splitPanel2.Size = new System.Drawing.Size(378, 435);
      this.splitPanel2.TabIndex = 1;
      this.splitPanel2.TabStop = false;
      this.splitPanel2.Text = "splitPanel2";
      // 
      // tree_public
      // 
      this.tree_public.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tree_public.ItemHeight = 36;
      this.tree_public.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
      this.tree_public.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
      this.tree_public.Location = new System.Drawing.Point(0, 36);
      this.tree_public.Name = "tree_public";
      this.tree_public.Size = new System.Drawing.Size(378, 399);
      this.tree_public.TabIndex = 1;
      // 
      // txt_public
      // 
      this.txt_public.Dock = System.Windows.Forms.DockStyle.Top;
      this.txt_public.Location = new System.Drawing.Point(0, 0);
      this.txt_public.Name = "txt_public";
      this.txt_public.NullText = "Suchbegriff hier eingeben...";
      this.txt_public.Size = new System.Drawing.Size(378, 36);
      this.txt_public.TabIndex = 0;
      this.txt_public.TextChanged += new System.EventHandler(this.txt_public_TextChanged);
      // 
      // commandBarStripElement1
      // 
      this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
      this.commandBarStripElement1.Image = global::gitsync.Properties.Resources.security_lock;
      this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btn_private,
            this.btn_secure,
            this.btn_sync});
      this.commandBarStripElement1.Name = "commandBarStripElement1";
      this.commandBarStripElement1.Text = "";
      this.commandBarStripElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      // 
      // btn_private
      // 
      this.btn_private.DisplayName = "commandBarButton1";
      this.btn_private.DrawText = true;
      this.btn_private.Image = global::gitsync.Properties.Resources.folder_open_update;
      this.btn_private.Name = "btn_private";
      this.btn_private.Text = "Verzeichnisse auswählen";
      this.btn_private.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btn_private.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
      this.btn_private.Click += new System.EventHandler(this.btn_private_Click);
      // 
      // btn_secure
      // 
      this.btn_secure.DisplayName = "commandBarButton1";
      this.btn_secure.DrawText = true;
      this.btn_secure.Image = global::gitsync.Properties.Resources.security_lock;
      this.btn_secure.Name = "btn_secure";
      this.btn_secure.Text = "Passwort eingeben";
      this.btn_secure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      // 
      // btn_sync
      // 
      this.btn_sync.DisplayName = "commandBarButton4";
      this.btn_sync.DrawText = true;
      this.btn_sync.Image = global::gitsync.Properties.Resources.refresh;
      this.btn_sync.Name = "btn_sync";
      this.btn_sync.Text = "Starte Synchronisation";
      this.btn_sync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btn_sync.Click += new System.EventHandler(this.btn_sync_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 508);
      this.Controls.Add(this.radSplitContainer1);
      this.Controls.Add(this.radCommandBar1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "GIT ::: PRIVATE > PUBLIC";
      ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
      this.radSplitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
      this.splitPanel1.ResumeLayout(false);
      this.splitPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tree_private)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_private)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
      this.splitPanel2.ResumeLayout(false);
      this.splitPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tree_public)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_public)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
    private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
    private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
    private Telerik.WinControls.UI.CommandBarButton btn_sync;
    private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
    private Telerik.WinControls.UI.SplitPanel splitPanel1;
    private Telerik.WinControls.UI.RadTreeView tree_private;
    private Telerik.WinControls.UI.RadTextBox txt_private;
    private Telerik.WinControls.UI.SplitPanel splitPanel2;
    private Telerik.WinControls.UI.RadTreeView tree_public;
    private Telerik.WinControls.UI.RadTextBox txt_public;
    private Telerik.WinControls.UI.CommandBarButton btn_private;
    private Telerik.WinControls.UI.CommandBarButton btn_secure;
  }
}