using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace PasswordEncryptionAuthentication
{
    public class Encryption : Formula
    {
        static void Main(string[] args)
        {
            bool valid;
            int choice;
            Dictionary<string, string> Account = new Dictionary<string, string>();
            Console.WriteLine("Would you like to do?");

        AddAnotherAccount:
            Console.WriteLine("1 :Create an account \t2: I do not want to create an account \t3: Exit");
            do
            {
                valid = int.TryParse(Console.ReadLine(), out choice);
                if (!valid || choice < 1 || choice > 3)
                {
                    Console.WriteLine("\nInvalid input");
                    valid = false;
                }

            } while (!valid);
                if (choice == 1)
                {
                    topof1:
                    Console.WriteLine("\nEnter a username");
                    string username = Console.ReadLine();
                if (Account.ContainsKey(username))
                {
                    Console.WriteLine("**Username already created**");
                    Console.WriteLine("Enter Again:");
                    goto topof1;
                }

                    Console.WriteLine("\nEnter a password");
                    string password = Console.ReadLine(),
                        encryptedPassword = EncryptInput(password);
                    Account.Add(username, encryptedPassword);

                    Console.WriteLine("\nWould you like to create another account?");
                    goto AddAnotherAccount;
                }
                else
                {
                    foreach (KeyValuePair<string, string> Users in Account)
                    {
                        Console.WriteLine($"\nUsername = {Users.Key}, Password = {Users.Value}");
                    }
                }

            if (choice == 3)
            {

            }
         
            

        }
    }
}
