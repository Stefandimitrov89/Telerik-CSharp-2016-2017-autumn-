//Description

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class BankAccData
    {
        static void Main(string[] args)
        {
            string firstName = "Kircho";
            string middleName = "Krasimirov";
            string lastName = "Petkov";
            decimal balance = 1.20M;
            string bankName = "Doge Bank";
            string IBAN = "DE44 5001 0517 5407 3249 31";
            string creditCardOne = "1111 2222 3333 4444";
            string creditCardTwo = "1234 5678 8912 3456";
            string creditCardThree = "1234 5678 9012 1416";
        }
    }
}
