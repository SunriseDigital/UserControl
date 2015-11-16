using System;
using System.IO;
using System.Reflection;
using System.Web.UI;

namespace Lib
{
  public class UserControl : System.Web.UI.UserControl
  {
    protected override void FrameworkInitialize()
    {
      base.FrameworkInitialize();

      string content = String.Empty;
      Stream stream = Assembly.GetExecutingAssembly()
        .GetManifestResourceStream(GetType(), GetType().Name + ".ascx");
      using (StreamReader reader = new StreamReader(stream))
      {
        content = reader.ReadToEnd();
      }
      Control userControl = Page.ParseControl(content);
      this.Controls.Add(userControl);
    }
  }
}
