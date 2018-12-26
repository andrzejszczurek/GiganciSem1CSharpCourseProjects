using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra21
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Witaj w grze 21");
         bool czyGramy;
         do
         {
            Console.Write("Czy chcesz spróbować swoich sił (y/n)? ");
            czyGramy = Console.ReadLine() == "y";
            if (czyGramy)
            {
               int liczbaGraczy = WybierzIloscGraczy();
               StartGame(liczbaGraczy);
            }
         }
         while (czyGramy);
      }

      private static void StartGame(int liczbaGraczy)
      {
         int[] punktyGraczy = new int[liczbaGraczy]; // tablica na punkty graczy
         Random random = new Random();

         for (int i = 0; i < punktyGraczy.Length; i++) // pętla po graczach, oznaczająca ich ruchy
         {
            Console.WriteLine($"Ruch Gracza numer: {i+1}");
            int punkty = 0;
            bool czyGraczGraDalej = true;
            do
            {
               int nowaLiczba = random.Next(1, 6); // losujemy nową wartość punktów;
               punkty += nowaLiczba; // dodajemy do już uzbieranych punktów;
               if (punkty > 21) // jeżeli gracz ma więcej niż 21 punktów to nie ma sensu grać dalej
               {
                  Console.WriteLine($"W kolejnym rozdaniu uzyskano {punkty} punktów. Gracz automatycznie przegrywa");
                  czyGraczGraDalej = false;
               }
               else
               {
                  Console.WriteLine($"W kolejnym rozdaniu uzyskano {punkty} punktów. Czy chcesz kontynuować losowanie (y/n) ?");
                  czyGraczGraDalej = Console.ReadLine() == "y";
               }
            } while (czyGraczGraDalej);

            Console.WriteLine($"Koniec tury gracza numer: {i+1}");
            Console.WriteLine();
            punktyGraczy[i] = punkty; // wpisyujemy punty gracza to tabeli wyników
         }

         // gdy wszyscy gracze skończyli swój ruch to prezentujemy tablice wyników oraz zwycięzce
         PokazWynikiGry(punktyGraczy);
      }

      private static void PokazWynikiGry(int[] punktyGraczy)
      {
         for (int i = 0; i < punktyGraczy.Length; i++)
         {
            Console.Write($"Gracz numer '{i+1}' zdybył {punktyGraczy[i]} punktów:");
            if (punktyGraczy[i] > 21 )
            {
               Console.Write(" - automatyczna przegrana");
            }
            Console.WriteLine();
         }
         Console.WriteLine();
         int zwyciezca = ZnajdzZwyciezce(punktyGraczy);

         Console.WriteLine($"Zwyciężył gracz numer {zwyciezca}, kóry zdobył {punktyGraczy[zwyciezca]}");
      }

      private static int ZnajdzZwyciezce(int[] punktyGraczy)
      {
         int indeksZwyciezcy = 0;
         for (int i = 1; i < punktyGraczy.Length; i++)
         {
            if (punktyGraczy[indeksZwyciezcy] < punktyGraczy[i] && punktyGraczy[i] < 21)
            {
               indeksZwyciezcy = i;
            }
         }
         return indeksZwyciezcy;
      }

      private static int WybierzIloscGraczy()
      {
         do
         {
            Console.WriteLine("Podaj ilość graczy (max: 4) ");
            string podanaWartosc = Console.ReadLine();
            int liczbaGraczy;
            if (int.TryParse(podanaWartosc, out liczbaGraczy))
            {
               if (liczbaGraczy > 1 && liczbaGraczy <= 4)
               {
                  return liczbaGraczy;
               }
            }

         } while (true);
      }
   }
}
