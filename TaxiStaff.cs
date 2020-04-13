namespace _TaxiStaffSpace
{
    public abstract class TaxiStaff        // абстрактный класс СотрудникиКонтактЦентраТакси
    {
        public int Id_employee {get; set;}              // идентификатор
        public string FirstNameEmployee {get; set;}     // имя
        public string LastNameEemployee {get; set;}     // фамилия
        public string DateOfBirth {get; set;}              // дата рождения

        // конструктор абстрактного класса 
        public TaxiStaff(int id, string firstname, string lastname, string dateofbirth)
        {
            this.Id_employee = id; 
            this.FirstNameEmployee = firstname; 
            this.LastNameEemployee = lastname; 
            this.DateOfBirth = dateofbirth; 
        }
        public abstract void EmployeeData();            // абстрактный метод    
    }
}