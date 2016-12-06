using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Interfaces
{
    public interface IDataStore
    {
        List<IEmployee> Read(string employeeName);
        void Write(IEmployee employee);

    }
}
