using System;
using _TaxiStaffSpace;
namespace _DriversTaxiSpace
{
    public class DriversTaxis : TaxiStaff
    {
        public int CallSign;                // позывной водителя
        public string CarMakeAndModel;      // Марка и Модель Машины   
        public string CarNumber;               // НомерНашины      
        public int DriverPhoneNumber;       // номер телефона водителя
        public DriversTaxis(int id, string firstname, string lastname, string dateofbirth, 
                            int callsign, string carmakeandmodel, int driverphonenumber, string carnumber)
                            : base (id, firstname, lastname, dateofbirth)
        {
            this.CallSign = callsign;
            this.CarMakeAndModel = carmakeandmodel;
            this.DriverPhoneNumber = driverphonenumber;
            this.CarNumber = carnumber;
        }
        public override void EmployeeData()
        {
            Console.WriteLine($"id : {this.Id_employee}");
            Console.WriteLine($"callsign : {this.CallSign}");
            Console.WriteLine($"firstname : {this.FirstNameEmployee}");
            Console.WriteLine($"lastname : {this.LastNameEemployee}");
            Console.WriteLine($"dateofbirth : {this.DateOfBirth}");
            Console.WriteLine($"carmakeandmodel : {this.CarMakeAndModel}");
            Console.WriteLine($"carnumber : {this.CarNumber}");
            Console.WriteLine($"driverphonenumber : {this.DriverPhoneNumber}");
        }
    }
}