using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            string islem;
            double sonuc;
            try
            {
                Console.WriteLine("iki adet sayi giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("+,-,*,/");
                islem = Console.ReadLine();

                if (islem == "+")
                {
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("toplam=" + sonuc);

                }
                else if (islem == "-")
                {
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("fark=" + sonuc);
                }
                else if (islem == "*")
                {
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("carpim=" + sonuc);

                }
                else if (islem == "/")
                {
                    {
                        if (sayi2 != 0)
                        {


                            Console.WriteLine("bolum=" + (Decimal.Divide(sayi1, sayi2)));

                        }
                        else
                        {
                            sonuc = double.NaN;
                            Console.WriteLine(sonuc);

                        }
                    }
                }
                else
                {
                    Console.WriteLine("yanlis bir islem seçtiniz");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("HATALİ İSLEM");
            }

        }

    }
}
