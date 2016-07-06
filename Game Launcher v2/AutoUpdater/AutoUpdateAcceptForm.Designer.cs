namespace AutoUpdater {
	partial class AutoUpdateAcceptForm {
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
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.labelUpdateAvailable = new System.Windows.Forms.Label();
			this.labelNewVersion = new System.Windows.Forms.Label();
			this.buttonYes = new System.Windows.Forms.Button();
			this.buttonNo = new System.Windows.Forms.Button();
			this.buttonDetails = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Image = global::AutoUpdater.Properties.Resources.update;
			this.pictureBox.Location = new System.Drawing.Point(12, 8);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(80, 80);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// labelUpdateAvailable
			// 
			this.labelUpdateAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUpdateAvailable.Location = new System.Drawing.Point(98, 4);
			this.labelUpdateAvailable.Name = "labelUpdateAvailable";
			this.labelUpdateAvailable.Size = new System.Drawing.Size(394, 90);
			this.labelUpdateAvailable.TabIndex = 1;
			this.labelUpdateAvailable.Text = "Update is Available!\r\nWould you like to update?";
			this.labelUpdateAvailable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelNewVersion
			// 
			this.labelNewVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNewVersion.Location = new System.Drawing.Point(218, 116);
			this.labelNewVersion.Name = "labelNewVersion";
			this.labelNewVersion.Size = new System.Drawing.Size(154, 19);
			this.labelNewVersion.TabIndex = 2;
			// 
			// buttonYes
			// 
			this.buttonYes.Location = new System.Drawing.Point(106, 162);
			this.buttonYes.Name = "buttonYes";
			this.buttonYes.Size = new System.Drawing.Size(99, 37);
			this.buttonYes.TabIndex = 3;
			this.buttonYes.Text = "Yes";
			this.buttonYes.UseVisualStyleBackColor = true;
			this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
			// 
			// buttonNo
			// 
			this.buttonNo.Location = new System.Drawing.Point(224, 162);
			this.buttonNo.Name = "buttonNo";
			this.buttonNo.Size = new System.Drawing.Size(99, 37);
			this.buttonNo.TabIndex = 4;
			this.buttonNo.Text = "No";
			this.buttonNo.UseVisualStyleBackColor = true;
			this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
			// 
			// buttonDetails
			// 
			this.buttonDetails.Location = new System.Drawing.Point(343, 162);
			this.buttonDetails.Name = "buttonDetails";
			this.buttonDetails.Size = new System.Drawing.Size(99, 37);
			this.buttonDetails.TabIndex = 5;
			this.buttonDetails.Text = "Details";
			this.buttonDetails.UseVisualStyleBackColor = true;
			this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
			// 
			// AutoUpdateAcceptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 301);
			this.Controls.Add(this.buttonDetails);
			this.Controls.Add(this.buttonNo);
			this.Controls.Add(this.buttonYes);
			this.Controls.Add(this.labelNewVersion);
			this.Controls.Add(this.labelUpdateAvailable);
			this.Controls.Add(this.pictureBox);
			this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutoUpdateAcceptForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelUpdateAvailable;
		private System.Windows.Forms.Label labelNewVersion;
		private System.Windows.Forms.Button buttonYes;
		private System.Windows.Forms.Button buttonNo;
		private System.Windows.Forms.Button buttonDetails;
	}
}