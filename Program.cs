using System;
using _TaxiStaffSpace;
using _OperatorsSpace;
using _TaxiOrdersSpace;
using _DriversTaxiSpace;

namespace ContactCenterTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators oper = new Operators(1, "test", "testov", "03.01.1999", "testpsevd", 997772255, 1);
            oper.EmployeeData();
            System.Console.WriteLine();

            TaxiOrders order = new TaxiOrders(1, 88899777, 1, "Межгород", "20.02.2020");
            order.OrderData();
            System.Console.WriteLine();

            DriversTaxis driver = new DriversTaxis(1, "taxist", "taxistovich", "03.04.2000", 234123, "Toyota", 9993322, "BC 1254 TJ 01");
            driver.EmployeeData();

            Console.ReadKey();
        }
    }
}
