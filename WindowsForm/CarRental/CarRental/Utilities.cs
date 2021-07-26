using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    class Utilities
    {

        internal static bool IsFormOpen(string formName)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();
            var isOpen = openForms.Any<Form>(x => x.Name == formName);
            return isOpen;
        }

        internal static string HashedPassword(string genericPassword)
        {
            //create SHA256 object
            SHA256 sha = SHA256.Create();
            // convert the string into array of bytes
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(genericPassword));

            //collect the byte from data as string using string builder

            StringBuilder s = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                s.Append(data[i].ToString("x2"));
            }

            return s.ToString();
        }

        internal static string HashGenericPassword()
        {
            //create SHA256 object
            SHA256 sha = SHA256.Create();
            // convert the string into array of bytes
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("password"));

            //collect the byte from data as string using string builder

            StringBuilder s = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                s.Append(data[i].ToString("x2"));
            }

            return s.ToString();
        }
    }
}
