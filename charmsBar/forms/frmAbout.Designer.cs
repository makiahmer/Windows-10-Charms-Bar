namespace charmsBar.forms
{
   partial class frmAbout
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
		 this.label1 = new System.Windows.Forms.Label();
		 this.label2 = new System.Windows.Forms.Label();
		 this.SuspendLayout();
		 // 
		 // label1
		 // 
		 this.label1.AutoSize = true;
		 this.label1.Location = new System.Drawing.Point(12, 9);
		 this.label1.Name = "label1";
		 this.label1.Size = new System.Drawing.Size(86, 13);
		 this.label1.TabIndex = 0;
		 this.label1.Text = "Place holder text";
		 // 
		 // label2
		 // 
		 this.label2.AutoSize = true;
		 this.label2.Location = new System.Drawing.Point(12, 200);
		 this.label2.Name = "label2";
		 this.label2.Size = new System.Drawing.Size(242, 39);
		 this.label2.TabIndex = 1;
		 this.label2.Text = "Makiah Merritt 12/20/2015\r\nContributers: (not that individuals know but I used \r\n" +
    "code from the following locations)";
		 // 
		 // frmAbout
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.ClientSize = new System.Drawing.Size(284, 261);
		 this.Controls.Add(this.label2);
		 this.Controls.Add(this.label1);
		 this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		 this.MaximizeBox = false;
		 this.MinimizeBox = false;
		 this.Name = "frmAbout";
		 this.ShowInTaskbar = false;
		 this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		 this.Text = "frmAbout";
		 this.Load += new System.EventHandler(this.frmAbout_Load);
		 this.ResumeLayout(false);
		 this.PerformLayout();

	  }

	  #endregion

	  private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Label label2;
   }
}