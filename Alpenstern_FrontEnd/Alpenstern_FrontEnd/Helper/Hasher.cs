using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Alpenstern_FrontEnd.Helper
{
	public static class Hasher
	{
		public static string hash(string str)
		{
			var bytes = Encoding.UTF8.GetBytes(str);
			SHA256 sha = new SHA256Managed();
			byte[] hash = sha.ComputeHash(bytes);
			return hexToString(hash);
		}

		public static string getSalt()
		{
			byte[] salt = new byte[32];
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			rng.GetNonZeroBytes(salt);
			return hexToString(salt);
		}

		private static string hexToString(byte[] bytes)
		{
			string str = "";
			foreach (byte b in bytes)
				str += b.ToString("X2");
			return str;
		}
	}
}