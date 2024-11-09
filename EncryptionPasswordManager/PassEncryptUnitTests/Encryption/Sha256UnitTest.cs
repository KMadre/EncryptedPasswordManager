using EncryptionPasswordManager.Util;

namespace PassEncryptUnitTests
{
    public class Sha256Tetsts
    {
        private const string _Hash8For1 = "a4ayc/80";
        private const string _Hash16For1 = "a4ayc/80/OGda4BO";
        private const string _Hash32For1 = "a4ayc/80/OGda4BO/1o/V0etpOqiLx1J";


        [TestCase(_Hash8For1, 8)]
        [TestCase(_Hash16For1, 16)]
        [TestCase(_Hash32For1, 32)]
        public void ParameterizedConsistencyTest(string expected, int substringLength)
        {
            string actualHashSubstring = Sha256.Encrypt256("1").Substring(0, substringLength);

            Assert.That(actualHashSubstring, Is.EqualTo(expected));
        }

    }
}