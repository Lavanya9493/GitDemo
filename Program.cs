using System;
namespace Lavanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee{Eno=9731, Ename="Lavanya", Esal=98000};
            Console.WriteLine(employee.ToString());

        }
    }
}
