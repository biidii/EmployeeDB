using MainApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    public class Employee : IEmployee
    {
        private string _name;
        private string _position;
        private double _salary;


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        public double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }
    }
}
