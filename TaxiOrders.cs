using System;
using _OperatorsSpace;

namespace _TaxiOrdersSpace
{
    public class TaxiOrders                             // класс ЗаказыТакси 
    {
        public int Id_Order {get;set;}                  // идентификатор заказа
        public int ClientPhoneNumber {get; set;}        // номер тел клиента
        public string TypeOfOrder {get; set;}           // тип заказа
        public int IdOperator;                          // идентификатор оператора принявший заказ
        public string ClearanceDate;                    // дата оформления
        

        public TaxiOrders(int idorder, int phonenumber, int idoperator, string typeoforder, string clearancedate)
        {
            
            this.Id_Order = idorder; 
            this.ClientPhoneNumber = phonenumber; 
            this.TypeOfOrder = typeoforder; 
            this.ClearanceDate = clearancedate;
            this.IdOperator = idoperator;
        }
        public void OrderData()
        {
            Console.WriteLine($"idorder : {this.Id_Order}");
            Console.WriteLine($"phonenumber : {this.ClientPhoneNumber}");
            Console.WriteLine($"typeoforder : {this.TypeOfOrder}");
            Console.WriteLine($"idoperator : {this.IdOperator}");
            Console.WriteLine($"clearancedate : {this.ClearanceDate}");
        }
    }
}