using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charmsBar.forms
{
   public partial class frmAbout : Form
   {
	  /*****************************************************************************************
	  ** FORM INITIALIZATION
	  *****************************************************************************************/
	  public frmAbout()
	  {
		 InitializeComponent();
	  }

	  private void frmAbout_Load(object sender, EventArgs e)
	  {
		 /*Load user settings*/
		 this.ForeColor = settings.displayOptions.Default.userForeColor;
		 this.BackColor = settings.displayOptions.Default.userBackColor;
		 this.ShowInTaskbar = settings.displayOptions.Default.userDisplayInTaskbar;
	  }
   }
}
