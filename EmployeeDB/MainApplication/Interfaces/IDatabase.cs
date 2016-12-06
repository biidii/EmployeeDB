using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Interfaces
{
    public interface IDatabase
    {
        List<IEmployee> Read(string name);
        void Create(IEmployee employee);
        bool Update(IEmployee employee);
        void Delete();

    }
}
