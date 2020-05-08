using Microsoft.EntityFrameworkCore;
using Article.Data.Entities;

namespace Article.Data.Concrete
{
    public class ArticleDbContext : DbContext
    {
        public ArticleDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<ArticleModel> articles { get; set; }
    }
}
