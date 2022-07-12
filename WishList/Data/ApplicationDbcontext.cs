
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContentOptions options):
        {

        }
        public DbSet<Models.Item>Items { get; set; }
    }
}
