namespace SampleHangfireProject.Interfaces
{
    public interface IEmailService
    {
        string SendEmail(string jobType,string starttime);
    }
}
