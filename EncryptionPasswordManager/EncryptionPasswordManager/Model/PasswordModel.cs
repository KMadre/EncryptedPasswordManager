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

                string decryptedXml = AesEncrypt.DecryptStringFromBytes_Aes(Convert.FromBase64String(encryptedXml), Key, IV);

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

                string encryptedXml = AesEncrypt.EncryptStringToBytes_Aes(serializedXml, Key, IV);
                
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
    }
}
