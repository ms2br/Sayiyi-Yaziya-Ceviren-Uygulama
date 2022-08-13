using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayiyi_Yaziya_Ceviren_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList RandomPaswword = new ArrayList();
            //Random rnd = new Random();

            //Console.Write("Buyuk Harf Sayisi : ");
            //int BigLetterNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kucuk Harf Sayisi : ");
            //int SmallLetterNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Rakam Sayisi : ");
            //int NumberOne = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= BigLetterNumber; i++)
            //{
            //    char BigLetter = (char)rnd.Next('A', 'Z');
            //    RandomPaswword.Add(BigLetter);
            //}

            //for (int i = 1; i <= SmallLetterNumber; i++)
            //{
            //    char SmallLetter = (char)rnd.Next('a', 'z');
            //    RandomPaswword.Add(SmallLetter);
            //}

            //for (int i = 1; i <= NumberOne; i++)
            //{
            //    int Number = rnd.Next(1,10);
            //    RandomPaswword.Add(Number);
            //}

            //foreach (var MyPassword in RandomPaswword)
            //{
            //    Console.Write(MyPassword);
            //}

            Random Rnd = new Random();
            ArrayList StrBuild = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                int ASCII = Rnd.Next(32, 127);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Add(Karakter);
            }
        }
    }
}
