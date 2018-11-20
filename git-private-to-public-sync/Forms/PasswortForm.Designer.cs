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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswortForm));
      this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
      this.radio_decrypt = new Telerik.WinControls.UI.RadRadioButton();
      this.radio_encrypt = new Telerik.WinControls.UI.RadRadioButton();
      this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
      this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
      this.btn_ok = new Telerik.WinControls.UI.RadButton();
      this.btn_abort = new Telerik.WinControls.UI.RadButton();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
      this.radGroupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radio_decrypt)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radio_encrypt)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
      this.radGroupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_ok)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_abort)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radGroupBox1
      // 
      this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add(this.radio_decrypt);
      this.radGroupBox1.Controls.Add(this.radio_encrypt);
      this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.radGroupBox1.HeaderText = "Modus";
      this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new System.Drawing.Size(468, 94);
      this.radGroupBox1.TabIndex = 0;
      this.radGroupBox1.Text = "Modus";
      this.radGroupBox1.ThemeName = "ControlDefault";
      // 
      // radio_decrypt
      // 
      this.radio_decrypt.Location = new System.Drawing.Point(12, 58);
      this.radio_decrypt.Name = "radio_decrypt";
      this.radio_decrypt.Size = new System.Drawing.Size(323, 22);
      this.radio_decrypt.TabIndex = 1;
      this.radio_decrypt.TabStop = false;
      this.radio_decrypt.Text = "Entschlüsselt alle Dateien, die auf *.aes enden";
      ((Telerik.WinControls.UI.RadRadioButtonElement)(this.radio_decrypt.GetChildAt(0))).Text = "Entschlüsselt alle Dateien, die auf *.aes enden";
      ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radio_decrypt.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      // 
      // radio_encrypt
      // 
      this.radio_encrypt.CheckState = System.Windows.Forms.CheckState.Checked;
      this.radio_encrypt.Location = new System.Drawing.Point(12, 30);
      this.radio_encrypt.Name = "radio_encrypt";
      this.radio_encrypt.Size = new System.Drawing.Size(360, 22);
      this.radio_encrypt.TabIndex = 0;
      this.radio_encrypt.Text = "Verschlüsselt alle Dateien, die nicht auf *.aes enden";
      this.radio_encrypt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
      ((Telerik.WinControls.UI.RadRadioButtonElement)(this.radio_encrypt.GetChildAt(0))).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
      ((Telerik.WinControls.UI.RadRadioButtonElement)(this.radio_encrypt.GetChildAt(0))).Text = "Verschlüsselt alle Dateien, die nicht auf *.aes enden";
      ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radio_encrypt.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      ((Telerik.WinControls.Primitives.TextPrimitive)(this.radio_encrypt.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).LineLimit = false;
      ((Telerik.WinControls.Primitives.TextPrimitive)(this.radio_encrypt.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
      ((Telerik.WinControls.Primitives.TextPrimitive)(this.radio_encrypt.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // radGroupBox2
      // 
      this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add(this.radTextBox1);
      this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.radGroupBox2.HeaderText = "Passwort";
      this.radGroupBox2.Location = new System.Drawing.Point(0, 94);
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
      this.btn_ok.Location = new System.Drawing.Point(346, 164);
      this.btn_ok.Name = "btn_ok";
      this.btn_ok.Size = new System.Drawing.Size(110, 36);
      this.btn_ok.TabIndex = 2;
      this.btn_ok.Text = "OK";
      this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
      // 
      // btn_abort
      // 
      this.btn_abort.Location = new System.Drawing.Point(12, 164);
      this.btn_abort.Name = "btn_abort";
      this.btn_abort.Size = new System.Drawing.Size(110, 36);
      this.btn_abort.TabIndex = 3;
      this.btn_abort.Text = "Abbrechen";
      this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
      // 
      // PasswortForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(468, 207);
      this.Controls.Add(this.btn_abort);
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
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radio_decrypt)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radio_encrypt)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_ok)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_abort)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    private Telerik.WinControls.UI.RadRadioButton radio_decrypt;
    private Telerik.WinControls.UI.RadRadioButton radio_encrypt;
    private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
    private Telerik.WinControls.UI.RadTextBox radTextBox1;
    private Telerik.WinControls.UI.RadButton btn_ok;
    private Telerik.WinControls.UI.RadButton btn_abort;
  }
}