using Hangfire;
using Microsoft.AspNetCore.Mvc;
using SampleHangfireProject.Interfaces;

namespace SampleHangfireProject.Controllers
{
    public class HangfireController : ControllerBase
    {
        private IEmailService _emailservice; 
        private IBackgroundJobClient _backgroundjobclient;
        private IRecurringJobManager _recurringJobManager;

        public HangfireController(IEmailService emailservice, IBackgroundJobClient backgroundjobclient, IRecurringJobManager recurringJobManager)
        {
            _emailservice = emailservice;
            _backgroundjobclient = backgroundjobclient;
            _recurringJobManager = recurringJobManager;
        }


        [HttpGet]
        [Route("FireAndForgetJob")]
        public ActionResult CreateFireAndForgetJob()
        {
            var jobId = BackgroundJob.Enqueue(()=> _emailservice.SendEmail("Fire-and-Forget Job", DateTime.Now.ToLongTimeString()));
          BackgroundJob.Enqueue(jobId,()=>Console.WriteLine($"Email sent Succesffully with Id {jobId}"));
            return Ok($"Background Job  Running with Id {jobId}");
        }

    }
}
