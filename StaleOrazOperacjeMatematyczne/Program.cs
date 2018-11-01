using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaleOrazOperacjeMatematyczne
{
   // Aby zmienić program który będzie się uruchamiał klikamy na projekt który chcemy uruchomić np. Zmienne -> PPM -> Set as StartUpProject.
   // Od tej pory po kliknięciu Start, wybrany projekt będzie się uruchamiał. Projekt startowy jest zawsze pogrubiony

   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Aktywny projekt - Stale i operacje matematyczne");

         // 1. - stałe
         // stało od zmiennej różni się tym, że nie można zmienić jej raz przypisanej wartości
         // stałą tworzymy dopisując przed typ zmiennej słowo kluczone 'const'

         const double pi = 3.14159; // deklarując stałą trzebą ją od razu zainicjować (nadać jej wartość)
         // pi = 5.1; - spowoduje błąd

         Console.WriteLine("Liczba pi wynosi: {0}", pi);

         // 2. operatory artmetyczne
         // na zmiennych liczbowych możemy wokonywać standardowe operacje matematyczne

         int liczbaA = 10;
         int liczbaB = 15;
         int suma = liczbaA + liczbaB;
         int srednia = suma / 2;

         Console.WriteLine("Suma liczby {0} oraz liczby {1} to : {2}. Średnia wynosi {3}", liczbaA, liczbaB, suma, srednia);

         // zad: napisać program obliczający pole i obwód koła dla promienia podanego przez użytkownika

         double promien; // tworzymy zmienna na promien, który będzie podany z klawiaruty
         double obwod, pole; // zmienne na pole i obwod 

         Console.WriteLine("Proszę podać promień koła dla, którego chcesz obliczyć pole i obwód");
         string promienOdUzytkownika = Console.ReadLine(); // z konsoli pobieramy dane za pomocą: Console.ReadLine(),
                                                           //zawsze są typu tekstowego, więc najpierw zapisujemy sobie do zmiennej tekstowej

         promien = double.Parse(promienOdUzytkownika); // parsujemy wartość promienia zapisaną tekstem na liczbą, 
                                                       // (jeżeli tekst zawiera coś innego niż liczby to parsowanie się nie uda, a program zakończy się błędem)

         obwod = 2 * pi * promien; // obliczamy obwód koła
         pole = pi * promien * promien; // obliczamy pole

         Console.WriteLine("Podany promien: {0}, obliczny obwód koła to: {1}, a pole: {2}", promien, obwod, pole); // wyświetlamy wynik

         Console.ReadKey();
      }
   }
}
