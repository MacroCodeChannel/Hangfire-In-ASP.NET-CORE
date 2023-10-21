namespace SampleHangfireProject.Interfaces
{
    public class EmailService : IEmailService   
    {
        public string SendEmail(string jobType,string startTime)
        {
            Console.Write(jobType + "-" + startTime+ "- Email Successfully Sent -"+DateTime.Now.ToLongTimeString());
             var id = Guid.NewGuid();
            return id.ToString();
        }
    }
}
