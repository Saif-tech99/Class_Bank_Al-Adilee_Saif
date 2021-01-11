using Class_Bank_Al_Adilee_Saif.Interfaces;
using Class_Bank_Al_Adilee_Saif.Models;
using System;


namespace Class_Bank_Al_Adilee_Saif
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of class
            Transaction transaction1 = new Transaction("0001", "01/01/2021", 376);
            transaction1.ShowBankName();
            transaction1.ShowTransaction();
            transaction1.GetAmount();

            Console.WriteLine("-----------------------");
            //instance of Interfaces
            ITransaction transaction2 = new Transaction("0002", "10/01/2021", 98);
            transaction2.ShowBankName();
            transaction2.ShowTransaction();
            transaction2.GetAmount();


        }
    }
}
