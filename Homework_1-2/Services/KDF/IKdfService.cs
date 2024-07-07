namespace Homework_1_2.Services.KDF
{
    public interface IKdfService
    {
        string DerivedKey(string password, string salt);
    }
}
