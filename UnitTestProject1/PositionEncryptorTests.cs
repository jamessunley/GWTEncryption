using GWTEncryption;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GWTTests
{
    [TestClass]
    public class PositionEncryptorTests
    {
        [TestMethod]
        public void Given_I_Have_String_a_and_position_1_I_get_back_b()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 1
            int position = 1;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "b"
            Assert.AreEqual("b", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_2_I_get_back_c()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 2
            int position = 2;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "c"
            Assert.AreEqual("c", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_3_I_get_back_d()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 2
            int position = 3;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "d"
            Assert.AreEqual("d", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_10_I_get_back_k()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 10
            int position = 10;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "k"
            Assert.AreEqual("k", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_25_I_get_back_z()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 25
            int position = 25;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "z"
            Assert.AreEqual("z", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_26_I_get_back_a()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 26
            int position = 26;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "a"
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_27_I_get_back_b()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 27
            int position = 27;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "b"
            Assert.AreEqual("b", result);
        }

        [TestMethod]
        public void Given_I_Have_String_z_and_position_1_I_get_back_a()
        {
            //given i have the string "z"
            char message = 'z';
            //And i have a position of 1
            int position = 1;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "a"
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void Given_I_Have_String_z_and_position_2_I_get_back_b()
        {
            //given i have the string "z"
            char message = 'z';
            //And i have a position of 2
            int position = 2;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "b"
            Assert.AreEqual("b", result);
        }

        [TestMethod]
        public void Given_I_Have_String_z_and_position_3_I_get_back_c()
        {
            //given i have the string "z"
            char message = 'z';
            //And i have a position of 3
            int position = 3;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "c"
            Assert.AreEqual("c", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_52_I_get_back_a()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 52
            int position = 52;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "a"
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_53_I_get_back_b()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 53
            int position = 53;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "b"
            Assert.AreEqual("b", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_54_I_get_back_c()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 54
            int position = 54;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "c"
            Assert.AreEqual("c", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_51_I_get_back_z()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 51
            int position = 51;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "z"
            Assert.AreEqual("z", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_78_I_get_back_a()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 78
            int position = 78;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "a"
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void Given_I_Have_String_a_and_position_79_I_get_back_a()
        {
            //given i have the string "a"
            char message = 'a';
            //And i have a position of 79
            int position = 79;
            //when i pass in the string and the position to the positionEncryptor
            IPositionEncryptor positionEncryptor = new PositionEncryptor();
            string result = positionEncryptor.Encrypt(message, position);
            //then i get back "b"
            Assert.AreEqual("b", result);
        }

    }
}
