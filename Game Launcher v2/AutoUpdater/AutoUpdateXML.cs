using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutoUpdater {

	/// <summary>
	/// Author: Matt Gipson
	/// Contact: Deadwynn@gmail.com
	/// Domain: www.livingvalkyrie.net
	/// 
	/// Description: AutoUpdateXML 
	/// </summary>
	class AutoUpdateXML {
		Version version;
		Uri uri;
		string fileName;
		string md5;
		string description;
		string launchArgs;

		public string LaunchArgs {
			get { return launchArgs; }
		}

		public string Description {
			get { return description; }
		}

		public string Md5 {
			get { return md5; }
		}

		public string FileName {
			get { return fileName; }
		}

		public Uri Uri {
			get { return uri; }
		}

		public Version Version {
			get { return version; }
		}

		internal AutoUpdateXML(Version version, Uri uri, string fileName, string md5, string description, string launchArgs) {
			this.version = version;
			this.uri = uri;
			this.fileName = fileName;
			this.md5 = md5;
			this.description = description;
			this.launchArgs = launchArgs;
		}

		internal bool IsNewerThan(Version version) {
			return this.version > version;
		}

		internal static bool ExistOnServer(Uri location) {
			try {
				HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(location.AbsolutePath);
				HttpWebResponse response = (HttpWebResponse) request.GetResponse();
				response.Close();

				return response.StatusCode == HttpStatusCode.OK;
			} catch {
				return false;
			}
		}

		internal static AutoUpdateXML Parse(Uri location, string appID) {
			Version tempVersion = null;
			string tempUrl = "", tempFileName = "", tempMd5 = "", tempDescription = "", tempLaunchArgs = "";

			try {
				XmlDocument doc = new XmlDocument();
				doc.Load(location.AbsoluteUri);

				XmlNode node = doc.DocumentElement.SelectSingleNode("//update[@appID='" + appID + "']");

				if (node == null) {
					return null;
				}

				tempVersion = Version.Parse(node["latestVersion"].InnerText);
				tempUrl = node["latestVersionUrl"].InnerText;
				tempFileName = node["fileName"].InnerText;
				tempMd5 = node["md5"].InnerText;
				tempDescription = node["description"].InnerText;
				tempLaunchArgs = node["launchArgs"].InnerText;

				return new AutoUpdateXML(tempVersion, new Uri(tempUrl), tempFileName, tempMd5, tempDescription, tempLaunchArgs);
			} catch {
				return null;
			}
		}

	}
}