using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            Console.WriteLine("emp.GetHashCode: " + emp.GetHashCode());
            Console.WriteLine("emp.GetType: " + emp.GetType());
            Console.WriteLine("emp.ToString: " + emp.ToString());

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;
            Console.WriteLine("hourEmp.GetHashCode: " + hourEmp.GetHashCode());
            Console.WriteLine("hourEmp.GetType: " + hourEmp.GetType());
            Console.WriteLine("hourEmp.ToString: " + hourEmp.ToString());

            Object athing = hourEmp;
            Console.WriteLine("hourEmp.ToString: " + athing);

            HourlyEmployee unboxedemp = (HourlyEmployee)athing;
            Console.WriteLine("FirstName: " + unboxedemp.FirstName);


            //Object athing = hourEmp;
            //Console.WriteLine("hourEmp.ToString: " + athing);

            //SalaryEmployee unboxedEmp2 = (SalaryEmployee)athing;
            //Console.WriteLine("FirstName: " + unboxedEmp2.FirstName);

            if (athing is HourlyEmployee)
            {
                //Unboxing
                HourlyEmployee unboxedEmp3 = (HourlyEmployee)athing;
                Console.WriteLine("First Name: " + unboxedEmp3.FirstName);
            }

            if (athing is HourlyEmployee)
            {
                //Unboxing
                SalaryEmployee unboxedEmp4 = (SalaryEmployee)athing;
                Console.WriteLine("First Name: " + unboxedEmp4.FirstName);
            }

        }
    }
}
