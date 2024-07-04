namespace Homework_1_2.Services.OTP
{
    public class Otp4Service : IOtpService
    {
        public string GeneratePassword()
        {
            return new Random().Next(1000, 9999).ToString();
        }
    }
}
