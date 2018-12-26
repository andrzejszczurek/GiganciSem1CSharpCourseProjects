using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tablice
{
   class Program
   {
      static void Main(string[] args)
      {
         // tablice można rozumieć jak worki na dane
         // podczas gdy zmienna może przechowywać jedną wartość to tablica możę przechowywać wiele wartośći.
         // Ważne jest to, że w jednej tablicy mogą być zmienne tylko jednego typu.
         // symbolem tablicy jest - []

         // tworzenie prostej tablicy na zmienne całkowite:

         // zmienna typu tablicowego
         int[] tablicaNaLiczbyCalkowite;
         // następnie tworzymy tablice z przypisujemy do zmiennej
         tablicaNaLiczbyCalkowite = new int[3]; // w nawiasach musimy podać ile elementów ma przechowywać tablica

         // do elementów tablicy odwołujemy się po ich indeksie
         // Ważne!!! indeksowanie odbywa się od zera, to znaczy, że pierwszy element tablicy jest pod indeksem 0.

         // przypisywanie wartości elementą tablicy:

         tablicaNaLiczbyCalkowite[0] = 1;
         tablicaNaLiczbyCalkowite[1] = 2;
         tablicaNaLiczbyCalkowite[2] = 3;
         //tablicaNaLiczbyCalkowite[3] = 4; // jeżeli spróbujemy odwołać się do elementu z poza tablicy dostaniemy bład

         //w analogiczny sposób możemy dostać się do wartości zapisanych w tablicy:

         int liczbaPodIndeksemjeden = tablicaNaLiczbyCalkowite[1];
         Console.WriteLine($"Liczba pod indeksem jeden w tablicy ma wartość: {liczbaPodIndeksemjeden}");

         // najlepszym sposobem na przeglądanie tablicy są pętle - w tym wypadku najbardziej uzyteczna będzię pętla for

         int dlugoscTablicy = tablicaNaLiczbyCalkowite.Length; // każda tablica ma właściwośćź Length, która zwaraca jej długość
         // należy pamiętać, że indeks ostatniego elementu to : Length - 1;
         for (int i = 0; i < dlugoscTablicy; i++)
         {
            Console.WriteLine($"Element pod indeksem {i} w tablicy ma wartość: {tablicaNaLiczbyCalkowite[i]}"); // wypisuje kolejne elementy z tablicy
         }


         Console.ReadLine();
      }
   }
}
