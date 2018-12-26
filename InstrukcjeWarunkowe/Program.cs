using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeWarunkowe
{
   class Program
   {
      static void Main(string[] args)
      {
         // instrukcje warunkowe służą do warunkowego wykonywania lub nie wykonywania bloków kodu

         Console.WriteLine("Podaj liczbę jakas liczbę:");
         int liczbaOdUzytkownika = int.Parse(Console.ReadLine());
         if (liczbaOdUzytkownika > 0) // wynikiem działanai w warunku musi być prawda lub fałsz
                                      // jeżeli warunek będzie spełniony to wykona się kod w klamrach po 'if'
         {
            Console.WriteLine("Podałeś liczbę większą od zera");
         }
         // instrukcji else if może być ile chcemy
         else if (liczbaOdUzytkownika < 0)
         {
            Console.WriteLine("Podałeś liczbę mniejszą od zera");
         }
         // fragment z else wykona się gdy nie spełniony będzie żaden z warunków
         else
         {
            Console.WriteLine("Użytkownik podał liczbę równą 0");
         }

         Console.ReadLine();
      }
   }
}
