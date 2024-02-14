using Org.BouncyCastle.Security;
using System.Security.Cryptography;
using System.Text;

namespace Task3
{
    public class GenerateHMAC
    {
        public static string GetHMAC(string text, string key)
        {
            using (var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                var hash = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hash).Replace("-", "");
            }
            }
        }
    }

