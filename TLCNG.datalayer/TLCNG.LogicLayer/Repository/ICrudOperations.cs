using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLCNG.LogicLayer.Repository
{
    interface ICrudOperations<T> where T : class
    {
        IList<T> GetAllItems();
        T GetByID(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        int Save();

    }

}
