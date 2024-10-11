using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Security.Cryptography;

namespace EncryptionPasswordManager.Model
{
    public class PasswordItemModel
    {
        private List<PasswordItem> passwordItems;
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "passStoreEncrypt.xml");
        private static readonly byte[] Key = Convert.FromBase64String("e1qyQwJEEgXnk01HUgKozUstsxEsrKYhnxgPL5m7Jd4=");
        private static readonly byte[] IV = Convert.FromBase64String("sOAyqF23BbcPGCTWi97YSg==");

        public PasswordItemModel()
        {
            passwordItems = new List<PasswordItem>();
            SaveFileExists();
            LoadFromXml();
        }

        public List<PasswordItem> GetResult(string query)
        {
            if(query == string.Empty)
            {
                return passwordItems;
            }
            else
            {
                return passwordItems.Where(item => item.Link.ToLower() != null && 
                item.Link.ToLower().Contains(query.ToLower())).ToList();
            }
        }

        public void AddToPasswordModel(PasswordItem item)
        {
            passwordItems.Add(item);
            SaveToXml();
        }

        public void RemoveFromPasswordModel(PasswordItem item)
        {
            passwordItems.Remove(item);
            SaveToXml();
        }

        public List<PasswordItem> PasswordItems => passwordItems;

        public void LoadFromXml()
        {
            try
            {                
                string encryptedXml = File.ReadAllText(filePath);

                string decryptedXml = DecryptStringFromBytes_Aes(Convert.FromBase64String(encryptedXml), Key, IV);

                XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordItem>), new XmlRootAttribute("PasswordItems"));
                using (StringReader reader = new StringReader(decryptedXml))
                {
                    passwordItems = (List<PasswordItem>)serializer.Deserialize(reader);
                }
            }catch (Exception ex)
            {
                return;
            }
        }

        public void SaveToXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PasswordItem>), new XmlRootAttribute("PasswordItems"));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, passwordItems);
                string serializedXml = writer.ToString();

                string encryptedXml = EncryptStringToBytes_Aes(serializedXml, Key, IV);
                
                File.WriteAllText(filePath, encryptedXml);
            }
        }

        private void SaveFileExists()
        {
            if (!File.Exists(this.filePath))
            {
                File.Create(this.filePath).Close();
            }
        }

        ////////////////////////////////////
        /// <summary>
        /// The code below is taken directly from the microsoft documentation, slightly modified for my use-case
        /// https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-8.0
        /// </summary>
        ////////////////////////////////////
        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
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

        static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }

                    encrypted = msEncrypt.ToArray();
                }
            }

            // Return the encrypted bytes from the memory stream.
            return Convert.ToBase64String(encrypted);
        }
    }
}
