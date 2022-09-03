
using DevExtremeAspNetCoreApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace DevExtremeAspNetCoreApp3.Data
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {
        }
        public DbSet<TableTest> TableTests { get; set; }
    }
}
