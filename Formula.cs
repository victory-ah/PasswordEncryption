using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PasswordEncryptionAuthentication
{
    public class Formula
    {
        public static string EncryptInput(string input)
        {
            using (SHA512 secure = SHA512.Create())
            {
                string secureInput = EncryptMyAccount(secure, input);
                    return secureInput;
            }

        }
        public static string EncryptMyAccount(SHA512 secure, string input)
        {
            byte[] data = secure.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder securePassword = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                securePassword.Append(data[i].ToString("x2"));
            }
            return securePassword.ToString();
        }
    }
}
