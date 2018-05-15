namespace charmsBar_csWFA
{
   partial class Form1
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
		 this.btnExit = new System.Windows.Forms.Button();
		 this.lblTitle = new System.Windows.Forms.Label();
		 this.btnResize = new System.Windows.Forms.Button();
		 this.lblMousePosition = new System.Windows.Forms.Label();
		 this.SuspendLayout();
		 // 
		 // btnExit
		 // 
		 this.btnExit.Location = new System.Drawing.Point(13, 226);
		 this.btnExit.Name = "btnExit";
		 this.btnExit.Size = new System.Drawing.Size(75, 23);
		 this.btnExit.TabIndex = 0;
		 this.btnExit.Text = "Close";
		 this.btnExit.UseVisualStyleBackColor = true;
		 this.btnExit.Click += new System.EventHandler(this.button1_Click);
		 // 
		 // lblTitle
		 // 
		 this.lblTitle.AutoSize = true;
		 this.lblTitle.Location = new System.Drawing.Point(12, 9);
		 this.lblTitle.Name = "lblTitle";
		 this.lblTitle.Size = new System.Drawing.Size(62, 13);
		 this.lblTitle.TabIndex = 1;
		 this.lblTitle.Text = "Hello World";
		 // 
		 // btnResize
		 // 
		 this.btnResize.Location = new System.Drawing.Point(13, 119);
		 this.btnResize.Name = "btnResize";
		 this.btnResize.Size = new System.Drawing.Size(75, 23);
		 this.btnResize.TabIndex = 2;
		 this.btnResize.Text = "Resize";
		 this.btnResize.UseVisualStyleBackColor = true;
		 this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
		 // 
		 // lblMousePosition
		 // 
		 this.lblMousePosition.AutoSize = true;
		 this.lblMousePosition.Location = new System.Drawing.Point(13, 70);
		 this.lblMousePosition.Name = "lblMousePosition";
		 this.lblMousePosition.Size = new System.Drawing.Size(35, 13);
		 this.lblMousePosition.TabIndex = 3;
		 this.lblMousePosition.Text = "label1";
		 // 
		 // Form1
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.BackColor = System.Drawing.Color.DarkGreen;
		 this.ClientSize = new System.Drawing.Size(100, 261);
		 this.ControlBox = false;
		 this.Controls.Add(this.lblMousePosition);
		 this.Controls.Add(this.btnResize);
		 this.Controls.Add(this.lblTitle);
		 this.Controls.Add(this.btnExit);
		 this.ForeColor = System.Drawing.SystemColors.ControlText;
		 this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		 this.MaximizeBox = false;
		 this.MinimizeBox = false;
		 this.Name = "Form1";
		 this.ShowIcon = false;
		 this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		 this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		 this.Text = "Form1";
		 this.TopMost = true;
		 this.Load += new System.EventHandler(this.Form1_Load);
		 this.ResumeLayout(false);
		 this.PerformLayout();

	  }

	  #endregion

	  private System.Windows.Forms.Button btnExit;
	  private System.Windows.Forms.Label lblTitle;
	  private System.Windows.Forms.Button btnResize;
	  private System.Windows.Forms.Label lblMousePosition;
   }
}

