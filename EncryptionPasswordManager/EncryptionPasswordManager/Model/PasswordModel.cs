using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Security.Cryptography;
using EncryptionPasswordManager.Util;

namespace EncryptionPasswordManager.Model
{
    public class PasswordItemModel
    {
        private SaveFileData saveFileData;
        private SaveFileDataLoginCredentials _loginCredentials;
        private List<SaveFileDataPasswordItem> passwordItems;
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "passStoreEncrypt.xml");
        private static readonly byte[] Key = Convert.FromBase64String("e1qyQwJEEgXnk01HUgKozUstsxEsrKYhnxgPL5m7Jd4=");
        private static readonly byte[] IV = Convert.FromBase64String("sOAyqF23BbcPGCTWi97YSg==");

        public PasswordItemModel()
        {
            passwordItems = new List<SaveFileDataPasswordItem>();
            SaveFileExists();
            LoadFromXml();
        }

        public bool UserMadeAccount()
        {
            if(_loginCredentials != null)
            {
                return true;
            }
            return false;
        }

        public bool AttemptLogin(string username, string password)
        {
            if (Sha256.Encrypt256(password) == _loginCredentials.Password &&
                Sha256.Encrypt256(username) == _loginCredentials.Username)
            {
                return true;
            }
            return false;
        }

        public void RegisterAccount(string username, string password)
        {
            _loginCredentials = new SaveFileDataLoginCredentials()
            {
                Username = Sha256.Encrypt256(username),
                Password = Sha256.Encrypt256(password)
            };
        }

        public List<SaveFileDataPasswordItem> GetResult(string query)
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

        public void AddToPasswordModel(SaveFileDataPasswordItem item)
        {
            passwordItems.Add(item);
            SaveToXml();
        }

        public void RemoveFromPasswordModel(SaveFileDataPasswordItem item)
        {
            passwordItems.Remove(item);
            SaveToXml();
        }

        public List<SaveFileDataPasswordItem> PasswordItems => passwordItems;

        public void LoadFromXml()
        {
            try
            {
                string encryptedXml = File.ReadAllText(filePath);

                // string decryptedXml = AesEncrypt.DecryptStringFromBytes_Aes(Convert.FromBase64String(encryptedXml), Key, IV);

                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

                XmlSerializer dataSerializer = new XmlSerializer(typeof(SaveFileData), new XmlRootAttribute("SaveFileData"));
                using (StringReader reader = new StringReader(encryptedXml))
                {
                    SaveFileData dataRoot = (SaveFileData)dataSerializer.Deserialize(reader);
                    _loginCredentials = dataRoot.LoginCredentials;
                    passwordItems = dataRoot.PasswordItems.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveToXml()
        {

            SaveFileData dataToSave = new SaveFileData
            {
                LoginCredentials = _loginCredentials,
                PasswordItems = passwordItems.ToArray()
            };

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

            XmlSerializer serializer = new XmlSerializer(typeof(SaveFileData), new XmlRootAttribute("SaveFileData"));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, dataToSave, namespaces);

                string combinedXml = writer.ToString();

                // string encryptedXml = AesEncrypt.EncryptStringToBytes_Aes(combinedXml, Key, IV);

                File.WriteAllText(filePath, combinedXml);
            }
        }

        private void SaveFileExists()
        {
            if (!File.Exists(this.filePath))
            {
                File.Create(this.filePath).Close();
            }
        }
    }
}
