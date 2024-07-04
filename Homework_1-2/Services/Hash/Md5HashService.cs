using System.Security.Cryptography;
using System.Text;

namespace Homework_1_2.Services.Hash
{
    public class Md5HashService : IHashService
    {
        public string Digest(String input)
        {
            return Convert.ToHexString(MD5.HashData(Encoding.UTF8.GetBytes(input)));
        }
    }
}
