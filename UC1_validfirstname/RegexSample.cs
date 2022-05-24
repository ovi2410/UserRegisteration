using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC1_validfirstname
{
    class RegexSample
    {
        string pattern = "^[A-Za-z]{3,}$";
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating The first Name");
            ValidatingfirstName();

        }
        public void ValidatingfirstName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the first name : ");
            string input1 = Console.ReadLine();
            bool res1 = regex.IsMatch(input1);
            if (res1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

