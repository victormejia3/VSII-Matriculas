using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace BibliotecaITQ
{
    internal class Program
    {
		public static void Main()
		{

			const string key = "497V38G4PMWNUP7TW9ES2ZRRFODJ6ZTM";
			const string plainText = "{\"external_id\":\"P000000206\",\"name\":\"Fabio\",\"lastname\":\"Cadena\",\"email\":\"favio.cadena@itq.edu.ec\"}";

			string nonce = "";
			string encryptedform = "";


			var encoding = new UTF8Encoding();
			var Key = encoding.GetBytes(key);

			using (var rj = new RijndaelManaged())
			{
				try
				{
					rj.Padding = PaddingMode.Zeros;
					rj.Mode = CipherMode.CBC;
					rj.KeySize = 128;
					rj.BlockSize = 128;
					rj.Key = Key;
					rj.GenerateIV();

					var ms = new MemoryStream();

					using (var cs = new CryptoStream(ms, rj.CreateEncryptor(Key, rj.IV), CryptoStreamMode.Write))
					{
						var toEncrypt = Encoding.UTF8.GetBytes(plainText);
						cs.Write(toEncrypt, 0, toEncrypt.Length);
						cs.FlushFinalBlock();

						nonce = Convert.ToBase64String(rj.IV);
						encryptedform = Convert.ToBase64String(ms.ToArray());
					}
				}
				finally
				{
					rj.Clear();
				}
			}

			Console.WriteLine("{\"encryptedform\": \"" + encryptedform + "\", \"nonce\": \"" + nonce + "\"}");
		}
	}
}
