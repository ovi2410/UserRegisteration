using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC8_onespecialcharacter
{
    class RegexSample
    {
        public void Validating()
        {
            Console.WriteLine("Validating password");
            ValidatingPassWord();
            Console.WriteLine("--------------------------");
        }
        public void ValidatingPassWord()
        {
            //string passwordPattern = @"[a-z,A-Z,0-9]{8,}$";
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8}$";
            Regex regex = new Regex(passwordPattern);
            Console.WriteLine("Enter password minimum 8 characters with one upper case");
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
