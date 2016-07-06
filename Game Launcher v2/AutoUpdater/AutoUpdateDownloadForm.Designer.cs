namespace AutoUpdater {
	partial class AutoUpdateDownloadForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.labelDownloading = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.labelProgress = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDownloading
			// 
			this.labelDownloading.AutoSize = true;
			this.labelDownloading.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.labelDownloading.Location = new System.Drawing.Point(35, 35);
			this.labelDownloading.Name = "labelDownloading";
			this.labelDownloading.Size = new System.Drawing.Size(386, 72);
			this.labelDownloading.TabIndex = 0;
			this.labelDownloading.Text = "Downloading...";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(47, 111);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(374, 23);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 1;
			// 
			// labelProgress
			// 
			this.labelProgress.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.labelProgress.Location = new System.Drawing.Point(62, 137);
			this.labelProgress.Name = "labelProgress";
			this.labelProgress.Size = new System.Drawing.Size(344, 13);
			this.labelProgress.TabIndex = 2;
			this.labelProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// AutoUpdateDownloadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 206);
			this.Controls.Add(this.labelProgress);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.labelDownloading);
			this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutoUpdateDownloadForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Downloading Update";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoUpdateDownloadForm_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDownloading;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label labelProgress;
	}
}