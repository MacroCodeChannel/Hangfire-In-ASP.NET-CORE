using Microsoft.EntityFrameworkCore;

namespace SampleHangfireProject.Database
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
