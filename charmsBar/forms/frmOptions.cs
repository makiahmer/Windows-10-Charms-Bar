/***********************************************************************************************
** https://msdn.microsoft.com/en-us/library/aa730869(v=vs.80).aspx
***********************************************************************************************/
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
   public partial class frmOptions : Form
   {
	  /*****************************************************************************************
	  ** FORM INITIALIZATION
	  *****************************************************************************************/
	  public frmOptions()
	  {
		 InitializeComponent();
	  }

	  private void frmOptions_Load(object sender, EventArgs e)
	  {
		 /*Load user options*/
		 this.ForeColor = settings.displayOptions.Default.userForeColor;
		 this.BackColor = settings.displayOptions.Default.userBackColor;
		 this.ShowInTaskbar = settings.displayOptions.Default.userDisplayInTaskbar;

		 /*Load users options to form controls*/
		 txtChangeColor.ForeColor = settings.displayOptions.Default.userForeColor;
		 txtChangeColor.BackColor = settings.displayOptions.Default.userBackColor;
		 chkDisplayInTaskbar.Checked = settings.displayOptions.Default.userDisplayInTaskbar;
		 chkStartup.Checked = settings.displayOptions.Default.userStartup;
		 txtChangeDisplayTimeout.Text = settings.displayOptions.Default.defaultDisplayTimeout.ToString();
	  }


	  /*****************************************************************************************
	  ** CONTROL EVENTS
	  *****************************************************************************************/
	  private void btnChangeBackColor_Click(object sender, EventArgs e)
	  {
		 frmOptions_colorDialog.ShowDialog();
		 txtChangeColor.BackColor = frmOptions_colorDialog.Color;
	  }

	  private void btnChangeForeColor_Click(object sender, EventArgs e)
	  {
		 frmOptions_colorDialog.ShowDialog();
		 txtChangeColor.ForeColor = frmOptions_colorDialog.Color;
	  }


	  /*****************************************************************************************
	  ** BUTTON EVENTS
	  *****************************************************************************************/
	  private void btnDefaults_Click(object sender, EventArgs e)
	  {
		 /*Set users options to default options*/
		 txtChangeColor.ForeColor = settings.displayOptions.Default.defaultForeColor;
		 txtChangeColor.BackColor = settings.displayOptions.Default.defaultBackColor;
		 txtChangeDisplayTimeout.Text = settings.displayOptions.Default.defaultDisplayTimeout.ToString();
		 chkDisplayInTaskbar.Checked = settings.displayOptions.Default.defaultDisplayInTaskbar;
		 chkStartup.Checked = settings.displayOptions.Default.defaultStartup;
	  }

	  private void btnSave_Click(object sender, EventArgs e)
	  {
		 /*Save changes and close form*/
		 settings.displayOptions.Default.userForeColor = txtChangeColor.ForeColor;              //Assign users choices to their settings
		 settings.displayOptions.Default.userBackColor = txtChangeColor.BackColor;
		 settings.displayOptions.Default.userDisplayTimeout = TimeSpan.Parse("00:00:" + txtChangeDisplayTimeout.Value);
		 settings.displayOptions.Default.userDisplayInTaskbar = chkDisplayInTaskbar.Checked;
		 settings.displayOptions.Default.userStartup = chkStartup.Checked;
		 Properties.Settings.Default.Save();                   //Save the users new settings
		 this.frmOptions_Load(null, null);                     //Reload this form
		 this.Close();
	  }

	  private void btnClose_Click(object sender, EventArgs e)
	  {
		 /*No changes will be saved unless the user clicks save*/
		 this.Close();
	  }
   }
}
