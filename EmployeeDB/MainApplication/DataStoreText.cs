using MainApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    public class DataStoreText : IDataStore
    {
        public DataStoreText()
        {
            if (!System.IO.File.Exists(@"C:\Users\Edgar\Documents\employeedatabase.txt"))
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Edgar\Documents\employeedatabase.txt", true);
                file.Write("");
                file.Close();
            }
        }

        public List<IEmployee> Read(string employeeName)
        {
            List<IEmployee> employeeList = new List<IEmployee>();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Edgar\Documents\employeedatabase.txt");
            
            foreach (string line in lines)
            {
                string[] employeeArray = line.Split('\t');
                if(employeeName == employeeArray[0])
                {
                    IEmployee readEmployee = new Employee();
                    readEmployee.Name = employeeArray[0];
                    readEmployee.Position = employeeArray[1];
                    readEmployee.Salary = double.Parse(employeeArray[2]);
                    employeeList.Add(readEmployee);
                }
                
             }
            return employeeList;
        }

        public void Write(IEmployee employee)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Edgar\Documents\employeedatabase.txt", true);
            string stringEmployee = employee.Name + "\t" + employee.Position + "\t" + employee.Salary;
            file.WriteLine(stringEmployee);
            file.Close();
            
        }
    }
}
