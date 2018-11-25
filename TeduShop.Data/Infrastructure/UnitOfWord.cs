using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWord :IUnitOfWord
    {
        private readonly IDbFactory dbFactory;
        private TeduShopDbContext dbContext;

        public UnitOfWord (IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init(); }
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }

       
    }
}
