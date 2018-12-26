using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Switch
{
   class Program
   {
      static void Main(string[] args)
      {
         // switch działa podobnie jak instrukcje warunkowe, na podstawie określonej wartości 
         // wybierana jest odpowiednia część kodu do wykonania
         // elementem warunkowym może tutaj być liczba całkowita albo tekst

         string dzienTygodnia = Console.ReadLine();
         switch (dzienTygodnia) // zostanie wykonany taki case jakiemy odpowiada wartość podana w zmiennej dzienTygodnia
         {
            case "Poniedziałek":
               {
                  Console.WriteLine($"{dzienTygodnia} jest pierwszym dniem tygodnia");
                  break; // break jest wymagany
               }
            case "Wtorek":
               {
                  Console.WriteLine($"{dzienTygodnia} jest drugim dniem tygodnia");
                  break;
               }
            case "Środa":
               {
                  Console.WriteLine($"{dzienTygodnia} jest trzecim dniem tygodnia");
                  break;
               }
            case "Czwartek":
               {
                  Console.WriteLine($"{dzienTygodnia} jest czwartym dniem tygodnia");
                  break;
               }
            case "Piątek":
               {
                  Console.WriteLine($"{dzienTygodnia} jest piątym dniem tygodnia");
                  break;
               }
            case "Sobota":
               {
                  Console.WriteLine($"{dzienTygodnia} jest szóstym dniem tygodnia");
                  break;
               }
            case "Niedziela":
               {
                  Console.WriteLine($"{dzienTygodnia} jest siódmym dniem tygodnia");
                  break;
               }
               // default wykonywany jest gdy wzorzec nie pasuje do żadnego case'a
            default:
               {
                  Console.WriteLine($"{dzienTygodnia} nie jest dniem tygodnia");
                  break;
               }
         }


      }
   }
}
