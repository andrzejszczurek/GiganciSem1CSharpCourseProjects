using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoryMatematyczneOrazLogiczne
{
   class Program
   {
      static void Main(string[] args)
      {
         // Operatory matematyczne w programowaniu działają tak samo jak w matematyce
         // poznamy zastosowanie nastepujących operatorów:
         // > - większę
         // >= - większę lub równe
         // < - mniejsze
         // <= - mniejsze lub równe
         // == - równe (nie mylić ze znakiem = - jest to operator przypisania)
         // != - różne (przeciwieństwo ==)
         // && - jest to matematyczna koniunkcja (daje prawdę gdy warunek po lewej i prawej stronie jest spełniony)
         //    określana inaczej jako logiczne 'and', 'i';
         // || - matematyczna alternatywa (daję prawdę gdy chociaż jeden warunek jest prawdziwy) - określana jako ligiczne 'or' 'lub'
         // ! - jest to negacja

         // wynikiem zaztosowania operatorów jest zawsze prawda lub fałsz - czyli wartości typu bool

         int a = 10;
         int b = 5;
         bool wynik;
         Console.WriteLine($"Liczba A = {a}");
         Console.WriteLine($"Liczba B = {b}");

         wynik = a > b;
         Console.WriteLine($"Wynik działania : a > b to : {wynik} "); 

         wynik = a >= b;
         Console.WriteLine($"Wynik działania : a >= b to : {wynik} "); 

         wynik = a < b;
         Console.WriteLine($"Wynik działania : a < b to : {wynik} "); 
      
         wynik = a <= b;
         Console.WriteLine($"Wynik działania : a <= b to : {wynik} "); 

         wynik = a == b;
         Console.WriteLine($"Wynik działania : a == b to : {wynik} "); 

         wynik = a != b;
         Console.WriteLine($"Wynik działania : a != b to : {wynik} "); 

         wynik = !true; // operator ! - neguje wynik
         Console.WriteLine($"Wynik działania : !true to : {wynik} ");

         wynik = (a == b) && (a > 5); // sprawdzamy dwa warunki i oba muszą być prawdziwe, żeby w wyniku dostać prawdę
         Console.WriteLine($"Wynik działania : (a == b) && (a > 5) to : {wynik} ");

         wynik = (a == b) || (a > 5); // sprawdzamy warunki i wystarczy
                                       //, że pierwszy sprawdzony warunek będzie prawdą, żeby dostać w wyniku prawdę
         Console.WriteLine($"Wynik działania : (a == b) || (a > 5) to : {wynik} ");

         Console.ReadLine();
      }
   }
}
