using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopExampleDBContext dbContext;

        public ShopExampleDBContext Init()
        {
            return dbContext ?? (dbContext = new ShopExampleDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
