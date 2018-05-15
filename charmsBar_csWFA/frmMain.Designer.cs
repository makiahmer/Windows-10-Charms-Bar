namespace charmsBar_csWFA
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
		 this.btnExit = new System.Windows.Forms.Button();
		 this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
		 this.btnHide = new System.Windows.Forms.Button();
		 this.trayIcon_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
		 this.trayIcon_menu_show = new System.Windows.Forms.ToolStripMenuItem();
		 this.trayIcon_menu_hide = new System.Windows.Forms.ToolStripMenuItem();
		 this.trayIcon_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
		 this.trayIcon_menu.SuspendLayout();
		 this.SuspendLayout();
		 // 
		 // btnExit
		 // 
		 this.btnExit.Location = new System.Drawing.Point(12, 226);
		 this.btnExit.Name = "btnExit";
		 this.btnExit.Size = new System.Drawing.Size(75, 23);
		 this.btnExit.TabIndex = 0;
		 this.btnExit.Text = "Exit";
		 this.btnExit.UseVisualStyleBackColor = true;
		 this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
		 // 
		 // trayIcon
		 // 
		 this.trayIcon.BalloonTipText = "Change me later";
		 this.trayIcon.BalloonTipTitle = "Charms Bar Extension";
		 this.trayIcon.ContextMenuStrip = this.trayIcon_menu;
		 this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
		 this.trayIcon.Text = "charmsBar_csWFA";
		 this.trayIcon.Visible = true;
		 // 
		 // btnHide
		 // 
		 this.btnHide.Location = new System.Drawing.Point(12, 197);
		 this.btnHide.Name = "btnHide";
		 this.btnHide.Size = new System.Drawing.Size(75, 23);
		 this.btnHide.TabIndex = 1;
		 this.btnHide.Text = "Hide";
		 this.btnHide.UseVisualStyleBackColor = true;
		 this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
		 // 
		 // trayIcon_menu
		 // 
		 this.trayIcon_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayIcon_menu_show,
            this.trayIcon_menu_hide,
            this.trayIcon_menu_exit});
		 this.trayIcon_menu.Name = "trayIcon_menu";
		 this.trayIcon_menu.Size = new System.Drawing.Size(104, 70);
		 // 
		 // trayIcon_menu_show
		 // 
		 this.trayIcon_menu_show.Name = "trayIcon_menu_show";
		 this.trayIcon_menu_show.Size = new System.Drawing.Size(103, 22);
		 this.trayIcon_menu_show.Text = "Show";
		 this.trayIcon_menu_show.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
		 // 
		 // trayIcon_menu_hide
		 // 
		 this.trayIcon_menu_hide.Name = "trayIcon_menu_hide";
		 this.trayIcon_menu_hide.Size = new System.Drawing.Size(103, 22);
		 this.trayIcon_menu_hide.Text = "Hide";
		 this.trayIcon_menu_hide.Click += new System.EventHandler(this.trayIcon_menu_hide_Click);
		 // 
		 // trayIcon_menu_exit
		 // 
		 this.trayIcon_menu_exit.Name = "trayIcon_menu_exit";
		 this.trayIcon_menu_exit.Size = new System.Drawing.Size(103, 22);
		 this.trayIcon_menu_exit.Text = "Exit";
		 this.trayIcon_menu_exit.Click += new System.EventHandler(this.trayIcon_menu_exit_Click);
		 // 
		 // frmMain
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.BackColor = System.Drawing.Color.Aquamarine;
		 this.ClientSize = new System.Drawing.Size(284, 261);
		 this.Controls.Add(this.btnHide);
		 this.Controls.Add(this.btnExit);
		 this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		 this.Name = "frmMain";
		 this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		 this.Text = "Main";
		 this.Load += new System.EventHandler(this.frmMain_Load);
		 this.trayIcon_menu.ResumeLayout(false);
		 this.ResumeLayout(false);

	  }

	  #endregion

	  private System.Windows.Forms.Button btnExit;
	  private System.Windows.Forms.NotifyIcon trayIcon;
	  private System.Windows.Forms.Button btnHide;
	  private System.Windows.Forms.ContextMenuStrip trayIcon_menu;
	  private System.Windows.Forms.ToolStripMenuItem trayIcon_menu_show;
	  private System.Windows.Forms.ToolStripMenuItem trayIcon_menu_hide;
	  private System.Windows.Forms.ToolStripMenuItem trayIcon_menu_exit;
   }
}