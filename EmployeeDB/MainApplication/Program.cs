using MainApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new Database();

            while (true)
            {
                Console.WriteLine("Do you want to search for an employee or add a new employee?");
                Console.WriteLine("Click [S] for search, [A] for add, [U] to update.");

                var readKey = Console.ReadKey();
                var key = readKey.KeyChar;
                Console.WriteLine("");
                switch (key)
                {
                    case 'S':

                        Console.WriteLine("Name of the employee?");
                        var employeeNameSearch = Console.ReadLine();
                        List<IEmployee> employeeNameList = database.Read(employeeNameSearch);
                        if (employeeNameList.Count == 0)
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        else
                        {

                            for (int x = 0; x < employeeNameList.Count(); x++)
                            {
                                Console.WriteLine(employeeNameList[x].Name + "\t" + employeeNameList[x].Position + "\t" + employeeNameList[x].Salary);
                            }

                        }
                        break;
                    case 'A':
                        Console.WriteLine("Employee name?");
                        var employeeNameAdd = Console.ReadLine();
                        Console.WriteLine("Employee position?");
                        var employeePositonAdd = Console.ReadLine();
                        Console.WriteLine("Employee salary?");
                        var employeeSalaryAdd = Console.ReadLine();
                        double employeeSalaryDouble = double.Parse(employeeSalaryAdd);


                        IEmployee employee = new Employee();
                        employee.Name = employeeNameAdd;
                        employee.Position = employeePositonAdd;
                        employee.Salary = employeeSalaryDouble;

                        database.Create(employee);

                        break;
                    case 'U':
                        Console.WriteLine("Employee name?");
                        var employeeNameUpdate = Console.ReadLine();
                        Console.WriteLine("Employee position?");
                        var employeePositonUpdate = Console.ReadLine();
                        Console.WriteLine("Employee salary?");
                        var employeeSalaryUpdate = Console.ReadLine();
                        double employeeSalaryDoubleUpdate = double.Parse(employeeSalaryUpdate);


                        IEmployee employeeUpdate = new Employee();
                        employeeUpdate.Name = employeeNameUpdate;
                        employeeUpdate.Position = employeePositonUpdate;
                        employeeUpdate.Salary = employeeSalaryDoubleUpdate;

                        database.Update(employeeUpdate);
                        break;

                }


            }
        }
    }
}
