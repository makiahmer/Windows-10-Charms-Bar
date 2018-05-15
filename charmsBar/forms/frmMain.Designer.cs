namespace charmsBar.forms
{
   partial class frmMain
   {
	  /// <summary>
	  /// Required designer variable.
	  /// </summary>
	  private System.ComponentModel.IContainer components = null;

	  /// <summary>
	  /// Clean up any resources being used.
	  /// </summary>
	  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	  protected override void Dispose(bool disposing)
	  {
		 if (disposing && (components != null))
		 {
			components.Dispose();
		 }
		 base.Dispose(disposing);
	  }

	  #region Windows Form Designer generated code

	  /// <summary>
	  /// Required method for Designer support - do not modify
	  /// the contents of this method with the code editor.
	  /// </summary>
	  private void InitializeComponent()
	  {
		 this.components = new System.ComponentModel.Container();
		 System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
		 this.notifiyIcon = new System.Windows.Forms.NotifyIcon(this.components);
		 this.cm_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
		 this.cm_notifyIcon_help = new System.Windows.Forms.ToolStripMenuItem();
		 this.cm_notifyIcon_show = new System.Windows.Forms.ToolStripMenuItem();
		 this.cm_notifyIcon_hide = new System.Windows.Forms.ToolStripMenuItem();
		 this.cm_notifyIcon_exit = new System.Windows.Forms.ToolStripMenuItem();
		 this.btnHide = new System.Windows.Forms.Button();
		 this.btnExit = new System.Windows.Forms.Button();
		 this.btnOptions = new System.Windows.Forms.Button();
		 this.btnAbout = new System.Windows.Forms.Button();
		 this.btnExpand = new System.Windows.Forms.Button();
		 this.btnCollapse = new System.Windows.Forms.Button();
		 this.btnVolDown = new System.Windows.Forms.Button();
		 this.btnVolMute = new System.Windows.Forms.Button();
		 this.btnVolUp = new System.Windows.Forms.Button();
		 this.trackBarVolume = new System.Windows.Forms.TrackBar();
		 this.lblVolumeValue = new System.Windows.Forms.Label();
		 this.lblBrightness = new System.Windows.Forms.Label();
		 this.trackBarBrightness = new System.Windows.Forms.TrackBar();
		 this.btnBrightnessToggle = new System.Windows.Forms.Button();
		 this.button1 = new System.Windows.Forms.Button();
		 this.button2 = new System.Windows.Forms.Button();
		 this.button3 = new System.Windows.Forms.Button();
		 this.button4 = new System.Windows.Forms.Button();
		 this.cm_notifyIcon.SuspendLayout();
		 ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
		 this.SuspendLayout();
		 // 
		 // notifiyIcon
		 // 
		 this.notifiyIcon.BalloonTipText = "Change this later";
		 this.notifiyIcon.BalloonTipTitle = "Change this later";
		 this.notifiyIcon.ContextMenuStrip = this.cm_notifyIcon;
		 this.notifiyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifiyIcon.Icon")));
		 this.notifiyIcon.Text = "Change this later";
		 this.notifiyIcon.Visible = true;
		 this.notifiyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifiyIcon_MouseDoubleClick);
		 // 
		 // cm_notifyIcon
		 // 
		 this.cm_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_notifyIcon_help,
            this.cm_notifyIcon_show,
            this.cm_notifyIcon_hide,
            this.cm_notifyIcon_exit});
		 this.cm_notifyIcon.Name = "cm_notifyIcon";
		 this.cm_notifyIcon.Size = new System.Drawing.Size(104, 92);
		 // 
		 // cm_notifyIcon_help
		 // 
		 this.cm_notifyIcon_help.Name = "cm_notifyIcon_help";
		 this.cm_notifyIcon_help.Size = new System.Drawing.Size(103, 22);
		 this.cm_notifyIcon_help.Text = "Help";
		 this.cm_notifyIcon_help.Click += new System.EventHandler(this.cm_notifyIcon_help_Click);
		 // 
		 // cm_notifyIcon_show
		 // 
		 this.cm_notifyIcon_show.Name = "cm_notifyIcon_show";
		 this.cm_notifyIcon_show.Size = new System.Drawing.Size(103, 22);
		 this.cm_notifyIcon_show.Text = "Show";
		 this.cm_notifyIcon_show.Click += new System.EventHandler(this.cm_notifyIcon_show_Click);
		 // 
		 // cm_notifyIcon_hide
		 // 
		 this.cm_notifyIcon_hide.Name = "cm_notifyIcon_hide";
		 this.cm_notifyIcon_hide.Size = new System.Drawing.Size(103, 22);
		 this.cm_notifyIcon_hide.Text = "Hide";
		 this.cm_notifyIcon_hide.Click += new System.EventHandler(this.cm_notifyIcon_hide_Click);
		 // 
		 // cm_notifyIcon_exit
		 // 
		 this.cm_notifyIcon_exit.Name = "cm_notifyIcon_exit";
		 this.cm_notifyIcon_exit.Size = new System.Drawing.Size(103, 22);
		 this.cm_notifyIcon_exit.Text = "Exit";
		 this.cm_notifyIcon_exit.Click += new System.EventHandler(this.cm_notifyIcon_exit_Click);
		 // 
		 // btnHide
		 // 
		 this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnHide.FlatAppearance.BorderSize = 2;
		 this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnHide.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnHide.Location = new System.Drawing.Point(154, 185);
		 this.btnHide.Name = "btnHide";
		 this.btnHide.Size = new System.Drawing.Size(122, 65);
		 this.btnHide.TabIndex = 1;
		 this.btnHide.Text = "Hide";
		 this.btnHide.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnHide.UseVisualStyleBackColor = false;
		 this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
		 // 
		 // btnExit
		 // 
		 this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnExit.FlatAppearance.BorderSize = 2;
		 this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnExit.Location = new System.Drawing.Point(12, 185);
		 this.btnExit.Name = "btnExit";
		 this.btnExit.Size = new System.Drawing.Size(122, 65);
		 this.btnExit.TabIndex = 2;
		 this.btnExit.Text = "Exit";
		 this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnExit.UseVisualStyleBackColor = false;
		 this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
		 // 
		 // btnOptions
		 // 
		 this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnOptions.FlatAppearance.BorderSize = 2;
		 this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnOptions.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnOptions.Location = new System.Drawing.Point(12, 12);
		 this.btnOptions.Name = "btnOptions";
		 this.btnOptions.Size = new System.Drawing.Size(122, 65);
		 this.btnOptions.TabIndex = 3;
		 this.btnOptions.Text = "Options";
		 this.btnOptions.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnOptions.UseVisualStyleBackColor = false;
		 this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
		 // 
		 // btnAbout
		 // 
		 this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnAbout.FlatAppearance.BorderSize = 2;
		 this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnAbout.Location = new System.Drawing.Point(154, 12);
		 this.btnAbout.Name = "btnAbout";
		 this.btnAbout.Size = new System.Drawing.Size(122, 65);
		 this.btnAbout.TabIndex = 4;
		 this.btnAbout.Text = "About";
		 this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnAbout.UseVisualStyleBackColor = false;
		 this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
		 // 
		 // btnExpand
		 // 
		 this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnExpand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnExpand.FlatAppearance.BorderSize = 2;
		 this.btnExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnExpand.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnExpand.Location = new System.Drawing.Point(12, 94);
		 this.btnExpand.Name = "btnExpand";
		 this.btnExpand.Size = new System.Drawing.Size(122, 65);
		 this.btnExpand.TabIndex = 5;
		 this.btnExpand.Text = "Expand";
		 this.btnExpand.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnExpand.UseVisualStyleBackColor = false;
		 this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
		 // 
		 // btnCollapse
		 // 
		 this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnCollapse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnCollapse.FlatAppearance.BorderSize = 2;
		 this.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnCollapse.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnCollapse.Location = new System.Drawing.Point(154, 94);
		 this.btnCollapse.Name = "btnCollapse";
		 this.btnCollapse.Size = new System.Drawing.Size(122, 65);
		 this.btnCollapse.TabIndex = 6;
		 this.btnCollapse.Text = "Collapse";
		 this.btnCollapse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnCollapse.UseVisualStyleBackColor = false;
		 this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
		 // 
		 // btnVolDown
		 // 
		 this.btnVolDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.btnVolDown.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
		 this.btnVolDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
		 this.btnVolDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.btnVolDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnVolDown.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold);
		 this.btnVolDown.Location = new System.Drawing.Point(412, 363);
		 this.btnVolDown.Name = "btnVolDown";
		 this.btnVolDown.Size = new System.Drawing.Size(75, 23);
		 this.btnVolDown.TabIndex = 7;
		 this.btnVolDown.Text = "Vol Down";
		 this.btnVolDown.UseVisualStyleBackColor = false;
		 this.btnVolDown.Click += new System.EventHandler(this.btnVolDown_Click);
		 // 
		 // btnVolMute
		 // 
		 this.btnVolMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnVolMute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnVolMute.FlatAppearance.BorderSize = 2;
		 this.btnVolMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnVolMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnVolMute.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnVolMute.Location = new System.Drawing.Point(12, 324);
		 this.btnVolMute.Name = "btnVolMute";
		 this.btnVolMute.Size = new System.Drawing.Size(122, 63);
		 this.btnVolMute.TabIndex = 8;
		 this.btnVolMute.Text = "Volume";
		 this.btnVolMute.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnVolMute.UseVisualStyleBackColor = false;
		 this.btnVolMute.Click += new System.EventHandler(this.btnVolMute_Click);
		 // 
		 // btnVolUp
		 // 
		 this.btnVolUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.btnVolUp.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
		 this.btnVolUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
		 this.btnVolUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.btnVolUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnVolUp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold);
		 this.btnVolUp.Location = new System.Drawing.Point(412, 334);
		 this.btnVolUp.Name = "btnVolUp";
		 this.btnVolUp.Size = new System.Drawing.Size(75, 23);
		 this.btnVolUp.TabIndex = 9;
		 this.btnVolUp.Text = "Vol Up";
		 this.btnVolUp.UseVisualStyleBackColor = false;
		 this.btnVolUp.Click += new System.EventHandler(this.btnVolUp_Click);
		 // 
		 // trackBarVolume
		 // 
		 this.trackBarVolume.BackColor = System.Drawing.Color.Black;
		 this.trackBarVolume.Location = new System.Drawing.Point(154, 334);
		 this.trackBarVolume.Maximum = 100;
		 this.trackBarVolume.Name = "trackBarVolume";
		 this.trackBarVolume.Size = new System.Drawing.Size(252, 45);
		 this.trackBarVolume.TabIndex = 10;
		 this.trackBarVolume.TickFrequency = 25;
		 this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
		 this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
		 // 
		 // lblVolumeValue
		 // 
		 this.lblVolumeValue.AutoSize = true;
		 this.lblVolumeValue.BackColor = System.Drawing.Color.Black;
		 this.lblVolumeValue.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.lblVolumeValue.ForeColor = System.Drawing.Color.White;
		 this.lblVolumeValue.Location = new System.Drawing.Point(150, 301);
		 this.lblVolumeValue.Name = "lblVolumeValue";
		 this.lblVolumeValue.Size = new System.Drawing.Size(32, 21);
		 this.lblVolumeValue.TabIndex = 12;
		 this.lblVolumeValue.Text = "0%";
		 // 
		 // lblBrightness
		 // 
		 this.lblBrightness.AutoSize = true;
		 this.lblBrightness.BackColor = System.Drawing.Color.Transparent;
		 this.lblBrightness.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.lblBrightness.ForeColor = System.Drawing.Color.White;
		 this.lblBrightness.Location = new System.Drawing.Point(150, 406);
		 this.lblBrightness.Name = "lblBrightness";
		 this.lblBrightness.Size = new System.Drawing.Size(32, 21);
		 this.lblBrightness.TabIndex = 14;
		 this.lblBrightness.Text = "0%";
		 // 
		 // trackBarBrightness
		 // 
		 this.trackBarBrightness.Location = new System.Drawing.Point(154, 439);
		 this.trackBarBrightness.Maximum = 100;
		 this.trackBarBrightness.Name = "trackBarBrightness";
		 this.trackBarBrightness.Size = new System.Drawing.Size(252, 45);
		 this.trackBarBrightness.TabIndex = 13;
		 this.trackBarBrightness.TickFrequency = 25;
		 this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
		 this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
		 // 
		 // btnBrightnessToggle
		 // 
		 this.btnBrightnessToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnBrightnessToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnBrightnessToggle.FlatAppearance.BorderSize = 2;
		 this.btnBrightnessToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.btnBrightnessToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.btnBrightnessToggle.Font = new System.Drawing.Font("Segoe UI", 12F);
		 this.btnBrightnessToggle.Location = new System.Drawing.Point(12, 421);
		 this.btnBrightnessToggle.Name = "btnBrightnessToggle";
		 this.btnBrightnessToggle.Size = new System.Drawing.Size(122, 63);
		 this.btnBrightnessToggle.TabIndex = 16;
		 this.btnBrightnessToggle.Text = "Brightness";
		 this.btnBrightnessToggle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.btnBrightnessToggle.UseVisualStyleBackColor = false;
		 this.btnBrightnessToggle.Click += new System.EventHandler(this.btnBrightnessToggle_Click);
		 // 
		 // button1
		 // 
		 this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
		 this.button1.FlatAppearance.BorderSize = 2;
		 this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
		 this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
		 this.button1.Location = new System.Drawing.Point(306, 12);
		 this.button1.Name = "button1";
		 this.button1.Size = new System.Drawing.Size(136, 45);
		 this.button1.TabIndex = 17;
		 this.button1.Text = "Normal Button";
		 this.button1.UseVisualStyleBackColor = false;
		 // 
		 // button2
		 // 
		 this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.button2.FlatAppearance.BorderSize = 2;
		 this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
		 this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
		 this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
		 this.button2.Location = new System.Drawing.Point(306, 63);
		 this.button2.Name = "button2";
		 this.button2.Size = new System.Drawing.Size(136, 45);
		 this.button2.TabIndex = 18;
		 this.button2.Text = "Highlighted Button";
		 this.button2.UseVisualStyleBackColor = false;
		 // 
		 // button3
		 // 
		 this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
		 this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
		 this.button3.FlatAppearance.BorderSize = 2;
		 this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
		 this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
		 this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
		 this.button3.Location = new System.Drawing.Point(306, 114);
		 this.button3.Name = "button3";
		 this.button3.Size = new System.Drawing.Size(136, 45);
		 this.button3.TabIndex = 19;
		 this.button3.Text = "Disabled Button";
		 this.button3.UseVisualStyleBackColor = false;
		 // 
		 // button4
		 // 
		 this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.button4.FlatAppearance.BorderSize = 2;
		 this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
		 this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.button4.ForeColor = System.Drawing.Color.White;
		 this.button4.Location = new System.Drawing.Point(306, 165);
		 this.button4.Name = "button4";
		 this.button4.Size = new System.Drawing.Size(87, 65);
		 this.button4.TabIndex = 20;
		 this.button4.Text = "Tile";
		 this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		 this.button4.UseVisualStyleBackColor = false;
		 // 
		 // frmMain
		 // 
		 this.BackColor = System.Drawing.Color.Black;
		 this.ClientSize = new System.Drawing.Size(612, 567);
		 this.Controls.Add(this.lblBrightness);
		 this.Controls.Add(this.lblVolumeValue);
		 this.Controls.Add(this.button4);
		 this.Controls.Add(this.button3);
		 this.Controls.Add(this.button2);
		 this.Controls.Add(this.button1);
		 this.Controls.Add(this.trackBarBrightness);
		 this.Controls.Add(this.trackBarVolume);
		 this.Controls.Add(this.btnVolUp);
		 this.Controls.Add(this.btnVolDown);
		 this.Controls.Add(this.btnCollapse);
		 this.Controls.Add(this.btnExpand);
		 this.Controls.Add(this.btnAbout);
		 this.Controls.Add(this.btnOptions);
		 this.Controls.Add(this.btnExit);
		 this.Controls.Add(this.btnHide);
		 this.Controls.Add(this.btnVolMute);
		 this.Controls.Add(this.btnBrightnessToggle);
		 this.ForeColor = System.Drawing.SystemColors.ControlLight;
		 this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		 this.MaximizeBox = false;
		 this.MinimizeBox = false;
		 this.Name = "frmMain";
		 this.ShowInTaskbar = false;
		 this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		 this.TopMost = true;
		 this.Load += new System.EventHandler(this.frmMain_Load);
		 this.cm_notifyIcon.ResumeLayout(false);
		 ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
		 this.ResumeLayout(false);
		 this.PerformLayout();

	  }

	  #endregion

	  private System.Windows.Forms.NotifyIcon notifiyIcon;
	  private System.Windows.Forms.ContextMenuStrip cm_notifyIcon;
	  private System.Windows.Forms.ToolStripMenuItem cm_notifyIcon_help;
	  private System.Windows.Forms.ToolStripMenuItem cm_notifyIcon_show;
	  private System.Windows.Forms.ToolStripMenuItem cm_notifyIcon_hide;
	  private System.Windows.Forms.ToolStripMenuItem cm_notifyIcon_exit;
	  private System.Windows.Forms.Button btnHide;
	  private System.Windows.Forms.Button btnExit;
	  private System.Windows.Forms.Button btnOptions;
	  private System.Windows.Forms.Button btnAbout;
	  private System.Windows.Forms.Button btnExpand;
	  private System.Windows.Forms.Button btnCollapse;
	  private System.Windows.Forms.Button btnVolDown;
	  private System.Windows.Forms.Button btnVolMute;
	  private System.Windows.Forms.Button btnVolUp;
	  private System.Windows.Forms.TrackBar trackBarVolume;
	  private System.Windows.Forms.Label lblVolumeValue;
	  private System.Windows.Forms.Label lblBrightness;
	  private System.Windows.Forms.TrackBar trackBarBrightness;
	  private System.Windows.Forms.Button btnBrightnessToggle;
	  private System.Windows.Forms.Button button1;
	  private System.Windows.Forms.Button button2;
	  private System.Windows.Forms.Button button3;
	  private System.Windows.Forms.Button button4;
   }
}

