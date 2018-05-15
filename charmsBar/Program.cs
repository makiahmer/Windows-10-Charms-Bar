using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charmsBar
{
   static class Program
   {
	  /// <summary>
	  /// The main entry point for the application.
	  /// </summary>
	  [STAThread]
	  static void Main()
	  {
		 Application.EnableVisualStyles();
		 Application.SetCompatibleTextRenderingDefault(false);
		 forms.frmMain startup = new forms.frmMain();
		 //Application.Run();
		 Application.Run(startup);							   //When ready remove the startup reference, this should start the application hidden; https://social.msdn.microsoft.com/Forums/windows/en-US/dece45c8-9076-497e-9414-8cd9b34f572f/how-to-start-a-form-in-hidden-mode?forum=winforms
	  }
   }
}
