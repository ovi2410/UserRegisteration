// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using UC1_validfirstname;

namespace userregistration
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("user registration validating using regular expression");
            RegexSample regexsample = new RegexSample();
            regexsample.Validating();
        }
    }
}