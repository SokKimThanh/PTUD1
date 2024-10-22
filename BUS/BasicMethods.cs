using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public abstract class BasicMethods<T>
    {
        public abstract List<T> GetList();
        public abstract bool AddData(T obj);
        public abstract bool UpdateData(T obj);
        public abstract bool RemoveData(int id);

    }
}
