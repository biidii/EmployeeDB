using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Interfaces
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Position { get; set; }
        double Salary { get; set; }
    }
}
