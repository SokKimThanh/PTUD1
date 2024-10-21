using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BasicMethods<T>
    {
        public abstract List<T> GetList();
        public abstract void AddData(T obj);
        public abstract void UpdateData(T obj);
        public abstract void RemoveData(int id);

    }
}
