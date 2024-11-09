using EncryptionPasswordManager.Util;

namespace PassEncryptUnitTests
{
    public class AESTetsts
    {
        private const string _Expected8For1 = "Nr8WDu3I";
        private const string _Expected16For1 = "Nr8WDu3I7+UR/1nK";
        private const string _Expected32For1 = "Nr8WDu3I7+UR/1nKP7qyFw==";

        private static readonly byte[] Key = Convert.FromBase64String("e1qyQwJEEgXnk01HUgKozUstsxEsrKYhnxgPL5m7Jd4=");
        private static readonly byte[] IV = Convert.FromBase64String("sOAyqF23BbcPGCTWi97YSg==");


        [TestCase(_Expected8For1, 8)]
        [TestCase(_Expected16For1, 16)]
        [TestCase(_Expected32For1, 24)] // UI restricts the chars to the max possible, I will artificially do it here
        public void ParameterizedConsistencyTest(string expected, int substringLength)
        {
            string actualHashSubstring = AesEncrypt.EncryptStringToBytes_Aes("1", Key, IV).Substring(0, substringLength);

            Assert.That(actualHashSubstring, Is.EqualTo(expected));
        }

    }
}