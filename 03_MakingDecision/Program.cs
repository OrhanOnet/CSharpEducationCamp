using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  If Else

            Console.WriteLine("Lütfen şifreyi giriniz:");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şfre Doğru");

            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            Console.ReadLine();

            #endregion
        }
    }
}
