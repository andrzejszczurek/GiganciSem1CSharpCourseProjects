using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgadywanka
{
   class Program
   {
      static void Main(string[] args)
      {
         Random random = new Random();
         Console.WriteLine("WITAJ W ZGADYWANCE LICZB");
         bool czyGramy;
         do
         {
            Console.Write("Czy chcesz spróbować swoich sił (y/n)? ");
            czyGramy = Console.ReadLine() == "y";
            Console.WriteLine();
            if (czyGramy)
            {
               StartGame(random);
            }
         } while (czyGramy);
         Console.WriteLine("Gra zakończona");
      }

      private static void StartGame(Random random)
      {
         int wylosowanaLiczba = random.Next(1, 1001);
         int licznikProb = 0;
         bool czyWygrana = false;
         Console.WriteLine("Wylosowałem dla ciebie liczbą z zakresu: <1, 1000>. Spóbój zgadnąć jaka to liczba");

         do
         {
            licznikProb++;
            Console.Write("Podaj swoją liczbę: ");
            string podanaWartosc = Console.ReadLine();
            int podanaLiczba = SprawdzCzyPodanaWartoscToLiczba(podanaWartosc);
            Console.WriteLine();
            czyWygrana = SprawdzCzyWygrana(podanaLiczba, wylosowanaLiczba);
         } while (!czyWygrana);

         Console.WriteLine($"BRAWO!!! Udało Ci się zgadnąć moją liczbę za {licznikProb} razem.");
      }

      private static bool SprawdzCzyWygrana(int podanaLiczba, int wylosowanaLiczba)
      {
         if (podanaLiczba > wylosowanaLiczba)
         {
            Console.WriteLine("Nie udało się, moja liczba jest mniejsza od podanej");
            return false;
         }
         else if (podanaLiczba < wylosowanaLiczba)
         {
            Console.WriteLine("Nie udało się, moja liczba jest większa od podanej");
            return false;
         }

         return true;
      }

      private static int SprawdzCzyPodanaWartoscToLiczba(string podanaWartosc)
      {
         int liczba = -999; // dla uproszczenia przypisujemy ujemna liczbe, tak zweryfikujemy czy podano poprawną wartość
         if (!int.TryParse(podanaWartosc, out liczba)) // Metoda TryParse jest nieco bardziej skomplikowana i wykracza po za zakres
         {                                            // jedna jej wykorzystanie zabezpiecza nas przed podaniem czegoś innego niż liczba.
            Console.WriteLine($"Podana wartość {podanaWartosc} nie jest liczbą całkowitą");
         }
         return liczba;
      }
   }
}
