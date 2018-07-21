using System;
using GWTEncryption;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GWTTests
{
    [TestClass]
    public class GWTEncryptionFlowTests
    {
        [TestMethod]
        public void Given_input_is_a_positionEncryptor_called_once()
        {
            //given i have the start character "a"
            string message = "a";
            //And I have a positionEncryptor Object
            Mock<IPositionEncryptor> mock = new Mock<IPositionEncryptor>();
            //When I call encryptor.enctrypt
            IEncryptorFlow encryptorFlow = new EncryptorFlow(mock.Object);
            encryptorFlow.Encrypt(message);
            //Then I will verify that positionEncryptor Object is called once
            mock.Verify(m => m.Encrypt( It.IsAny<char>(),It.IsAny<int>()), Times.Once);

        }

        [TestMethod]
        public void Given_input_is_ab_positionEncryptor_called_twice()
        {
            //given i have the start character "ab"
            string message = "ab";
            //And I have a positionEncryptor Object
            Mock<IPositionEncryptor> mock = new Mock<IPositionEncryptor>();
            //When I call encryptor.enctrypt
            IEncryptorFlow encryptorFlow = new EncryptorFlow(mock.Object);
            encryptorFlow.Encrypt(message);
            //Then I will verify that positionEncryptor Object is called twice
            mock.Verify(m => m.Encrypt(It.IsAny<char>(), It.IsAny<int>()), Times.Exactly(2));

        }

        [TestMethod]
        public void Given_input_is_abc_positionEncryptor_called_three_times()
        {
            //given i have the start character "ab"
            string message = "abc";
            //And I have a positionEncryptor Object
            Mock<IPositionEncryptor> mock = new Mock<IPositionEncryptor>();
            //When I call encryptor.enctrypt
            IEncryptorFlow encryptorFlow = new EncryptorFlow(mock.Object);
            encryptorFlow.Encrypt(message);
            //Then I will verify that positionEncryptor Object is called three times
            mock.Verify(m => m.Encrypt(It.IsAny<char>(), It.IsAny<int>()), Times.Exactly(3));

        }

        [TestMethod]
        public void Given_input_is__positionEncryptor_called_six_times()
        {
            //given i have the start character "rstuvw"
            string message = "rstuvw";
            //And I have a positionEncryptor Object
            Mock<IPositionEncryptor> mock = new Mock<IPositionEncryptor>();
            //When I call encryptor.enctrypt
            IEncryptorFlow encryptorFlow = new EncryptorFlow(mock.Object);
            encryptorFlow.Encrypt(message);
            //Then I will verify that positionEncryptor Object is called six times
            mock.Verify(m => m.Encrypt(It.IsAny<char>(), It.IsAny<int>()), Times.Exactly(6));

        }
    }
}
