using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace projectclass.Models
{
    public class mydb : DbContext
    {
        public mydb(DbContextOptions<mydb>options):base(options) { }
        public DbSet<register> registers { get; set; }
    }
}
