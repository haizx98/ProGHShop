using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBHShop.Data.Infrastructure
{
   public interface IUnitOfWork
    {
        void Commit();
    }
}
