namespace Homework_1_2.Services.FileName
{
    public interface IFileNameService
    {
        public string GenerateRandomFileName(int length, bool includeUpperCase = false,
            bool includeNumbers = false);
    }
}
