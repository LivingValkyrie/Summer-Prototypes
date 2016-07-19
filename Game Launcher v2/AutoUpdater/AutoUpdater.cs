using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutoUpdater {

	/// <summary>
	/// Author: Matt Gipson
	/// Contact: Deadwynn@gmail.com
	/// Domain: www.livingvalkyrie.com
	/// 
	/// Description: AutoUpdater 
	/// </summary>
	public class AutoUpdater {
		#region Fields

		IAutoUpdatable applicationInfo;
		BackgroundWorker bgWorker;

		#endregion

		public AutoUpdater(IAutoUpdatable applicationInfo) {
			this.applicationInfo = applicationInfo;

			bgWorker = new BackgroundWorker();
			bgWorker.DoWork += BgWorkerOnDoWork;
			bgWorker.RunWorkerCompleted += BgWorkerOnRunWorkerCompleted;
		}

		public void DoUpdate() {
			if (!this.bgWorker.IsBusy) {
				this.bgWorker.RunWorkerAsync(this.applicationInfo);
			}
		}

		void BgWorkerOnDoWork(object sender, DoWorkEventArgs e) {
			IAutoUpdatable application = (IAutoUpdatable) e.Argument;

			if (!AutoUpdateXML.ExistOnServer(application.UpdateXmmlLocation)) {
				e.Cancel = true;
			} else {
				e.Result = AutoUpdateXML.Parse(application.UpdateXmmlLocation, application.ApplicationID);
			}
		}

		void BgWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			if (!e.Cancelled) {
				AutoUpdateXML update = (AutoUpdateXML) e.Result;

				if (update != null && update.IsNewerThan(this.applicationInfo.ApplicationAssembly.GetName().Version)) {
					if (new AutoUpdateAcceptForm(this.applicationInfo, update).ShowDialog(this.applicationInfo.Context) == DialogResult.Yes) {
						this.DownloadUpdate(update);
					}
				}
			}
		}

		void DownloadUpdate(AutoUpdateXML update) {
			AutoUpdateDownloadForm form = new AutoUpdateDownloadForm(update.Uri, update.Md5, this.applicationInfo.ApplicationIcon);
			DialogResult result = form.ShowDialog(this.applicationInfo.Context);

			if (result == DialogResult.OK) {
				string currentPath = this.applicationInfo.ApplicationAssembly.Location;
				string newPath = Path.GetDirectoryName(currentPath) + "\\" + update.FileName;

				UpdateApplication(form.TempFilePath, currentPath, newPath, update.LaunchArgs);

				Application.Exit();
			} else if (result == DialogResult.Abort) {
				MessageBox.Show("The update download was cancelled. \n this program has not been modified",
				                "Update download cancelled",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Information);
			} else {
				MessageBox.Show( "There was a problem downloading update. \n Please try again later.",
								"Update download error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information );
			}
		}

		void UpdateApplication(string tempFilePath, string currentPath, string newPath, string launchArgs) {
			
		}
	}

}