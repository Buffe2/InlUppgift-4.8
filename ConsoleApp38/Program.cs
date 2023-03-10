using System;
namespace InlUppgift_4._8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng");
            string str1 = Console.ReadLine();
            Console.WriteLine("Skriv in en sträng med 2 tecken");
            string str2 = Console.ReadLine();

            for (int i = 0; i < str1.Length; i++)
            {
                string str3 = str1[i].ToString();

                for (int j = 0; j < str2.Length; j++)
                {
                    string str4 = str2[j].ToString();

                    Console.WriteLine(string.Compare(str3,str4));
                }

            }

        }
                          //EJ FÄRDIG
    }

}