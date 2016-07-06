using System;
using System.Windows.Forms;

namespace AutoUpdater {
	internal partial class AutoUpdateInfoForm : Form {
		internal AutoUpdateInfoForm(IAutoUpdatable applicationInfo, AutoUpdateXML updateInfo) {
			InitializeComponent();

			if (applicationInfo.ApplicationIcon != null) {
				this.Icon = applicationInfo.ApplicationIcon;
			}

			this.Text = applicationInfo.ApplicationName + " - Update Info";
			this.labelVersions.Text = $"Current Version: {applicationInfo.ApplicationAssembly.GetName().Version} \n" +
			                          $"Update Version: {updateInfo.Version}";
			this.textDescription.Text = updateInfo.Description;
		}

		private void buttonBack_Click( object sender, EventArgs e ) {
			this.Close();
		}

		private void textDescription_KeyDown( object sender, KeyEventArgs e ) {
			if (!e.Control && e.KeyCode == Keys.C) {
				e.SuppressKeyPress = true;
			}
		}
	}
}
