using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBHShop.Data.Infrastructure
{
   public class DbFactory : Disposable, IDbFactory
    {
        private ProBHShopDbContext dbContext;

        public ProBHShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ProBHShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
