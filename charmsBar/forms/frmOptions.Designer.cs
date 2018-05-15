namespace charmsBar.forms
{
   partial class frmOptions
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
		 this.btnDefaults = new System.Windows.Forms.Button();
		 this.btnSave = new System.Windows.Forms.Button();
		 this.btnClose = new System.Windows.Forms.Button();
		 this.frmOptions_colorDialog = new System.Windows.Forms.ColorDialog();
		 this.chkDisplayInTaskbar = new System.Windows.Forms.CheckBox();
		 this.lblDisplayInTaskbar = new System.Windows.Forms.Label();
		 this.lblChangeColor = new System.Windows.Forms.Label();
		 this.lblChangeDisplayTimeout = new System.Windows.Forms.Label();
		 this.btnChangeBackColor = new System.Windows.Forms.Button();
		 this.btnChangeForeColor = new System.Windows.Forms.Button();
		 this.lblStartup = new System.Windows.Forms.Label();
		 this.chkStartup = new System.Windows.Forms.CheckBox();
		 this.txtChangeDisplayTimeout = new System.Windows.Forms.NumericUpDown();
		 this.lblDisplayTimeoutUnits = new System.Windows.Forms.Label();
		 this.txtChangeColor = new System.Windows.Forms.Label();
		 ((System.ComponentModel.ISupportInitialize)(this.txtChangeDisplayTimeout)).BeginInit();
		 this.SuspendLayout();
		 // 
		 // btnDefaults
		 // 
		 this.btnDefaults.Location = new System.Drawing.Point(12, 330);
		 this.btnDefaults.Name = "btnDefaults";
		 this.btnDefaults.Size = new System.Drawing.Size(75, 23);
		 this.btnDefaults.TabIndex = 0;
		 this.btnDefaults.Text = "Defaults";
		 this.btnDefaults.UseVisualStyleBackColor = true;
		 this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
		 // 
		 // btnSave
		 // 
		 this.btnSave.Location = new System.Drawing.Point(297, 330);
		 this.btnSave.Name = "btnSave";
		 this.btnSave.Size = new System.Drawing.Size(75, 23);
		 this.btnSave.TabIndex = 1;
		 this.btnSave.Text = "Save";
		 this.btnSave.UseVisualStyleBackColor = true;
		 this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
		 // 
		 // btnClose
		 // 
		 this.btnClose.Location = new System.Drawing.Point(378, 330);
		 this.btnClose.Name = "btnClose";
		 this.btnClose.Size = new System.Drawing.Size(75, 23);
		 this.btnClose.TabIndex = 2;
		 this.btnClose.Text = "Close";
		 this.btnClose.UseVisualStyleBackColor = true;
		 this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
		 // 
		 // frmOptions_colorDialog
		 // 
		 this.frmOptions_colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
		 this.frmOptions_colorDialog.FullOpen = true;
		 // 
		 // chkDisplayInTaskbar
		 // 
		 this.chkDisplayInTaskbar.AutoSize = true;
		 this.chkDisplayInTaskbar.Location = new System.Drawing.Point(191, 17);
		 this.chkDisplayInTaskbar.Name = "chkDisplayInTaskbar";
		 this.chkDisplayInTaskbar.Size = new System.Drawing.Size(15, 14);
		 this.chkDisplayInTaskbar.TabIndex = 6;
		 this.chkDisplayInTaskbar.UseVisualStyleBackColor = true;
		 // 
		 // lblDisplayInTaskbar
		 // 
		 this.lblDisplayInTaskbar.AutoSize = true;
		 this.lblDisplayInTaskbar.Location = new System.Drawing.Point(12, 18);
		 this.lblDisplayInTaskbar.Name = "lblDisplayInTaskbar";
		 this.lblDisplayInTaskbar.Size = new System.Drawing.Size(90, 13);
		 this.lblDisplayInTaskbar.TabIndex = 7;
		 this.lblDisplayInTaskbar.Text = "Display in taskbar";
		 // 
		 // lblChangeColor
		 // 
		 this.lblChangeColor.AutoSize = true;
		 this.lblChangeColor.Location = new System.Drawing.Point(12, 44);
		 this.lblChangeColor.Name = "lblChangeColor";
		 this.lblChangeColor.Size = new System.Drawing.Size(152, 13);
		 this.lblChangeColor.TabIndex = 8;
		 this.lblChangeColor.Text = "Change the applications colors";
		 // 
		 // lblChangeDisplayTimeout
		 // 
		 this.lblChangeDisplayTimeout.AutoSize = true;
		 this.lblChangeDisplayTimeout.Location = new System.Drawing.Point(12, 70);
		 this.lblChangeDisplayTimeout.Name = "lblChangeDisplayTimeout";
		 this.lblChangeDisplayTimeout.Size = new System.Drawing.Size(151, 13);
		 this.lblChangeDisplayTimeout.TabIndex = 10;
		 this.lblChangeDisplayTimeout.Text = "Change the bars display timout";
		 // 
		 // btnChangeBackColor
		 // 
		 this.btnChangeBackColor.Location = new System.Drawing.Point(378, 35);
		 this.btnChangeBackColor.Name = "btnChangeBackColor";
		 this.btnChangeBackColor.Size = new System.Drawing.Size(75, 23);
		 this.btnChangeBackColor.TabIndex = 12;
		 this.btnChangeBackColor.Text = "Background";
		 this.btnChangeBackColor.UseVisualStyleBackColor = true;
		 this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
		 // 
		 // btnChangeForeColor
		 // 
		 this.btnChangeForeColor.Location = new System.Drawing.Point(297, 35);
		 this.btnChangeForeColor.Name = "btnChangeForeColor";
		 this.btnChangeForeColor.Size = new System.Drawing.Size(75, 23);
		 this.btnChangeForeColor.TabIndex = 13;
		 this.btnChangeForeColor.Text = "Text";
		 this.btnChangeForeColor.UseVisualStyleBackColor = true;
		 this.btnChangeForeColor.Click += new System.EventHandler(this.btnChangeForeColor_Click);
		 // 
		 // lblStartup
		 // 
		 this.lblStartup.AutoSize = true;
		 this.lblStartup.Location = new System.Drawing.Point(12, 94);
		 this.lblStartup.Name = "lblStartup";
		 this.lblStartup.Size = new System.Drawing.Size(172, 13);
		 this.lblStartup.TabIndex = 15;
		 this.lblStartup.Text = "Run application at windows startup";
		 // 
		 // chkStartup
		 // 
		 this.chkStartup.AutoSize = true;
		 this.chkStartup.Location = new System.Drawing.Point(191, 93);
		 this.chkStartup.Name = "chkStartup";
		 this.chkStartup.Size = new System.Drawing.Size(15, 14);
		 this.chkStartup.TabIndex = 14;
		 this.chkStartup.UseVisualStyleBackColor = true;
		 // 
		 // txtChangeDisplayTimeout
		 // 
		 this.txtChangeDisplayTimeout.Location = new System.Drawing.Point(191, 67);
		 this.txtChangeDisplayTimeout.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
		 this.txtChangeDisplayTimeout.Name = "txtChangeDisplayTimeout";
		 this.txtChangeDisplayTimeout.Size = new System.Drawing.Size(100, 20);
		 this.txtChangeDisplayTimeout.TabIndex = 16;
		 // 
		 // lblDisplayTimeoutUnits
		 // 
		 this.lblDisplayTimeoutUnits.AutoSize = true;
		 this.lblDisplayTimeoutUnits.Location = new System.Drawing.Point(297, 74);
		 this.lblDisplayTimeoutUnits.Name = "lblDisplayTimeoutUnits";
		 this.lblDisplayTimeoutUnits.Size = new System.Drawing.Size(47, 13);
		 this.lblDisplayTimeoutUnits.TabIndex = 17;
		 this.lblDisplayTimeoutUnits.Text = "seconds";
		 // 
		 // txtChangeColor
		 // 
		 this.txtChangeColor.AutoSize = true;
		 this.txtChangeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		 this.txtChangeColor.Location = new System.Drawing.Point(191, 42);
		 this.txtChangeColor.Name = "txtChangeColor";
		 this.txtChangeColor.Size = new System.Drawing.Size(49, 15);
		 this.txtChangeColor.TabIndex = 18;
		 this.txtChangeColor.Text = "Example";
		 // 
		 // frmOptions
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.ClientSize = new System.Drawing.Size(468, 365);
		 this.Controls.Add(this.txtChangeColor);
		 this.Controls.Add(this.lblDisplayTimeoutUnits);
		 this.Controls.Add(this.txtChangeDisplayTimeout);
		 this.Controls.Add(this.lblStartup);
		 this.Controls.Add(this.chkStartup);
		 this.Controls.Add(this.btnChangeForeColor);
		 this.Controls.Add(this.btnChangeBackColor);
		 this.Controls.Add(this.lblChangeDisplayTimeout);
		 this.Controls.Add(this.lblChangeColor);
		 this.Controls.Add(this.lblDisplayInTaskbar);
		 this.Controls.Add(this.chkDisplayInTaskbar);
		 this.Controls.Add(this.btnClose);
		 this.Controls.Add(this.btnSave);
		 this.Controls.Add(this.btnDefaults);
		 this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		 this.MaximizeBox = false;
		 this.MinimizeBox = false;
		 this.Name = "frmOptions";
		 this.ShowInTaskbar = false;
		 this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		 this.Text = "Charms Bar Options";
		 this.Load += new System.EventHandler(this.frmOptions_Load);
		 ((System.ComponentModel.ISupportInitialize)(this.txtChangeDisplayTimeout)).EndInit();
		 this.ResumeLayout(false);
		 this.PerformLayout();

	  }

	  #endregion

	  private System.Windows.Forms.Button btnDefaults;
	  private System.Windows.Forms.Button btnSave;
	  private System.Windows.Forms.Button btnClose;
	  private System.Windows.Forms.ColorDialog frmOptions_colorDialog;
	  private System.Windows.Forms.CheckBox chkDisplayInTaskbar;
	  private System.Windows.Forms.Label lblDisplayInTaskbar;
	  private System.Windows.Forms.Label lblChangeColor;
	  private System.Windows.Forms.Label lblChangeDisplayTimeout;
	  private System.Windows.Forms.Button btnChangeBackColor;
	  private System.Windows.Forms.Button btnChangeForeColor;
	  private System.Windows.Forms.Label lblStartup;
	  private System.Windows.Forms.CheckBox chkStartup;
	  private System.Windows.Forms.Label lblDisplayTimeoutUnits;
	  private System.Windows.Forms.NumericUpDown txtChangeDisplayTimeout;
	  private System.Windows.Forms.Label txtChangeColor;
   }
}