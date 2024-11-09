using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPasswordManager.Util
{
    public class Sha256
    {
        static public String Encrypt256(String toEncrypt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));

                return Convert.ToBase64String(bytes);
            }
        }
    }
}
