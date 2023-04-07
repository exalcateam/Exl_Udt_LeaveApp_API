using leaverequest.Models;
using Microsoft.EntityFrameworkCore;


namespace leaverequest.Datas
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
            
        }
        public DbSet<login> Login { get; set; }
        
    }
}
