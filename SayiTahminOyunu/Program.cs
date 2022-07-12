using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevEgitim
{
    internal class Program
    {    // Sadece geçerli denemeler deneme olarak sayıldı.
        static void Main(string[] args)
        {
            int sayac = 0;
            Random randomsayı = new Random();

            int seçilen_rs = randomsayı.Next(1, 100);

            bool kontrol2 = true;
            bool kontrol3 = true;

            while (kontrol3)
            {
                Console.WriteLine();


                if (kontrol2)

                {

                    Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı giriniz!");
                }


                string girilen_deger = Console.ReadLine();

                bool kontrol1 = true;

                while (kontrol1)
                {
                    for (int i = 0; i < girilen_deger.Length; i++)
                    {

                        char c = girilen_deger[i];

                        if (char.IsNumber(c) != true)
                        {
                            Console.WriteLine("Lütfen numerik bir değer giriniz!");
                            kontrol1 = false;
                            break;
                        }
                    }
                    break;

                }

                if (kontrol1)
                {

                    int girilen_deger2 = Convert.ToInt32(girilen_deger);

                    if (girilen_deger2 >= 1 && girilen_deger2 <= 100)

                    {
                        if (girilen_deger2 != seçilen_rs)

                        { sayac++; }

                        kontrol2 = false;

                        if (girilen_deger2 == seçilen_rs)

                        {
                            Console.WriteLine("Bravo " + (sayac + 1) + ".denemede bildiniz.");

                            kontrol3 = false;
                        }

                        else if (girilen_deger2 < seçilen_rs)
                        {

                            Console.WriteLine("Çık");

                        }

                        else { Console.WriteLine("İn"); }

                    }
                    else { Console.WriteLine("Lütfen belirtilen aralıkta bir değer giriniz!"); }



                }

            }

            Console.ReadLine();
        }
    }
}
