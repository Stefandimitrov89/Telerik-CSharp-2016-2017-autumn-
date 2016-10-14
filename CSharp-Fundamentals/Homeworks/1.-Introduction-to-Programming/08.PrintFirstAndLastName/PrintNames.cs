using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstAndLastName
{
    class PrintNames
    {
        static void Main(string[] args)
        {
            string[] firstAndLastName = { "FirstName", "LastName" };
            for (int i = 0; i < firstAndLastName.Length; i++)
            {
                Console.WriteLine(firstAndLastName[i]);
            }
        }
    }
}
