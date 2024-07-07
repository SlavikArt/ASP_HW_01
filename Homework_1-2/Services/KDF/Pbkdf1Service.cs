using Homework_1_2.Services.Hash;

namespace Homework_1_2.Services.KDF
{
    // Згідно з пунктом 5.1 стандарту RFC 2898
    public class Pbkdf1Service(IHashService hashService) : IKdfService
    {
        private readonly IHashService _hashService = hashService;

        public string DerivedKey(string password, string salt)
        {
            string hash = _hashService.Digest(password + salt);
            string derivedKey = _hashService.Digest(hash);
            return derivedKey;
        }
    }
}
