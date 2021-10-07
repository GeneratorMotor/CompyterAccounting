using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Repositories
{
    public interface IRepository<T>
    {
        List<T> SelectAll();
        void Insert(T item);

        void Update(T item);

        T Where(int id);


    }
}
