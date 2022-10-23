using Microsoft.EntityFrameworkCore;

namespace GoodProduct.Context
{
    public class _dbContext : DbContext
    {
        public _dbContext(DbContextOptions<_dbContext> options) : base(options)
        {
        }
    }
}
