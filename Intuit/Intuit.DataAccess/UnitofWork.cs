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
        
        static DbContext _dbContext;

        static readonly object b = new object();
        private UnitOfWork()
        {

        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

      
        public static DbContext GetDbContext()
        {
            lock(b)
            {
                if (_dbContext==null) _dbContext= new DbContext("");
            }

             
            return _dbContext;
        }
    }
    
}
