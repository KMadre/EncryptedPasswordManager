using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

/// <summary>
/// Talked with AJ and I was allowed to use the code doc referenced here as long as I understand it so I commented it myself.
/// 
/// I used AES as it allows for full encryption and decryption given the correct key and IV. 
/// I protect my xml file which holds a users data with this, via a constant key in the Password Model file.
/// </summary>

namespace EncryptionPasswordManager.Util
{
    public class AesEncrypt
    {
        ////////////////////////////////////
        /// <summary>
        /// The code below is taken directly from the microsoft documentation, slightly modified for my use-case
        /// https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-8.0
        /// </summary>
        ////////////////////////////////////
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // direct from the referenced code, no real reason to do anything else
            // It checks for valid text format, key format and IV foramt (just that its not null or too small to be valid)
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // makes a temporary AES object with using, object will only be available in the brackets and then immediately deferenced.
            // Also from the referenced code
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // This is also from the referenced code, it is a premade functionality for cryptographic transformations
                // Acts as the decryptor for the aes key and IV passed in
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Also from referenced code, it is inside of using blocks as well. Helps with security
                // MemoryStream is a stream to memory, doesn't leave traces I imagine since RAM is constantly overwritten. Helps with security
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    // Also from ref. code. It's another cryptographic transformation utility, uses the decryptor we defined earlier
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        // just a stream reader to get decrypted info from RAM
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        ////////////////////////////////////
        /// <summary>
        /// The code below is taken directly from the microsoft documentation, slightly modified for my use-case
        /// https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-8.0
        /// </summary>
        ////////////////////////////////////
        public static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // direct from the referenced code, no real reason to do anything else
            // It checks for valid text format, key format and IV foramt (just that its not null or too small to be valid)
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // makes a temporary AES object with using, object will only be available in the brackets and then immediately deferenced.
            // Also from the referenced code
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // This is also from the referenced code, it is a premade functionality for cryptographic transformations
                // acts as the encryptor for the aes key and IV passed in
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Also from referenced code, it is inside of using blocks as well. Helps with security
                // MemoryStream is a stream to memory, doesn't leave traces I imagine since RAM is constantly overwritten. Helps with security
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Also from ref. code. It's another cryptographic transformation utility, uses encryptor we defined earleir
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // just a stream writer to assemble the string into its bytes
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }

                    encrypted = msEncrypt.ToArray();
                }
            }

            // Return the encrypted bytes from the memory stream as a String
            return Convert.ToBase64String(encrypted);
        }
    }
}
