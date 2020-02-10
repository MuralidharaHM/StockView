using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.DataAccess
{
  
    public class UnitOfWork : IDisposable
    {
        //should be single TODO
         DbContext _dbContext;

        private UnitOfWork()
        {

        }
        public void Dispose()
        {
           
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public DbContext GetDbContext()
        {

           return  new DbContext("");
        }
    }
    
}
