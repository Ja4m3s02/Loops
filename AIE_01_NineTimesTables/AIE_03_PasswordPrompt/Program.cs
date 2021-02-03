using System;

namespace AIE_14_PasswordPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            string matchingPassword = "";

            do
            {
                Console.Write("Enter a password: ");
                password = Console.ReadLine();

                Console.Write("Confirm a password: ");
                matchingPassword = Console.ReadLine();

            } while (password != matchingPassword);

            Console.WriteLine("Your password was confirmed");
            Console.WriteLine("Exiting");

        }
    }
}
