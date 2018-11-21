namespace gitsync.Forms
{
  partial class PasswortForm
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
      Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
      Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
      Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswortForm));
      this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
      this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
      this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
      this.btn_ok = new Telerik.WinControls.UI.RadButton();
      this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
      this.radGroupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
      this.radGroupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_ok)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radGroupBox1
      // 
      this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add(this.radDropDownList1);
      this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.radGroupBox1.HeaderText = "Modus";
      this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new System.Drawing.Size(468, 57);
      this.radGroupBox1.TabIndex = 0;
      this.radGroupBox1.Text = "Modus";
      this.radGroupBox1.ThemeName = "ControlDefault";
      // 
      // radGroupBox2
      // 
      this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add(this.radTextBox1);
      this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.radGroupBox2.HeaderText = "Passwort";
      this.radGroupBox2.Location = new System.Drawing.Point(0, 57);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new System.Drawing.Size(468, 58);
      this.radGroupBox2.TabIndex = 1;
      this.radGroupBox2.Text = "Passwort";
      this.radGroupBox2.ThemeName = "ControlDefault";
      // 
      // radTextBox1
      // 
      this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radTextBox1.Location = new System.Drawing.Point(2, 18);
      this.radTextBox1.Name = "radTextBox1";
      this.radTextBox1.NullText = "Passwort hier eingeben (KLARTEXT)...";
      this.radTextBox1.Size = new System.Drawing.Size(464, 38);
      this.radTextBox1.TabIndex = 0;
      // 
      // btn_ok
      // 
      this.btn_ok.Location = new System.Drawing.Point(353, 121);
      this.btn_ok.Name = "btn_ok";
      this.btn_ok.Size = new System.Drawing.Size(110, 36);
      this.btn_ok.TabIndex = 2;
      this.btn_ok.Text = "OK";
      this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
      // 
      // radDropDownList1
      // 
      this.radDropDownList1.Dock = System.Windows.Forms.DockStyle.Top;
      radListDataItem1.Text = "Keine Ver- oder Entschlüsselung anwenden.";
      radListDataItem2.Text = "Alle Dateien mit AES256 verschlüsseln.";
      radListDataItem3.Text = "Alle *.aes-Dateien entschlüsseln.";
      this.radDropDownList1.Items.Add(radListDataItem1);
      this.radDropDownList1.Items.Add(radListDataItem2);
      this.radDropDownList1.Items.Add(radListDataItem3);
      this.radDropDownList1.Location = new System.Drawing.Point(2, 18);
      this.radDropDownList1.Name = "radDropDownList1";
      this.radDropDownList1.Size = new System.Drawing.Size(464, 36);
      this.radDropDownList1.TabIndex = 0;
      // 
      // PasswortForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(468, 163);
      this.Controls.Add(this.btn_ok);
      this.Controls.Add(this.radGroupBox2);
      this.Controls.Add(this.radGroupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PasswortForm";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sicherheit aktivieren";
      this.ThemeName = "MaterialPink";
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_ok)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
    private Telerik.WinControls.UI.RadTextBox radTextBox1;
    private Telerik.WinControls.UI.RadButton btn_ok;
    private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
  }
}