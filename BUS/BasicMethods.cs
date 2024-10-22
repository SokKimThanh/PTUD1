using System.Collections.Generic;

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
