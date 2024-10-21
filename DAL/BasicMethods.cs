using DTO.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BasicMethods<T>
    {
        protected CM_Cinema_DBDataContext DBDataContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString);

        public abstract List<T> GetList();
        public abstract void AddData(T obj);
        public abstract void UpdateData(T obj);
        public abstract void RemoveData(int id);

    }
}
