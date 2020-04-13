using System;
using _TaxiStaffSpace;

namespace _OperatorsSpace
{
    public class Operators : TaxiStaff                      // класс Операторы 
    {
        public string Pseudonym {get; set;}                 // псевдоним оператора
        public int Category {get; set;}                     // катеория оператора
        public int NumberOfCalls {get; set;}                // количество звонков принятые оператором

        // конструктор класса операторы и обращаемся к конструктору абстрактного класса для вывода ее полей 
        public Operators(int id, string firstname, string lastname, string dateofbirth, string pseudonym, int numberofcalls, int category) 
        : base (id, firstname, lastname, dateofbirth)
        {
            this.Pseudonym = pseudonym;
            this.Category = category;
            this.NumberOfCalls = numberofcalls;
        }

        // переиспользуется объявленный абстрактный метод для вывода значения полей классов
        public override void EmployeeData(){
            Console.WriteLine($"id : {this.Id_employee}");
            Console.WriteLine($"firstname : {this.FirstNameEmployee}");
            Console.WriteLine($"lastname : {this.LastNameEemployee}");
            Console.WriteLine($"dateofbirth : {this.DateOfBirth}");
            Console.WriteLine($"category : {this.Category}");
            Console.WriteLine($"pseudonym : {this.Pseudonym}");
            Console.WriteLine($"numberofcalls : {this.NumberOfCalls}");
        }
    }
}