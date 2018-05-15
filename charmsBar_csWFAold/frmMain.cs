/*To Do
-Get the showing and hiding events working properly
-Hide application at start up
-Add tasks to the application (namely volume and power options for me)
-Clean up the code including unused includes
-Performance checking, because this application is supposed to be pretty basic resource consuption should be minimal
-Example Navigation Pane
	-Display Icons first
	-If an in charms bar link is chosen (i.e. power options, volume, brightness) expand charms bar to accomodate
	
	//Icon menu
	|	[Windows Flag]	|
	|	[Speakers]		|
	|	[Sun]			|
	|	[Power Symbol]	|
	|	[Cog]			|
	|	[Monkey Eyes Covered]	|
	
	//Expanded Menu
	[icon] "Task Title"
	{Expansion, hidden until its parent is clicked}
	
	
	|	[Windows Flag]	Start		|
	|	[Speakers] System Volume	|
	|	{0 ................ 100}	|
	|								|
	|	[Sun] Screen Brightness		|
	|	{0 ................ 100}	|
	|								|
	|	[Power Symbol] Power		|
	|	{Sleep}						|
	|	{Hibernate}					|
	|	{Shutdown}					|
	|								|
	|	[Cog] Windows Settings		|
	|	[Monkey Eyes Covered]	Hide Pane|
*/

/*Final Customizations
-Add your own shortcuts/commands
   -Open a program
   -Open a settings window
   -Toggles for power mode, bluetooth, wifi, etc (win 10 - action center stuff)
   -This would require adding ini's to the programs folder = application weight
   *I wonder if this couldn't use the applications metro tile? (i.e. drag and drop)
-Change the color of the bar
-Change the timeout of the bar
-Only display in notification area
-Create a key shortcut for the app
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Includes from MouseKeyHook example
using Gma.System.MouseKeyHook;
using Gma.System.MouseKeyHook.Implementation;
using System.Threading;

namespace charmsBar_csWFA
{
   public partial class frmMain : Form
   {
	  private IKeyboardMouseEvents m_Events; //MouseKeyHook
	  public int handleMouseEvent = 0;		 //Whether or not to start the mouse even timer

	  public frmMain()
	  {
		 InitializeComponent();
		 setPosition();
		 this.Hide();                     //TO DO: Leaving this here as proof of intent however, it needs edited: https://msdn.microsoft.com/en-us/library/aa984417(v=vs.71).aspx
		 SubscribeGlobal();               //MouseKeyHook
		 FormClosing += Main_Closing;     //MouseKeyHook
	  }

	  private void frmMain_Load(object sender, EventArgs e)
	  {
	  }

	  private void btnExit_Click(object sender, EventArgs e)
	  {
		 Application.Exit();
	  }



	  /*This method will adjust the size of the form to utilize the 
	  working area of the screen.
	  MSDN: Screen.PrimaryScreen Property
	  */
	  private void setPosition()
	  {
		 // Retrieve the working rectangle from the Screen class
		 // using the Primary Screen and the WorkingArea properties.
		 System.Drawing.Rectangle workingRectangle =
			Screen.PrimaryScreen.WorkingArea;

		 // Set the size of the form slightly less than the size
		 // of the working rectangle.
		 this.Size = new System.Drawing.Size(
			100, workingRectangle.Height);

		 // Set the location so that the entire form is visible
		 this.Location = new System.Drawing.Point(
			workingRectangle.Width - 100, 0);
	  }


	  /*MouseKeyHook Example*/
	  private void Main_Closing(object sender, CancelEventArgs e)
	  {
		 Unsubscribe();
	  }

	  private void SubscribeApplication()
	  {
		 Unsubscribe();
		 Subscribe(Hook.AppEvents());
	  }

	  private void SubscribeGlobal()
	  {
		 Unsubscribe();
		 Subscribe(Hook.GlobalEvents());
	  }

	  private void Subscribe(IKeyboardMouseEvents events)
	  {
		 m_Events = events;
		 //m_Events.KeyDown += OnKeyDown;
		 //m_Events.KeyUp += OnKeyUp;
		 //m_Events.KeyPress += HookManager_KeyPress;

		 //m_Events.MouseUp += OnMouseUp;
		 //m_Events.MouseClick += OnMouseClick;
		 //m_Events.MouseDoubleClick += OnMouseDoubleClick;

		 m_Events.MouseMove += HookManager_MouseMove;

		 //m_Events.MouseDragStarted += OnMouseDragStarted;
		 //m_Events.MouseDragFinished += OnMouseDragFinished;

		 //if (checkBoxSupressMouseWheel.Checked)
		 //m_Events.MouseWheelExt += HookManager_MouseWheelExt;
		 //else
		 //m_Events.MouseWheel += HookManager_MouseWheel;

		 //if (checkBoxSuppressMouse.Checked)
		 //m_Events.MouseDownExt += HookManager_Supress;
		 //else
		 //m_Events.MouseDown += OnMouseDown;
	  }

	  private void Unsubscribe()
	  {
		 if (m_Events == null) return;
		 //m_Events.KeyDown -= OnKeyDown;
		 //m_Events.KeyUp -= OnKeyUp;
		 //m_Events.KeyPress -= HookManager_KeyPress;

		 //m_Events.MouseUp -= OnMouseUp;
		 //m_Events.MouseClick -= OnMouseClick;
		 //m_Events.MouseDoubleClick -= OnMouseDoubleClick;

		 m_Events.MouseMove -= HookManager_MouseMove;

		 //m_Events.MouseDragStarted -= OnMouseDragStarted;
		 //m_Events.MouseDragFinished -= OnMouseDragFinished;

		 //if (checkBoxSupressMouseWheel.Checked)
		 //m_Events.MouseWheelExt -= HookManager_MouseWheelExt;
		 //else
		 //m_Events.MouseWheel -= HookManager_MouseWheel;

		 //if (checkBoxSuppressMouse.Checked)
		 //m_Events.MouseDownExt -= HookManager_Supress;
		 //else
		 //m_Events.MouseDown -= OnMouseDown;

		 m_Events.Dispose();
		 m_Events = null;
	  }

	  private void HookManager_Supress(object sender, MouseEventExtArgs e)
	  {
		 //if (e.Button != MouseButtons.Right)
		 //{
		 //Log(string.Format("MouseDown \t\t {0}\n", e.Button));
		 //return;
		 //}

		 //Log(string.Format("MouseDown \t\t {0} Suppressed\n", e.Button));
		 e.Handled = true;
	  }

	  private void HookManager_MouseMove(object sender, MouseEventArgs e)
	  {
		 //labelMousePosition.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);


		 // Retrieve the working rectangle from the Screen class
		 // using the Primary Screen and the WorkingArea properties.
		 System.Drawing.Rectangle workingRectangle =
			Screen.PrimaryScreen.WorkingArea;

		 /*Cursor is at the edge of the screen*/
		 if (Cursor.Position.X >= workingRectangle.Width - 5)
		 {
			/*Display the charms bar*/
			this.Show();
			this.BackColor = Color.Green;
		 }
		 /*Cursor is over the charms bar area and the charms bar is open*/
		 else if ((Cursor.Position.X >= workingRectangle.Width - 100) && (Cursor.Position.X <= workingRectangle.Width) && (this.Visible))
		 {
			/*TO DO: If there is a timer going stop it*/
			this.BackColor = Color.Orange;      //Testing purposes
		 }
		 /*Cursor is outside the charms bar area and the charms bar is open*/
		 else if ((Cursor.Position.X < workingRectangle.Width - 100) && (this.Visible))
		 {
			/*Set a timer to hide the charms bar*/
			TimerCallback displayTCB = new TimerCallback(hideCharmsBar);                           //When timer completes perform this action
			int displayDueTime = 3 * 1000;                                                         //Amount of time (miliseconds) to wait before action is performed
			int displayPeriod = Timeout.Infinite;                                                  //Amount of time (miliseconds) to wait before future actions are performed (used for repetition)
			System.Threading.Timer displayTimer = new System.Threading.Timer(displayTCB, null, displayDueTime, displayPeriod);         //Instantiate and start a new timer		   
		 }
		 else
		 {
			/*Default case hide the charms bar*/
			this.Hide();
			//this.BackColor = Color.Blue;        //Testing purposes
		 }
	  }

	  private void hideCharmsBar(object state)
	  {
		 /*Capture timer object - This doesn't work properly*/
		 System.Threading.Timer t = (System.Threading.Timer)state;
		 if (t != null) t.Dispose();

		 /*Perform timer action*/
		 //this.Hide();							//FIX_ME: Throws an exception about the form being access from a diff thread than its creator
		 this.BackColor = Color.Crimson;		//Testing purposes
	  }

	  private void btnHide_Click(object sender, EventArgs e)
	  {
		 this.Hide();
	  }

	  private void showToolStripMenuItem_Click(object sender, EventArgs e)
	  {
		 this.Show();
	  }

	  private void trayIcon_menu_hide_Click(object sender, EventArgs e)
	  {
		 this.Hide();
	  }

	  private void trayIcon_menu_exit_Click(object sender, EventArgs e)
	  {
		 Application.Exit();
	  }
   }
}
