namespace BugListCollector
{
	partial class BugForm
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
			this.tcBugs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.gbBugInfo = new System.Windows.Forms.GroupBox();
			this.lblBugText = new System.Windows.Forms.Label();
			this.txtBugID = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbFixed = new System.Windows.Forms.CheckBox();
			this.txtBugText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBugName = new System.Windows.Forms.Label();
			this.txtBugName = new System.Windows.Forms.TextBox();
			this.cbSeparateViews = new System.Windows.Forms.CheckBox();
			this.cbOnlyActiveBugs = new System.Windows.Forms.CheckBox();
			this.btnNewBug = new System.Windows.Forms.Button();
			this.tcBugs.SuspendLayout();
			this.gbBugInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcBugs
			// 
			this.tcBugs.Controls.Add(this.tabPage1);
			this.tcBugs.Location = new System.Drawing.Point(12, 48);
			this.tcBugs.Name = "tcBugs";
			this.tcBugs.SelectedIndex = 0;
			this.tcBugs.Size = new System.Drawing.Size(480, 864);
			this.tcBugs.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(472, 831);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "List of bugs";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// gbBugInfo
			// 
			this.gbBugInfo.Controls.Add(this.lblBugText);
			this.gbBugInfo.Controls.Add(this.txtBugID);
			this.gbBugInfo.Controls.Add(this.btnSave);
			this.gbBugInfo.Controls.Add(this.cbFixed);
			this.gbBugInfo.Controls.Add(this.txtBugText);
			this.gbBugInfo.Controls.Add(this.label2);
			this.gbBugInfo.Controls.Add(this.lblBugName);
			this.gbBugInfo.Controls.Add(this.txtBugName);
			this.gbBugInfo.Enabled = false;
			this.gbBugInfo.Location = new System.Drawing.Point(498, 12);
			this.gbBugInfo.Name = "gbBugInfo";
			this.gbBugInfo.Size = new System.Drawing.Size(480, 900);
			this.gbBugInfo.TabIndex = 3;
			this.gbBugInfo.TabStop = false;
			this.gbBugInfo.Text = "Bug # info";
			// 
			// lblBugText
			// 
			this.lblBugText.AutoSize = true;
			this.lblBugText.Location = new System.Drawing.Point(6, 171);
			this.lblBugText.Name = "lblBugText";
			this.lblBugText.Size = new System.Drawing.Size(64, 20);
			this.lblBugText.TabIndex = 7;
			this.lblBugText.Text = "Bugtext";
			// 
			// txtBugID
			// 
			this.txtBugID.Location = new System.Drawing.Point(6, 125);
			this.txtBugID.Name = "txtBugID";
			this.txtBugID.Size = new System.Drawing.Size(468, 26);
			this.txtBugID.TabIndex = 6;
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.Location = new System.Drawing.Point(399, 864);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 30);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// cbFixed
			// 
			this.cbFixed.AutoSize = true;
			this.cbFixed.Location = new System.Drawing.Point(6, 868);
			this.cbFixed.Name = "cbFixed";
			this.cbFixed.Size = new System.Drawing.Size(73, 24);
			this.cbFixed.TabIndex = 4;
			this.cbFixed.Text = "Fixed";
			this.cbFixed.UseVisualStyleBackColor = true;
			// 
			// txtBugText
			// 
			this.txtBugText.Location = new System.Drawing.Point(6, 194);
			this.txtBugText.Multiline = true;
			this.txtBugText.Name = "txtBugText";
			this.txtBugText.Size = new System.Drawing.Size(468, 664);
			this.txtBugText.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "BugID";
			// 
			// lblBugName
			// 
			this.lblBugName.AutoSize = true;
			this.lblBugName.Location = new System.Drawing.Point(6, 38);
			this.lblBugName.Name = "lblBugName";
			this.lblBugName.Size = new System.Drawing.Size(78, 20);
			this.lblBugName.TabIndex = 1;
			this.lblBugName.Text = "Bugname";
			// 
			// txtBugName
			// 
			this.txtBugName.Location = new System.Drawing.Point(6, 61);
			this.txtBugName.Name = "txtBugName";
			this.txtBugName.Size = new System.Drawing.Size(468, 26);
			this.txtBugName.TabIndex = 0;
			// 
			// cbSeparateViews
			// 
			this.cbSeparateViews.AutoSize = true;
			this.cbSeparateViews.Location = new System.Drawing.Point(12, 918);
			this.cbSeparateViews.Name = "cbSeparateViews";
			this.cbSeparateViews.Size = new System.Drawing.Size(143, 24);
			this.cbSeparateViews.TabIndex = 4;
			this.cbSeparateViews.Text = "Separate views";
			this.cbSeparateViews.UseVisualStyleBackColor = true;
			// 
			// cbOnlyActiveBugs
			// 
			this.cbOnlyActiveBugs.AutoSize = true;
			this.cbOnlyActiveBugs.Location = new System.Drawing.Point(161, 918);
			this.cbOnlyActiveBugs.Name = "cbOnlyActiveBugs";
			this.cbOnlyActiveBugs.Size = new System.Drawing.Size(150, 24);
			this.cbOnlyActiveBugs.TabIndex = 5;
			this.cbOnlyActiveBugs.Text = "Only active bugs";
			this.cbOnlyActiveBugs.UseVisualStyleBackColor = true;
			// 
			// btnNewBug
			// 
			this.btnNewBug.AutoSize = true;
			this.btnNewBug.Location = new System.Drawing.Point(12, 12);
			this.btnNewBug.Name = "btnNewBug";
			this.btnNewBug.Size = new System.Drawing.Size(81, 30);
			this.btnNewBug.TabIndex = 6;
			this.btnNewBug.Text = "New bug";
			this.btnNewBug.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 957);
			this.Controls.Add(this.btnNewBug);
			this.Controls.Add(this.cbOnlyActiveBugs);
			this.Controls.Add(this.cbSeparateViews);
			this.Controls.Add(this.gbBugInfo);
			this.Controls.Add(this.tcBugs);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tcBugs.ResumeLayout(false);
			this.gbBugInfo.ResumeLayout(false);
			this.gbBugInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tcBugs;
		private System.Windows.Forms.GroupBox gbBugInfo;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox cbFixed;
		private System.Windows.Forms.TextBox txtBugText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblBugName;
		private System.Windows.Forms.TextBox txtBugName;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.CheckBox cbSeparateViews;
		private System.Windows.Forms.CheckBox cbOnlyActiveBugs;
		private System.Windows.Forms.Button btnNewBug;
		private System.Windows.Forms.Label lblBugText;
		private System.Windows.Forms.TextBox txtBugID;
	}
}

