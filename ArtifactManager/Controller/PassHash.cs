using System;
using System.Security.Cryptography;
using System.Text;

namespace ArtifactManager.Controller
{
    public class PassHash
    {
        public readonly String Password;
        public readonly String Salt;
        private readonly int _size;

        public PassHash(String password)
        {
            _size = 10;
            Salt = CreateSalt();
            Password = HashGen(password);
        }
        
        public PassHash(String password, String salt)
        {
            _size = 10;
            Salt = salt;
            Password = HashGen(password);
        }

        private String CreateSalt()
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[_size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private String HashGen(String input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + Salt);
            SHA256Managed hashedString = new SHA256Managed();
            byte[] hash = hashedString.ComputeHash(bytes);

            return ByteArrayToString(hash);
        }

        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            
            return hex.ToString();
        }
    }
}