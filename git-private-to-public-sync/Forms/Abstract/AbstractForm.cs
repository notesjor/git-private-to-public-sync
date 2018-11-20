using Telerik.WinControls;

namespace gitsync.Forms.Abstract
{
  public partial class AbstractForm : Telerik.WinControls.UI.RadForm
  {
    public AbstractForm()
    {
      try
      {
        ThemeResolutionService.ApplicationThemeName = "MaterialPink";
      }
      catch
      {
        // ignore
      }

      InitializeComponent();      
    }
  }
}
