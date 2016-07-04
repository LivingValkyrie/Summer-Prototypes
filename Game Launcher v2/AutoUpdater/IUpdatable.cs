using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace AutoUpdater {
	/// <summary>
	/// Author: Matt Gipson
	/// Contact: Deadwynn@gmail.com
	/// Domain: www.livingvalkyrie.net
	/// 
	/// Description: AutoUpdateXML 
	/// </summary>
	public interface IUpdatable {
		/// <summary>
		/// Gets the name of the application.
		/// </summary>
		string ApplicationName { get; }
		/// <summary>
		/// An identifier string to use to identify your app in the update.xml.
		/// </summary>
		string ApplicationID { get; }
		/// <summary>
		/// the current assembly
		/// </summary>
		Assembly ApplicationAssembly { get; }
		/// <summary>
		/// Gets the application icon to be displayed in the top left.
		/// </summary>
		Icon ApplicationIcon { get; }
		/// <summary>
		/// the update.xml location on the server.
		/// </summary>
		Uri UpdateXmmlLocation { get; }
		/// <summary>
		/// Gets the context of the program.
		/// </summary>
		Form Context { get; }
	}
}