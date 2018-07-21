using System.Collections.Generic;
using System.Linq;

namespace GWTTests
{
    public class CaseEncryptor : ICaseEncryptor
    {
        public string Encrypt(char message)
        {
            return message.ToString().ToUpper();
        }
    }
}