using System.Collections.Generic;
using System.Linq;

namespace GWTEncryption
{
    public class PositionEncryptor : IPositionEncryptor
    {
        public string Encrypt(char message, int position)
        {
            Dictionary<int, char> alphabet = new Dictionary<int, char>();
            int looper = 1;

            for (char c = 'a'; c<= 'z'; c++)
            {
                alphabet.Add(looper, c);
                looper++;
            }

            int oldPosition = alphabet.FirstOrDefault(r => r.Value == message).Key;
            int newPosition = (oldPosition + position);

            while (newPosition > 26)
            {
                newPosition = newPosition - 26;
            }

            return alphabet.FirstOrDefault(r => r.Key == newPosition).Value.ToString();
        }
    }
}