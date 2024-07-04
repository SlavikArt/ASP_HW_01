using System.Security.Cryptography;
using System.Text;

namespace Homework_1_2.Services.Hash
{
    public class ShaHashService : IHashService
    {
        public string Digest(string input)
        {
            return Convert.ToHexString(SHA1.HashData(Encoding.UTF8.GetBytes(input)));
        }
    }
}
