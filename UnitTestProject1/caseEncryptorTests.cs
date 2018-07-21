using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GWTTests
{
    [TestClass]
    public class CaseEncryptorTests
    {
        [TestMethod]
        public void Given_message_is_a_and_returns_A()
        {
            //given i have the string "a"
            char message = 'a';
            //when i pass in the string to the caseEncryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            string result = caseEncryptor.Encrypt(message);
            //then i get back "A" upper case
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void Given_message_is_f_and_returns_F()
        {
            //given i have the string "f"
            char message = 'f';
            //when i pass in the string to the caseEncryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            string result = caseEncryptor.Encrypt(message);
            //then i get back "F" upper case
            Assert.AreEqual("F", result);
        }

        [TestMethod]
        public void Given_message_is_z_and_returns_Z()
        {
            //given i have the string "z"
            char message = 'z';
            //when i pass in the string to the caseEncryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            string result = caseEncryptor.Encrypt(message);
            //then i get back "Z" upper case
            Assert.AreEqual("Z", result);
        }
    }
}
