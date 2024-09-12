using System.Xml.Linq;

namespace Personalregister_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Register new employee: ");
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out int result))
                {
                    Console.WriteLine("The name input is not correct, Try Again. ");
                    break;
                }

                Console.Write("Enter Employee Salary: ");
                int salary;

                if (!int.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("The salary input is not a number, Try Again. ");

                }


                else
                {
                    List<Employee> employee = new List<Employee>();

                    employee.Add(new Employee { Name = name, Salary = salary });


                    foreach (Employee emp in employee)
                    {
                        Console.WriteLine($"Employee Name:{emp.Name} Salary:{emp.Salary}");

                    }
                }
                Console.WriteLine();

            }
        }
    }
}
