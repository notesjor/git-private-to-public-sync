using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gitsync.Forms.Abstract;
using gitsync.Model;

namespace gitsync.Forms
{
  public partial class PasswortForm : AbstractForm
  {
    private readonly string _directory;

    public PasswortForm(string directory)
    {
      _directory = directory;
      InitializeComponent();

      radTextBox1.Text = SecureCopy.Password;
      switch (SecureCopy.Mode)
      {
        case Model.CryptoMode.None:
          radDropDownList1.SelectedIndex = 0; break;
        case Model.CryptoMode.Encrypt:
          radDropDownList1.SelectedIndex = 1; break;
        case Model.CryptoMode.Decrypt:
          radDropDownList1.SelectedIndex = 2; break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private void btn_ok_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;

      var mode = CryptoMode.None;
      switch (radDropDownList1.SelectedIndex)
      {
        case 0:
          mode = CryptoMode.None; break;
        case 1:
          mode = CryptoMode.Encrypt; break;
        case 2:
          mode = CryptoMode.Decrypt; break;
      }

      SecureCopy.SaveCryptoStatus(_directory, mode, radTextBox1.Text);

      Close();
    }
  }
}
