using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;                                       //https://msdn.microsoft.com/en-us/library/3x6at5a0(v=vs.110).aspx
using System.Text;
using System.Runtime.InteropServices;                          //Using this for window animation
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using NAudio.CoreAudioApi;									   //Volume functionality
//using System.Threading;									   //Necessary for timeouts?

namespace charmsBar.forms
{
   public partial class frmMain : Form
   {
	  /*****************************************************************************************
	  ** FORM GLOBALS (Used for form animation)
	  *****************************************************************************************/
	  /********************************************************
	  ** The code below is used for animation of windows
	  ** https://msdn.microsoft.com/en-us/library/windows/desktop/ms632669(v=vs.85).aspx
	  ** http://www.c-sharpcorner.com/uploadfile/kirtan007/sliding-effect-in-windows-form-application/
	  ** http://www.dreamincode.net/forums/topic/109668-animating-a-windows-form/
	  ********************************************************/
	  [DllImport("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
	  //Example call: AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
	  private static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

	  [Flags]
	  enum AnimateWindowFlags
	  {
		 AW_HOR_POSITIVE = 0x00000001,
		 AW_HOR_NEGATIVE = 0x00000002,
		 AW_VER_POSITIVE = 0x00000004,
		 AW_VER_NEGATIVE = 0x00000008,
		 AW_CENTER = 0x00000010,
		 AW_HIDE = 0x00010000,
		 AW_ACTIVATE = 0x00020000,
		 AW_SLIDE = 0x00040000,
		 AW_BLEND = 0x00080000
	  }


	  /********************************************************
	  ** The code below is used to gain up/dn/mt access to windows volume
	  ** http://stackoverflow.com/a/13139478/5443200
	  ** https://msdn.microsoft.com/en-us/library/windows/desktop/ms646275(v=vs.85).aspx
	  ********************************************************/
	  [DllImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true)]
	  public static extern IntPtr SendMessageW(                // hWnd - Window handler (WinDef.h)
		 IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);  // Msg - Command to be sent
															   // wParam - message parameters (WinDef.h)
	  private const int WM_APPCOMMAND = 0x319;                 // lParam - message parameter (WinDef.h)
	  private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
	  private const int APPCOMMAND_VOLUME_UP = 0xA0000;
	  private const int APPCOMMAND_VOLUME_DOWN = 0x90000;

	  private void Mute()
	  {
		 SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
			(IntPtr)APPCOMMAND_VOLUME_MUTE);
	  }

	  private void VolDown()
	  {
		 SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
			(IntPtr)APPCOMMAND_VOLUME_DOWN);
	  }

	  private void VolUp()
	  {
		 SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
			(IntPtr)APPCOMMAND_VOLUME_UP);
	  }

	  /********************************************************
	  ** The code below is used to gain get/set access to windows volume
	  ** this would be my prefered method, however it is out of my league currently
	  ** A) I don't know where to obtain the device id
	  ** B) I don't know how to convert to the UInt32 data types
	  ** https://social.msdn.microsoft.com/Forums/en-US/1e7008b9-cc08-495c-90d8-4daa96c56e5e/controlling-the-audio-volume-in-c?forum=csharpgeneral
	  ** https://msdn.microsoft.com/en-us/library/aa719104.aspx
	  ** https://msdn.microsoft.com/en-us/library/windows/hardware/ff536165(v=vs.85).aspx
	  *******************************************************
	  [DllImport("winmm.dll", EntryPoint = "")]
	  public static extern long waveOutSetVolume(UInt32 deviceID, UInt32 Volume);
	  [DllImport("winmm.dll", EntryPoint = "")]
	  public static extern long waveOutGetVolume(UInt32 deviceID, out UInt32 Volume);
	  */

	  /********************************************************
	  ** The code below is used to gain get/set access to monitor brightness
	  ** https://msdn.microsoft.com/en-us/library/windows/desktop/dd692972(v=vs.85).aspx
	  *******************************************************
	  */

	  /*****************************************************************************************
	  ** FORM INITIALIZATION (& ANIMATIONS)
	  *****************************************************************************************/
	  public frmMain()
	  {
		 InitializeComponent();
	  }

	  private void frmMain_Load(object sender, EventArgs e)
	  {
		 repositionBar(150);
		 refreshBar();
		 this.Hide();                                          //This is a background application so we hide the form at startup.

		 /*Programmatic Element Styling*/
		 setProgrammaticStyles();


		 /*Load user settings*/
		 //this.ForeColor = settings.displayOptions.Default.userForeColor;
		 //this.BackColor = settings.displayOptions.Default.userBackColor;
		 this.ShowInTaskbar = settings.displayOptions.Default.userDisplayInTaskbar;
	  }

	  private void setProgrammaticStyles()
	  {
		 /*Button Mouse Overs*/
		 btnAbout.MouseEnter += new System.EventHandler(btnAbout_btnMouseEnter);
		 btnAbout.MouseLeave += new System.EventHandler(btnAbout_btnMouseLeave);

		 btnOptions.MouseEnter += new System.EventHandler(btnOptions_btnMouseEnter);
		 btnOptions.MouseLeave += new System.EventHandler(btnOptions_btnMouseLeave);

		 btnExpand.MouseEnter += new System.EventHandler(btnExpand_btnMouseEnter);
		 btnExpand.MouseLeave += new System.EventHandler(btnExpand_btnMouseLeave);

		 btnCollapse.MouseEnter += new System.EventHandler(btnCollapse_btnMouseEnter);
		 btnCollapse.MouseLeave += new System.EventHandler(btnCollapse_btnMouseLeave);

		 btnExit.MouseEnter += new System.EventHandler(btnExit_btnMouseEnter);
		 btnExit.MouseLeave += new System.EventHandler(btnExit_btnMouseLeave);

		 btnHide.MouseEnter += new System.EventHandler(btnHide_btnMouseEnter);
		 btnHide.MouseLeave += new System.EventHandler(btnHide_btnMouseLeave);

		 /*Track Bar Styling*/
	  }


	  /*Load values into bar controls*/
	  private void refreshBar()
	  {
		 /*System brightness*/
		 int supported = 0;
		 int brightness = MonitorProfiler.Win32.SystemBrightnessChanger.GetBrightness(this.Handle);
		 lblBrightness.Text = brightness.ToString() + "%";

		 if (supported == 1)
		 {
			trackBarBrightness.Value = 0;
			lblBrightness.Text = trackBarBrightness.Value.ToString() + "%";
		 }
		 else
		 {
			trackBarBrightness.Enabled = false;
		 }

		 /*System Volume*/
		 //trackBarVolume.Value = 0;
		 trackBarVolume.Value = SystemVolumeChanger.GetVolume();
		 lblVolumeValue.Text = trackBarVolume.Value.ToString() + "%";

	  }

	  /*This method will adjust the size of the form to utilize the 
	  working area of the screen.
	  MSDN: Screen.PrimaryScreen Property
	  */
	  private void repositionBar(int newWidth)
	  {
		 // Retrieve the working rectangle from the Screen class
		 // using the Primary Screen and the WorkingArea properties.
		 System.Drawing.Rectangle workingRectangle =
			Screen.PrimaryScreen.WorkingArea;

		 // Set the size of the form slightly less than the size
		 // of the working rectangle.
		 this.Size = new System.Drawing.Size(
			newWidth, workingRectangle.Height);

		 // Set the location so that the entire form is visible
		 this.Location = new System.Drawing.Point(
			workingRectangle.Width - newWidth, 0);
	  }

	  /*Slides bar in from the right*/
	  private void displayBar(int speed)
	  {
		 AnimateWindow(this.Handle, speed, /*AnimateWindowFlags.AW_BLEND |*/ AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_NEGATIVE);       //The blend is a cool effect too but doesn't suit my purposes
		 refreshBar();
	  }

	  /*Expands bar to display full contents*/
	  private void expandBar()
	  {
		 this.repositionBar(500);
		 this.Hide();                                          //Cheese dick method of animating bar growth, however this won't work for collapse
		 this.displayBar(300);                                 //Possible alternative: http://stackoverflow.com/questions/1769317/animate-window-resize-width-and-height-c-sharp-wpf
	  }

	  /*Collapses bar to display default contents*/
	  private void collapseBar()
	  {
		 this.repositionBar(150);
	  }

	  /*Slides the bar into the side*/
	  private void hideBar(int speed)
	  {
		 AnimateWindow(this.Handle, speed, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_HOR_POSITIVE | AnimateWindowFlags.AW_HIDE);
	  }


	  /*****************************************************************************************
	  ** BUTTON EVENTS
	  *****************************************************************************************/
	  /*There has to be a generic way to target any button hovered....*/
	  private void btnAbout_btnMouseEnter(Object sender, EventArgs e) { handleBtnEnter(btnAbout); }
	  private void btnOptions_btnMouseEnter(Object sender, EventArgs e) { handleBtnEnter(btnOptions); }
	  private void btnExpand_btnMouseEnter(Object sender, EventArgs e) { handleBtnEnter(btnExpand); }
	  private void btnCollapse_btnMouseEnter(Object sender, EventArgs e) { handleBtnEnter(btnCollapse); }
	  private void btnExit_btnMouseEnter(Object sender, EventArgs e) { handleBtnEnter(btnExit); }
	  private void btnHide_btnMouseEnter(Object sender, EventArgs e) { handleBtnEnter(btnHide); }

	  private void btnAbout_btnMouseLeave(Object sender, EventArgs e) { handleBtnLeave(btnAbout); }
	  private void btnOptions_btnMouseLeave(Object sender, EventArgs e) { handleBtnLeave(btnOptions); }
	  private void btnExpand_btnMouseLeave(Object sender, EventArgs e) { handleBtnLeave(btnExpand); }
	  private void btnCollapse_btnMouseLeave(Object sender, EventArgs e) { handleBtnLeave(btnCollapse); }
	  private void btnExit_btnMouseLeave(Object sender, EventArgs e) { handleBtnLeave(btnExit); }
	  private void btnHide_btnMouseLeave(Object sender, EventArgs e) { handleBtnLeave(btnHide); }

	  private void handleBtnEnter(Button target)
	  {
		 target.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
	  }

	  private void handleBtnLeave(Button target)
	  {
		 target.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(35, 135, 255);
	  }
	  /*//END// button hover effects*/

	  private void btnOptions_Click(object sender, EventArgs e)
	  {
		 frmOptions options = new frmOptions();
		 options.FormClosed += new FormClosedEventHandler(optionsChanged);
		 options.Show();
		 this.hideBar(200);
	  }

	  private void optionsChanged(object sender, FormClosedEventArgs e)    //http://stackoverflow.com/a/7406638/5443200
	  {
		 this.frmMain_Load(null, null);
		 this.displayBar(200);
	  }

	  private void btnAbout_Click(object sender, EventArgs e)
	  {
		 frmAbout about = new frmAbout();
		 //about.FormClosed += new FormClosedEventHandler(aboutClosed);
		 about.Show();
		 this.hideBar(200);
	  }
	  //private void aboutClosed(object sender, FormClosedEventArgs e)
	  //{
	  //this.displayBar();
	  //}

	  private void btnVolUp_Click(object sender, EventArgs e)
	  {
		 VolUp();
	  }

	  private void btnVolMute_Click(object sender, EventArgs e)
	  {
		 Mute();
	  }

	  private void btnVolDown_Click(object sender, EventArgs e)
	  {
		 VolDown();
	  }

	  private void trackBarVolume_Scroll(object sender, EventArgs e)
	  {
		 SystemVolumeChanger.SetVolume(trackBarVolume.Value);
		 lblVolumeValue.Text = trackBarVolume.Value.ToString() + "%";
	  }

	  private void btnBrightnessToggle_Click(object sender, EventArgs e)
	  {
		 int brightness = trackBarBrightness.Value;
		 
		 if(brightness < 25)
		 {
			//Set brightness to 25%
		 }
		 else if (brightness >= 25)
		 {
			//Set brightness to 50%
		 }
		 else if (brightness >= 50)
		 {
			//Set brightness to 75%
		 }
		 else if (brightness >= 75)
		 {
			//Set brightness to 100%
		 }
	  }

	  private void trackBarBrightness_Scroll(object sender, EventArgs e)
	  {
		 lblBrightness.Text = trackBarBrightness.Value.ToString();
	  }

	  private void btnExpand_Click(object sender, EventArgs e)
	  {
		 this.expandBar();
	  }

	  private void btnCollapse_Click(object sender, EventArgs e)
	  {
		 this.collapseBar();
	  }

	  private void btnHide_Click(object sender, EventArgs e)
	  {
		 this.hideBar(200);
	  }

	  private void btnExit_Click(object sender, EventArgs e)
	  {
		 Application.Exit();
	  }


	  /*****************************************************************************************
	  ** NOTIFICATION TRAY EVENTS
	  *****************************************************************************************/
	  private void cm_notifyIcon_help_Click(object sender, EventArgs e)
	  {
		 frmAbout about = new frmAbout();                      //Open the about window
		 about.Show();
	  }

	  private void cm_notifyIcon_show_Click(object sender, EventArgs e)
	  {
		 this.displayBar(200);                                    //Display the charms bar
	  }

	  private void cm_notifyIcon_hide_Click(object sender, EventArgs e)
	  {
		 this.hideBar(200);                                          //Hide the charms bar
	  }

	  private void cm_notifyIcon_exit_Click(object sender, EventArgs e)
	  {
		 Application.Exit();                                   //Exit the application
	  }

	  private void notifiyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
	  {
		 this.displayBar(200);
	  }


	  /*****************************************************************************************
	  ** TIMED EVENTS
	  *****************************************************************************************/
   }



   /*###########################################################################################
   ## http://stackoverflow.com/a/15251649/5443200
   ###########################################################################################*/
   static class NativeMethods
   {
	  /*Volume Controls*/
	  [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume", SetLastError = true)]
	  public static extern int WaveOutSetVolume(IntPtr hwo, uint dwVolume);


	  [DllImport("winmm.dll", EntryPoint = "PlaySound", SetLastError = true)]
	  public static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);


	  /*Screen Brightness Controls
	  [DllImport("Dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR", SetLastError = true)]
	  public static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] pPhysicalMonitorArray);


	  [DllImport("Dxva2.dll", EntryPoint ="GetMonitorCapabilities", SetLastError = true)]
	  public static extern bool GetMonitorCapabilities(IntPtr hMonitor, ref uint pdwMonitorCapabilities, ref uint pdwSupportedColorTemperatures);


	  [DllImport("Dxva2.dll", EntryPoint= "CapabilitiesRequestAndCapabilitiesReply", SetLastError = true)]
	  public static extern bool CapabilitiesRequestAndCapabilitiesReply();


	  [DllImport("Dxva2.dll", EntryPoint = "DestroyPhysicalMonitor", SetLastError = true)]
	  public static extern bool DestroyPhysicalMonitor(IntPtr hMonitor);


	  [DllImport("Dxva2.dll", EntryPoint = "GetMonitorBrightness", SetLastError = true)]
	  public static extern bool GetMonitorBrightness();


	  [DllImport("Dxva2.dll", EntryPoint = "SetMonitorBrightness", SetLastError = true)]
	  public static extern bool SetMonitorBrightness();*/
   }

   public static class MSWindowsFriendlyNames
   {
	  public static string WindowsXP { get { return "Windows XP"; } }
	  public static string WindowsVista { get { return "Windows Vista"; } }
	  public static string Windows7 { get { return "Windows 7"; } }
	  public static string Windows8 { get { return "Windows 8"; } }
   }

   public static class SystemVolumeChanger
   {
	  public static void SetVolume(int value)
	  {
		 if (value < 0)
			value = 0;

		 if (value > 100)
			value = 100;

		 var osFriendlyName = GetOSFriendlyName();

		 /* http://stackoverflow.com/questions/15250379/change-master-audio-volume-from-xp-to-windows-8-in-c-sharp
		 ** warning your way of checking the windows version is incredibly fragile. – Daniel A. White Oct 8 '14 at 18:20
		 */
		 if (osFriendlyName.Contains(MSWindowsFriendlyNames.WindowsXP))
		 {
			SetVolumeForWIndowsXP(value);
		 }
		 else if (osFriendlyName.Contains(MSWindowsFriendlyNames.WindowsVista) || osFriendlyName.Contains(MSWindowsFriendlyNames.Windows7) || osFriendlyName.Contains(MSWindowsFriendlyNames.Windows8))
		 {
			SetVolumeForWIndowsVista78(value);
		 }
		 else
		 {
			SetVolumeForWIndowsVista78(value);
		 }
	  }

	  public static int GetVolume()
	  {
		 int result = 100;
		 try
		 {
			MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
			//MMDevice device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia); /*http://stackoverflow.com/a/27818455/5443200*/
			 MMDevice device = DevEnum.GetDefaultAudioEndpoint((DataFlow)0, (Role)1);
			result = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
		 }
		 catch (Exception)
		 {
		 }

		 return result;
	  }

	  private static void SetVolumeForWIndowsVista78(int value)
	  {
		 try
		 {
			MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
			//MMDevice device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia); /*http://stackoverflow.com/a/27818455/5443200*/
			MMDevice device = DevEnum.GetDefaultAudioEndpoint((DataFlow)0, (Role)1);
			device.AudioEndpointVolume.MasterVolumeLevelScalar = (float)value / 100.0f;
		 }
		 catch (Exception)
		 {
		 }
	  }

	  private static void SetVolumeForWIndowsXP(int value)
	  {
		 try
		 {
			// Calculate the volume that's being set
			double newVolume = ushort.MaxValue * value / 10.0;

			uint v = ((uint)newVolume) & 0xffff;
			uint vAll = v | (v << 16);

			// Set the volume
			int retVal = NativeMethods.WaveOutSetVolume(IntPtr.Zero, vAll);
		 }
		 catch (Exception)
		 {
		 }
	  }

	  private static string GetOSFriendlyName()
	  {
		 string result = string.Empty;

		 ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
		 foreach (ManagementObject os in searcher.Get())
		 {
			result = os["Caption"].ToString();
			break;
		 }
		 return result;
	  }
   }
}


namespace MonitorProfiler.Win32
{
   public class NativeMethods
   {
	  public delegate bool MonitorEnumDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref Rectangle lprcMonitor, IntPtr dwData);

	  [DllImport("user32.dll")]
	  public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip,
		 MonitorEnumDelegate lpfnEnum, IntPtr dwData);

	  [DllImport("user32.dll")]
	  public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum,
		  ref NativeStructures.DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

	  [DllImport("user32.dll")]
	  public static extern bool GetMonitorInfo(IntPtr hmon, ref NativeStructures.MonitorInfoEx mi);

	  [DllImport("user32.dll", EntryPoint = "MonitorFromWindow", SetLastError = true)]
	  public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, uint dwFlags);

	  [DllImport("user32.dll", EntryPoint = "MonitorFromPoint", SetLastError = true)]
	  public static extern IntPtr MonitorFromPoint([In] Point pt, uint dwFlags);

	  [DllImport("user32.dll", EntryPoint = "MonitorFromRect", SetLastError = true)]
	  public static extern IntPtr MonitorFromRect(ref Rectangle lprect, uint dwFlags);

	  [DllImport("dxva2.dll", EntryPoint = "GetNumberOfPhysicalMonitorsFromHMONITOR", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, ref uint pdwNumberOfPhysicalMonitors);

	  [DllImport("dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetPhysicalMonitorsFromHMONITOR(
		  IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] NativeStructures.PHYSICAL_MONITOR[] pPhysicalMonitorArray);

	  [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitors", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool DestroyPhysicalMonitors(
		  uint dwPhysicalMonitorArraySize, [Out] NativeStructures.PHYSICAL_MONITOR[] pPhysicalMonitorArray);

	  [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitor", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool DestroyPhysicalMonitor(IntPtr hMonitor);

	  [DllImport("dxva2.dll", EntryPoint = "GetMonitorTechnologyType", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetMonitorTechnologyType(
		  IntPtr hMonitor, ref NativeStructures.MC_DISPLAY_TECHNOLOGY_TYPE pdtyDisplayTechnologyType);

	  [DllImport("dxva2.dll", EntryPoint = "GetMonitorCapabilities", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetMonitorCapabilities(
		  IntPtr hMonitor, ref uint pdwMonitorCapabilities, ref uint pdwSupportedColorTemperatures);

	  [DllImport("dxva2.dll", EntryPoint = "SetMonitorBrightness", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool SetMonitorBrightness([In]IntPtr hMonitor, [In]uint pdwNewBrightness);

	  [DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetMonitorBrightness(
		  [In]IntPtr hMonitor, ref uint pdwMinimumBrightness, ref uint pdwCurrentBrightness, ref uint pdwMaximumBrightness);

	  [DllImport("dxva2.dll", EntryPoint = "SetMonitorContrast", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool SetMonitorContrast([In]IntPtr hMonitor, [In]uint pdwNewContrast);

	  [DllImport("dxva2.dll", EntryPoint = "GetMonitorContrast", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetMonitorContrast(
		  [In]IntPtr hMonitor, ref uint pdwMinimumContrast, ref uint pdwCurrentContrast, ref uint pdwMaximumContrast);

	  [DllImport("dxva2.dll", EntryPoint = "GetMonitorRedGreenOrBlueDrive", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetMonitorRedGreenOrBlueDrive(
		  [In]IntPtr hMonitor, [In]NativeStructures.MC_DRIVE_TYPE dtDriveType,
		  ref uint pdwMinimumDrive, ref uint pdwCurrentDrive, ref uint pdwMaximumDrive);

	  [DllImport("dxva2.dll", EntryPoint = "GetMonitorRedGreenOrBlueGain", SetLastError = true)]
	  [return: MarshalAs(UnmanagedType.Bool)]
	  public static extern bool GetMonitorRedGreenOrBlueGain(
		  [In]IntPtr hMonitor, [In]NativeStructures.MC_GAIN_TYPE dtDriveType,
		  ref uint pdwMinimumGain, ref uint pdwCurrentGain, ref uint pdwMaximumGain);


	  [DllImport("user32.dll", CharSet = CharSet.Auto)]
	  public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

	  public static void ScrollToBottom(System.Windows.Forms.TextBox txtBox)
	  {
		 // Scroll to the bottom, without moving the caret position.
		 NativeMethods.SendMessage(txtBox.Handle, NativeConstants.WM_VSCROLL, (IntPtr)NativeConstants.SB_BOTTOM, IntPtr.Zero);
	  }


   }

   public class NativeConstants
   {
	  public const int MONITOR_DEFAULTTOPRIMARY = 1;
	  public const int MONITOR_DEFAULTTONEAREST = 2;
	  public const int MONITOR_DEFAULTTONULL = 0;

	  public const int WM_VSCROLL = 0x115;
	  public const int WM_HSCROLL = 0x114;

	  public const int SB_LINEDOWN = 1;
	  public const int SB_LINEUP = 0;
	  public const int SB_TOP = 6;
	  public const int SB_BOTTOM = 7;
	  public const int SB_PAGEUP = 2;
	  public const int SB_PAGEDOWN = 3;

   }

   public class NativeStructures
   {
	  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	  public struct PHYSICAL_MONITOR
	  {
		 public IntPtr hPhysicalMonitor;

		 [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		 public string szPhysicalMonitorDescription;
	  }

	  [StructLayout(LayoutKind.Sequential)]
	  public struct RECT
	  {
		 public int left;
		 public int top;
		 public int right;
		 public int bottom;
	  }

	  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	  public class MonitorInfoEx
	  {
		 public int cbSize;
		 public RECT rcMonitor; // Total area  
		 public RECT rcWork; // Working area  
		 public int dwFlags;
		 [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		 public string szDeviceName;
	  }

	  public enum MC_DISPLAY_TECHNOLOGY_TYPE
	  {
		 MC_SHADOW_MASK_CATHODE_RAY_TUBE,
		 MC_APERTURE_GRILL_CATHODE_RAY_TUBE,
		 MC_THIN_FILM_TRANSISTOR,
		 MC_LIQUID_CRYSTAL_ON_SILICON,
		 MC_PLASMA,
		 MC_ORGANIC_LIGHT_EMITTING_DIODE,
		 MC_ELECTROLUMINESCENT,
		 MC_MICROELECTROMECHANICAL,
		 MC_FIELD_EMISSION_DEVICE,
	  }

	  public enum MC_MONITOR_CAPABILITIES
	  {
		 MC_CAPS_NONE = 0x00000000,
		 MC_CAPS_MONITOR_TECHNOLOGY_TYPE = 0x00000001,
		 MC_CAPS_BRIGHTNESS = 0x00000002,
		 MC_CAPS_CONTRAST = 0x00000004,
		 MC_CAPS_COLOR_TEMPERATURE = 0x00000008,
		 MC_CAPS_RED_GREEN_BLUE_GAIN = 0x00000010,
		 MC_CAPS_RED_GREEN_BLUE_DRIVE = 0x00000020,
		 MC_CAPS_DEGAUSS = 0x00000040,
		 MC_CAPS_DISPLAY_AREA_POSITION = 0x00000080,
		 MC_CAPS_DISPLAY_AREA_SIZE = 0x00000100,
		 MC_CAPS_RESTORE_FACTORY_DEFAULTS = 0x00000400,
		 MC_CAPS_RESTORE_FACTORY_COLOR_DEFAULTS = 0x00000800,
		 MC_RESTORE_FACTORY_DEFAULTS_ENABLES_MONITOR_SETTINGS = 0x00001000
	  }

	  public enum MC_DRIVE_TYPE
	  {
		 MC_RED_DRIVE = 0,
		 MC_GREEN_DRIVE = 1,
		 MC_BLUE_DRIVE = 2
	  }

	  public enum MC_GAIN_TYPE
	  {
		 MC_RED_GAIN = 0,
		 MC_GREEN_GAIN = 1,
		 MC_BLUE_GAIN = 2
	  }

	  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	  public struct DISPLAY_DEVICE
	  {
		 [MarshalAs(UnmanagedType.U4)]
		 public int cb;
		 [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		 public string DeviceName;
		 [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		 public string DeviceString;
		 [MarshalAs(UnmanagedType.U4)]
		 public DisplayDeviceStateFlags StateFlags;
		 [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		 public string DeviceID;
		 [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		 public string DeviceKey;
	  }

	  [Flags()]
	  public enum DisplayDeviceStateFlags : int
	  {
		 /// <summary>The device is part of the desktop.</summary>
		 AttachedToDesktop = 0x1,
		 MultiDriver = 0x2,
		 /// <summary>The device is part of the desktop.</summary>
		 PrimaryDevice = 0x4,
		 /// <summary>Represents a pseudo device used to mirror application drawing for remoting or other purposes.</summary>
		 MirroringDriver = 0x8,
		 /// <summary>The device is VGA compatible.</summary>
		 VGACompatible = 0x16,
		 /// <summary>The device is removable; it cannot be the primary display.</summary>
		 Removable = 0x20,
		 /// <summary>The device has more display modes than its output devices support.</summary>
		 ModesPruned = 0x8000000,
		 Remote = 0x4000000,
		 Disconnect = 0x2000000
	  }
   }

   public static class SystemBrightnessChanger
   {
	  public static int GetBrightness(IntPtr myHandle)
	  {
		 /*DECLARATIONS*/
		 //IntPtr myHandle = charmsBar.forms.frmMain.ActiveForm.Handle;
		 IntPtr hMonitor = NativeMethods.MonitorFromWindow(myHandle, NativeConstants.MONITOR_DEFAULTTOPRIMARY);
		 int lastWin32Error = Marshal.GetLastWin32Error();

		 uint pdwNumberOfPhysicalMonitors = 0u;
		 bool numberOfPhysicalMonitorsFromHmonitor = NativeMethods.GetNumberOfPhysicalMonitorsFromHMONITOR(
			hMonitor, ref pdwNumberOfPhysicalMonitors);
		 lastWin32Error = Marshal.GetLastWin32Error();

		 NativeStructures.PHYSICAL_MONITOR[] pPhysicalMonitorArray =
			new NativeStructures.PHYSICAL_MONITOR[pdwNumberOfPhysicalMonitors];
		 bool physicalMonitorsFromHmonitor = NativeMethods.GetPhysicalMonitorsFromHMONITOR(
			hMonitor, pdwNumberOfPhysicalMonitors, pPhysicalMonitorArray);
		 lastWin32Error = Marshal.GetLastWin32Error();

		 uint pdwMonitorCapabilities = 0u;
		 uint pdwSupportedColorTemperatures = 0u;
		 var monitorCapabilities = NativeMethods.GetMonitorCapabilities(
			pPhysicalMonitorArray[0].hPhysicalMonitor, ref pdwMonitorCapabilities, ref pdwSupportedColorTemperatures);
		 lastWin32Error = Marshal.GetLastWin32Error();

		 NativeStructures.MC_DISPLAY_TECHNOLOGY_TYPE type =
			NativeStructures.MC_DISPLAY_TECHNOLOGY_TYPE.MC_SHADOW_MASK_CATHODE_RAY_TUBE;
		 var monitorTechnologyType = NativeMethods.GetMonitorTechnologyType(
			pPhysicalMonitorArray[0].hPhysicalMonitor, ref type);
		 lastWin32Error = Marshal.GetLastWin32Error();

		 /*PROCESS*/
		 uint minBrightness = 0u;
		 uint curBrightness = 0u;
		 uint maxBrightness = 0u;
		 var getMonitorBrightness = NativeMethods.GetMonitorBrightness(
			pPhysicalMonitorArray[0].hPhysicalMonitor, ref minBrightness, ref curBrightness, ref maxBrightness);
		 lastWin32Error = Marshal.GetLastWin32Error();

		 /*Clean Up*/
		 var destroyPhysicalMonitors = NativeMethods.DestroyPhysicalMonitors(
			pdwNumberOfPhysicalMonitors, pPhysicalMonitorArray);
		 lastWin32Error = Marshal.GetLastWin32Error();

		 return (int)curBrightness;
	  }

	  public static void SetBrightness(int value)
	  {

	  }
   }

   /*public Window1() { InitializeComponent(); }

   private void Button_Click(object sender, RoutedEventArgs e)
   {
	   WindowInteropHelper helper = new WindowInteropHelper(this);

	   IntPtr hMonitor = NativeMethods.MonitorFromWindow(helper.Handle, NativeConstants.MONITOR_DEFAULTTOPRIMARY);
	   int lastWin32Error = Marshal.GetLastWin32Error();

	   uint pdwNumberOfPhysicalMonitors = 0u;
	   bool numberOfPhysicalMonitorsFromHmonitor = NativeMethods.GetNumberOfPhysicalMonitorsFromHMONITOR(
		   hMonitor, ref pdwNumberOfPhysicalMonitors);
	   lastWin32Error = Marshal.GetLastWin32Error();

	   NativeStructures.PHYSICAL_MONITOR[] pPhysicalMonitorArray =
		   new NativeStructures.PHYSICAL_MONITOR[pdwNumberOfPhysicalMonitors];
	   bool physicalMonitorsFromHmonitor = NativeMethods.GetPhysicalMonitorsFromHMONITOR(
		   hMonitor, pdwNumberOfPhysicalMonitors, pPhysicalMonitorArray);
	   lastWin32Error = Marshal.GetLastWin32Error();

	   uint pdwMonitorCapabilities = 0u;
	   uint pdwSupportedColorTemperatures = 0u;
	   var monitorCapabilities = NativeMethods.GetMonitorCapabilities(
		   pPhysicalMonitorArray[0].hPhysicalMonitor, ref pdwMonitorCapabilities, ref pdwSupportedColorTemperatures);
	   lastWin32Error = Marshal.GetLastWin32Error();

	   NativeStructures.MC_DISPLAY_TECHNOLOGY_TYPE type =
		   NativeStructures.MC_DISPLAY_TECHNOLOGY_TYPE.MC_SHADOW_MASK_CATHODE_RAY_TUBE;
	   var monitorTechnologyType = NativeMethods.GetMonitorTechnologyType(
		   pPhysicalMonitorArray[0].hPhysicalMonitor, ref type);
	   lastWin32Error = Marshal.GetLastWin32Error();

	   var destroyPhysicalMonitors = NativeMethods.DestroyPhysicalMonitors(
		   pdwNumberOfPhysicalMonitors, pPhysicalMonitorArray);
	   lastWin32Error = Marshal.GetLastWin32Error();

	   this.lbl.Content = type;
   }*/
}