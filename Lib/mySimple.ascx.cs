using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
  public class mySimple:UserControl
  {
    protected string foobar;
    protected void Page_Load(object sender, EventArgs e)
    {
      foobar = "hogehoge";
    }
  }
}
