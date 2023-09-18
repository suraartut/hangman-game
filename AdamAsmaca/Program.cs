using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = new[] {"elma", "kırmızı", "türkiye", "helikopter"};
            Random rastgele = new Random(); //listten rastgele kelime seçimi
            string secilenkelime = kelimeler[rastgele.Next(0, kelimeler.Length)];
            

            //Seçilen kelime kadar _ oluşturma
            char[] karakters = new char[secilenkelime.Length];
            for(int i=0; i<karakters.Length; i++)
            {
                karakters[i] = '_';
            }

            do
            {

                bool tahmin = false;
                int puan = 0;

                foreach (var karakter in karakters)
                {
                    Console.Write(karakter + " ");
                }

                //Harf girme
                Console.WriteLine();
                Console.WriteLine("Bir harf giriniz");
                char harf = char.Parse(Console.ReadLine().ToLower());

                for (int i = 0; i < secilenkelime.Length; i++)
                {
                    if (harf == secilenkelime[i])
                    {
                        karakters[i] = harf;
                        tahmin = true;
                    }
                }

                //Puan arttırma - azaltma
                if(tahmin == true)
                {
                    puan += 20;
                }
                else
                {
                    puan -= 20;
                }

                Console.WriteLine("Puanınız: " + puan);
            }
            while (true);

            Console.ReadKey();
        }
    }
}
