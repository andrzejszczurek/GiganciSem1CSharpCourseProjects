using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Petle
{
   class Program
   {
      static void Main(string[] args)
      {
         // pętle do bardzo przydatny element w programowaniu, pozwala wykonywać pewne fragmenty kodu wielokrotnie
         // w C# występują trzy podstawowe pętle: for, while, oraz do-while

         Console.WriteLine("Przykład działania pętli for:");
         // zasada działania:
         // na początku pętli tworzona jest zmienna i, która będzie zliczać ilość wykonań pętli (int i = 0)
         // następnie sprawdzany jest warunek (i < 10), jeżeli warunek jest spełniony to następuje wykonanie kodu zawarteko w ciele petli { },
         // następnie zmienna i jest zwiększana o 1 (i++)
         // znowu sprawdzany jest warunek... i tak dalej, dopóki warunek jest spełniony
         for (int i = 0; i < 10; i++)
         {
            Console.WriteLine($"Iteracja numer {i} w pętli for");
         }


         Console.WriteLine("Przykład działania pętli while:");
         // pętla while wymaga podobnie jak instrukcjaq warunkowa podania warunku.
         // pętla pedzie wykonywana póki warunek ma wartość true
         // może się okazać, że warunek na namym początku będzie mieć wartość false i wtedy pętla nie wykona sie ani razu
         bool warunek = true;
         int iterator = 1;
         while (warunek)
         {
            Console.WriteLine($"Iteracja numer {iterator} w pętli while");
            iterator++;
            // Jeżeli iterator osiąnie wartość równą lub większą 5 to ustawiamy warunek na false, 
            // przez co nie nastapi już kolejne wykonanie petli
            if (iterator >= 5)
            {
               warunek = false;
            }
         }

         // Różnica pomiędzy while, a do-while polega na tym, że w do-while warunek sprawdzany jest pod koniec obiegu petli
         // co oznacza, że nawet jeżeli warunek jest nie spełniony to pętla wykona się przynajmniej raz.
         Console.WriteLine("Przykład działania pętli do-while:");
         iterator = 0;
         warunek = false;
         do
         {
            iterator++;
            Console.WriteLine($"Iteracja numer {iterator} w pętli do-while");
         } while (warunek);


         Console.ReadLine();
      }
   }
}
