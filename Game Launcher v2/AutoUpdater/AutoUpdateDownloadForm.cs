using System;
using System.IO;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;

namespace AutoUpdater {
	internal partial class AutoUpdateDownloadForm : Form {
		#region Fields

		WebClient webClient;
		BackgroundWorker bgWorker;
		string tempFile;
		string md5;

		internal string TempFilePath {
			get { return this.tempFile; }
		}

		#endregion

		internal AutoUpdateDownloadForm(Uri location, string md5, Icon programIcon) {
			InitializeComponent();

			if (programIcon != null) {
				this.Icon = programIcon;
			}

			tempFile = Path.GetTempFileName();
			this.md5 = md5;

			//webclient init
			webClient = new WebClient();
			webClient.DownloadProgressChanged += WebClientOnDownloadProgressChanged;
			webClient.DownloadFileCompleted += WebClientOnDownloadFileCompleted;

			//bgworker init
			bgWorker = new BackgroundWorker();
			bgWorker.DoWork += BgWorkerOnDoWork;
			bgWorker.RunWorkerCompleted += BgWorkerOnRunWorkerCompleted;

			try {
				webClient.DownloadFileAsync(location, this.tempFile);
			} catch {
				this.DialogResult = DialogResult.No;
				this.Close();
			}
		}

		void WebClientOnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
			this.progressBar.Value = e.ProgressPercentage;
			this.labelProgress.Text = $"Download {FormatBytes(e.BytesReceived, 1)} of {FormatBytes(e.TotalBytesToReceive, 1)}";
		}

		void WebClientOnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
			if (e.Error != null) {
				this.DialogResult = DialogResult.No;
				this.Close();
			} else if (e.Cancelled) {
				this.DialogResult = DialogResult.Abort;
				this.Close();
			} else {
				labelProgress.Text = "Verifying download...";
				progressBar.Style = ProgressBarStyle.Marquee;

				bgWorker.RunWorkerAsync(new string[] {this.tempFile, this.md5});
			}
		}

		void BgWorkerOnDoWork(object sender, DoWorkEventArgs e) {
			string file = ((string[]) e.Argument)[0];
			string updateMd5 = ((string[]) e.Argument)[1];

			if (Hasher.HashFile(file, HashType.MD5) != updateMd5) {
				e.Result = DialogResult.No;
			} else {
				e.Result = DialogResult.OK;
			}
		}

		void BgWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			this.DialogResult = (DialogResult) e.Result;
			this.Close();
		}

		/// <summary>
		/// Handles the FormClosed event of the AutoUpdateDownloadForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
		void AutoUpdateDownloadForm_FormClosed(object sender, FormClosedEventArgs e) {
			if (webClient.IsBusy) {
				webClient.CancelAsync();
				this.DialogResult = DialogResult.Abort;
			}

			if (bgWorker.IsBusy) {
				bgWorker.CancelAsync();
				this.DialogResult = DialogResult.Abort;
			}
		}

		/// <summary>
		/// Formats bytes into a string as kb, mb or gb.
		/// </summary>
		/// <param name="bytes">The bytes.</param>
		/// <param name="decimalPlaces">The decimal places.</param>
		/// <param name="showbyteType">if set to <c>true</c> [showbyte type].</param>
		/// <returns></returns>
		string FormatBytes(long bytes, int decimalPlaces, bool showbyteType = true) {
			double newBytes = bytes;
			string formatString = "{0";
			string byteType = "B";

			if (newBytes > 1024 && newBytes < 1048576) {
				newBytes /= 1024;
				byteType = "KB";
			} else if (newBytes >= 1048576 && newBytes < 1073741824) {
				newBytes /= 1048576;
				byteType = "MB";
			} else {
				newBytes /= 1073741824;
				byteType = "GB";
			}

			if (decimalPlaces > 0) {
				formatString += ":0.";
			}

			for (int i = 0; i < decimalPlaces; i++) {
				formatString += "0";
			}

			formatString += "}";

			if (showbyteType) {
				formatString += byteType;
			}

			return string.Format(formatString, newBytes);
		}
	}
}