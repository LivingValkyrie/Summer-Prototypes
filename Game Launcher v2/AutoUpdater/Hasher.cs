﻿using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AutoUpdater {
	/// <summary>
	/// Author: Matt Gipson
	/// Contact: Deadwynn@gmail.com
	/// Domain: www.livingvalkyrie.net
	/// 
	/// Description: Hasher 
	/// </summary>
	class Hasher {

		internal static string HashFile(string filePath, HashType algo) {
			switch (algo) {
				case HashType.MD5:
					return MakeHashString(MD5.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
				case HashType.SHA1:
					return MakeHashString(SHA1.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
				case HashType.SHA512:
					return MakeHashString(SHA512.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
				default:
					return "";
			}
		}

		static string MakeHashString(byte[] hash) {
			StringBuilder s = new StringBuilder(hash.Length * 2);

			foreach (byte b in hash) {
				s.Append(b.ToString("X2").ToLower());
			}

			return s.ToString();
		}

	}

	enum HashType {
		MD5,
		SHA1,
		SHA512
	}

}