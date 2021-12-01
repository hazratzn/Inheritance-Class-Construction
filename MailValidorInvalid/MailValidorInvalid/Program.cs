using System;

namespace MailValidorInvalid
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail ="cavid@code.edu.az";
            string password = "123456";

            CheckMailandPassword("cavid@code.edu.az", "123124135");
        }
        static void CheckMailandPassword(string mail, string password)
        {
            if (mail == "cavid@code.edu.az" && password == "123456")
            {
                Console.WriteLine("Girish Olundu");
            }
            else
            {
                Console.WriteLine("Mail ve ya Password yalnishdir");
            }
        }
    }
}
