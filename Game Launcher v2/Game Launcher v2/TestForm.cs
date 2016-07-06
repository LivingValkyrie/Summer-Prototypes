using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdater;

namespace Game_Launcher_v2 {
	public partial class TestForm : Form, IAutoUpdatable {
		public TestForm() {
			InitializeComponent();

			this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
		}

		void button1_Click(object sender, EventArgs e) {}

		#region IAutoUpdatable

		public string ApplicationName => "Test app";
		public string ApplicationID => "TestApp";
		public Assembly ApplicationAssembly => Assembly.GetExecutingAssembly();
		public Icon ApplicationIcon => this.Icon;
		public Uri UpdateXmmlLocation => new Uri("");
		public Form Context => this;

		#endregion
	}
}