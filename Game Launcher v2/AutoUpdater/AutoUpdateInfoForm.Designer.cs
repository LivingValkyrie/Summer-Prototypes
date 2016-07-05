namespace AutoUpdater {
	partial class AutoUpdateInfoForm {
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
			this.labelVersions = new System.Windows.Forms.Label();
			this.textDescription = new System.Windows.Forms.RichTextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.buttonBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Image = global::AutoUpdater.Properties.Resources.update;
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(80, 80);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// labelVersions
			// 
			this.labelVersions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersions.Location = new System.Drawing.Point(104, 25);
			this.labelVersions.Name = "labelVersions";
			this.labelVersions.Size = new System.Drawing.Size(168, 54);
			this.labelVersions.TabIndex = 1;
			this.labelVersions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textDescription
			// 
			this.textDescription.BackColor = System.Drawing.SystemColors.Control;
			this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDescription.Cursor = System.Windows.Forms.Cursors.Default;
			this.textDescription.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDescription.Location = new System.Drawing.Point(12, 133);
			this.textDescription.Name = "textDescription";
			this.textDescription.ReadOnly = true;
			this.textDescription.Size = new System.Drawing.Size(260, 96);
			this.textDescription.TabIndex = 2;
			this.textDescription.TabStop = false;
			this.textDescription.Text = "";
			this.textDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDescription_KeyDown);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(9, 100);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(118, 30);
			this.labelDescription.TabIndex = 3;
			this.labelDescription.Text = "Description";
			// 
			// buttonBack
			// 
			this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.Location = new System.Drawing.Point(112, 235);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(74, 38);
			this.buttonBack.TabIndex = 4;
			this.buttonBack.TabStop = false;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// AutoUpdateInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 282);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.labelVersions);
			this.Controls.Add(this.pictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutoUpdateInfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelVersions;
		private System.Windows.Forms.RichTextBox textDescription;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Button buttonBack;
	}
}