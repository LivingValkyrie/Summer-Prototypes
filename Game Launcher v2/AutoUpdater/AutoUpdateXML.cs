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
		#region Fields

		internal string LaunchArgs { get; }
		internal string Description { get; }
		internal string Md5 { get; }
		internal string FileName { get; }
		internal Uri Uri { get; }
		internal Version Version { get; }

		#endregion

		internal AutoUpdateXML(Version version, Uri uri, string fileName, string md5, string description, string launchArgs) {
			this.Version = version;
			this.Uri = uri;
			this.FileName = fileName;
			this.Md5 = md5;
			this.Description = description;
			this.LaunchArgs = launchArgs;
		}

		internal bool IsNewerThan(Version version) {
			return this.Version > version;
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
			try {
				Version tempVersion = null;
				string tempUrl = "", tempFileName = "", tempMd5 = "", tempDescription = "", tempLaunchArgs = "";

				XmlDocument doc = new XmlDocument();
				doc.Load(location.AbsoluteUri);

				XmlNode node = doc.DocumentElement.SelectSingleNode("//update[@appId='" + appID + "']");

				if (node == null) {
					return null;
				}

				tempVersion = Version.Parse(node["version"].InnerText);
				tempUrl = node["url"].InnerText;
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