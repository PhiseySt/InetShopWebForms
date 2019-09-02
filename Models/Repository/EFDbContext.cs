using System.Web;
using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + HttpContext.Current.Server.MapPath("~/App_Data/GameStore.mdf")
                    + ";Integrated Security=True")
        {  }

        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}