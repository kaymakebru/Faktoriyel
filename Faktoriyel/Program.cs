using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc = 1;
            Console.Write("Faktöriyel işlemi için pozitif bir tam sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            {
                for (int i = sayi; i >= 1; i--)
                {
                    sonuc *= i;
                }
                Console.WriteLine("{0}!: {1}", sayi, sonuc);

                //while (sayi >= 1)
                //{
                //    sonuc *= sayi;
                //    sayi--;
                //}
                //Console.WriteLine("Sonuç: " + sonuc);

            }
            Console.ReadLine();

        }
    }
}
