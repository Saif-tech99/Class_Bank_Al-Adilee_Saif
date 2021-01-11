using Class_Bank_Al_Adilee_Saif.Interfaces;
using System;


namespace Class_Bank_Al_Adilee_Saif.Models
{
    public class Transaction : Bank, ITransaction
    {
        private readonly string _code;
        private readonly string _date;
        private readonly double _amount;
        private double _commission = 0.5 / 100;

        public double GetAmount()
        {
            if (_amount > 100)
            {
                Console.WriteLine($"You will BE charged with extra comission : {_commission} ");
            }
            else if (_amount < 100)
            {
                Console.WriteLine("Your account will NOT Be charged");
            }
            return _amount;
        }

        public string ShowBankName()
        {
            Console.WriteLine($"{BankName}\n{Address}");
            return BankName;
        }

        public void ShowTransaction()
        {
            Console.WriteLine($"Transaction : {_code}\nDate : {_date}\nAmount : {_amount}");
        }

        public Transaction(string code, string date, double amount)
        {
            this._code = code;
            this._date = date;
            this._amount = amount;
        }
    }
}
