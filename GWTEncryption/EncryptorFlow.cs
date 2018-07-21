using GWTEncryption;

namespace GWTTests
{
    public class EncryptorFlow : IEncryptorFlow
    {
        private readonly IPositionEncryptor _encrypt;

        public EncryptorFlow(IPositionEncryptor encrypt)
        {
            _encrypt = encrypt;
        }

        public string Encrypt(string message)
        {
            string encrypt = "";
            for (int i = 0; i < message.Length; i++)
            {
                encrypt += _encrypt.Encrypt(message[i], 1);
            }
            return encrypt;

        }
    }
}