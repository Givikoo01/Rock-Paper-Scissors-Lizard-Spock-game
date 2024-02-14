using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class KeyGeneration
    {
        //Generating Secure key
        public static string GenerateKey()
        {
            SecureRandom secureRandom = new SecureRandom();
            byte[] key = secureRandom.GenerateSeed(32);
            return BitConverter.ToString(key).Replace("-", "");
        }
    }
}
