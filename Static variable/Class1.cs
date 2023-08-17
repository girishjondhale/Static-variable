using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_variable
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Emlpoyee emp2 = new Emlpoyee("aaa", 14000);
            emp2.CalculateSalary();
            Console.WriteLine(emp2.CalculateSalary());

            Console.WriteLine(Emlpoyee.Getcount());

            Sales_maneger sales_Maneger = new Sales_maneger(500, 1, "ccc");
            sales_Maneger.CalculateSalary();
            Console.WriteLine(sales_Maneger);
        }
    }
}
