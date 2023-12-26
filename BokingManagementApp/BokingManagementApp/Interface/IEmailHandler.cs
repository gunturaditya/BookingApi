namespace BokingManagementApp.Interface
{
    public interface IEmailHandler
    {
        void SendEmail(string toEmail, string subject, string htmlMessage);
    }
}
