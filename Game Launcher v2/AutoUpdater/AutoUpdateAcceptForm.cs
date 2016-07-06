using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdater {
	internal partial class AutoUpdateAcceptForm : Form {
		IAutoUpdatable applicationInfo;
		AutoUpdateXML updateInfo;
		AutoUpdateInfoForm updateInfoForm;

		internal AutoUpdateAcceptForm(IAutoUpdatable applicationInfo, AutoUpdateXML updateInfo) {
			InitializeComponent();

			this.applicationInfo = applicationInfo;
			this.updateInfo = updateInfo;

			this.Text = this.applicationInfo.ApplicationName + " - Update Available";

			if (this.applicationInfo.ApplicationIcon != null) {
				this.Icon = this.applicationInfo.ApplicationIcon;
			}

			this.labelNewVersion.Text = $"New Version: {this.updateInfo.Version}";
		}

		void buttonYes_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Yes;
			this.Close();
		}

		void buttonNo_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		void buttonDetails_Click(object sender, EventArgs e) {
			if (this.updateInfoForm == null) {
				this.updateInfoForm = new AutoUpdateInfoForm(this.applicationInfo, this.updateInfo);
			}

			this.updateInfoForm.ShowDialog(this);
		}
	}
}