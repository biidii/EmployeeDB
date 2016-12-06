using MainApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    public class Database : IDatabase
    {
        private IDataStore _dataStore = null;

        public Database()
        {
            _dataStore = new DataStoreText();
        }

        public void Create(IEmployee employee)
        {
            if (_dataStore.Read(employee.Name).Count() == 0)
            {
                _dataStore.Write(employee);
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<IEmployee> Read(string name)
        {
           return _dataStore.Read(name);
        }

        public bool Update(IEmployee employee)
        {
            if (_dataStore.Read(employee.Name).Count() == 0)
            {
                return false;
            }
            _dataStore.Write(employee);
            return true;
        }
    }

}
