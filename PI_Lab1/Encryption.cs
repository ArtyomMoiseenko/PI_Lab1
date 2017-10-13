using System.Text;
using System.Security.Cryptography;

namespace PI_Lab1
{
    public class Encryption
    {
        private readonly string _key;

        public Encryption(string key)
        {
            _key = key;
        }

        public string ChangeKey()
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(_key);
                byte[] hash = md5.ComputeHash(inputBytes);
                var stringBuilder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        public override string ToString()
        {
            return _key.ToString();
        }
    }
}
