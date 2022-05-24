using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC5_validPassword
{
    class RegexSample
    {
        public void Validating()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Validating password");
            ValidatingPassWord();
        }
        public void ValidatingPassWord()
        {
            string passwordPattern = @"[a-z,A-Z,0-9]{8,}$";
            Regex regex = new Regex(passwordPattern);
            Console.WriteLine("Enter password minimum 8 characters");
            string password = Console.ReadLine();
            bool res = regex.IsMatch(password);
            if (res)
            {
                Console.WriteLine("Password valid");
            }
            else
            {
                Console.WriteLine("invalid password");
            }
        }
    }
}


        
