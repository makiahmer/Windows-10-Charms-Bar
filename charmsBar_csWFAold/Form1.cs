using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace charmsBar_csWFA
{
   public partial class Form1 : Form
   {
	  public Form1()
	  {
		 InitializeComponent();
	  }

	  private void button1_Click(object sender, EventArgs e)
	  {
		 Application.Exit();
	  }

	  /*This method will adjust the size of the form to utilize the 
	  working area of the screen.
	  MSDN: Screen.PrimaryScreen Property
	  */
	  private void btnResize_Click(object sender, EventArgs e)
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

	  /*Code Project - Processing Global Mouse and Keyboard Hooks in C# by George Mamaladze
	  http://www.codeproject.com/Articles/7294/Processing-Global-Mouse-and-Keyboard-Hooks-in-C 
	  https://github.com/gmamaladze/globalmousekeyhook */
	  UserActivityHook actHook;
	  private void Form1_Load(object sender, EventArgs e)
	  {
		 actHook = new UserActivityHook();      //Create an instance

		 //Hang on events
		 actHook.OnMouseActivity += new MouseEventHandler(MouseMoved);
	  }

	  public void MouseMoved(object sender, MouseEventArgs e)
	  {
		 lblMousePosition.Text = String.Format("X:{0} Y:{1}", e.X, e.Y);
	  }
   }
}