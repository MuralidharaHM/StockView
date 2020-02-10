using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuit.DataAccess
{
    public interface IStockRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int EmployeeID);
        void Insert(T employee);
        void Update(T employee);
        void Delete(int Id);
        void Save();


    }
    public class StockRepository<T> : IStockRepository<T> where T :class
    {

        DbContext _dbContext;
        DbSet<T> _table;

        public   StockRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            _table.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
