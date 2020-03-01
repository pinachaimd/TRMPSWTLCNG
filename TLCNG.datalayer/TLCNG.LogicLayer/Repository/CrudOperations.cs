using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TLCNG.datalayer;

namespace TLCNG.LogicLayer.Repository
{
    public class CrudOperations<T> : ICrudOperations<T> where T : class
    {
        private BDCatastroTulancingoEntities _context = null;
        private DbSet<T> table = null;
        public BDCatastroTulancingoEntities ContextModel { get { return _context; } }

        public DbSet<T> Table { get { return table; } }

        public bool HasTable { get { return table != null; } }// && table.Count() > 0; } }
        public CrudOperations()
        {
            this._context = new BDCatastroTulancingoEntities();
            table = _context.Set<T>();
        }
        public CrudOperations(BDCatastroTulancingoEntities context)
        {
            this._context = context;
            table = _context.Set<T>();
        }
        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IList<T> GetAllItems()
        {
            return table.ToList();
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }

}
