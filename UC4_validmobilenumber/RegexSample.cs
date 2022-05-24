using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4_validmobilenumber
{
    class RegexSample
    {
        public void Validating()
        {
            //Regex regex = new Regex(pattern);
            Console.WriteLine("Validating Phone Number");
            ValidatingPhoneNum();
        }
        public void ValidatingPhoneNum()
        {
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);
            Console.WriteLine("Enter valid Phone Number");
            string phoneNumber = Console.ReadLine();
            bool res = regex.IsMatch(phoneNumber);
            if (res)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }


        }
    }
}


