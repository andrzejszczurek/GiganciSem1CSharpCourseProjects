using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
   // Aby zmienić program który będzie się uruchamiał klikamy na projekt który chcemy uruchomić np. Zmienne -> PPM -> Set as StartUpProject.
   // Od tej pory po kliknięciu Start, wybrany projekt będzie się uruchamiał. Projekt startowy jest zawsze pogrubiony

   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Stale i operacje matematyczne");

         // zmienne to najprościej opisując pudełeczka na dane.
         // technicznie jest to informacja dla kompilatora, że ma dla nas zarezerwować miejsce w pamięci na przychowywania danych.

         // zmienna składa się z dwóch elementów: typu danych jakie chcemy przechować oraz nazwy - po której będziemy się do tych danych odwoływać.
         // dodatkowo do zmiennej możemy od razu przypisać jakąś konkretną wartość.

         int a; // stworzenie zmiennej typu int o nazwie a. Każdą instrukcję w C# kończymy średnikiem: ; 

         int b = 5; // stworzenie zmiennej oraz przypisanie do niej wartości 5;

         int c; // do raz stworzonej zmiennej przypisywać możemy wartości w dowolnym momencie. Typ zmiennej podajemy tylko w momencie jej definiowania.
         c = 5;  // potem odwołujemy się już tylko po jej nazwie.

         // Podstawowe typy zmiennych:
            // typy liczbowe
         int liczbyCalkowite = 4; // int - typ na liczby całkowite
         double liczbyZmiennoprzecinkowe = 4.56; // double - typ na liczby niecałkowite (podwójnej precyzji)
         float liczbyZmiennoPrzecinkowe2 = 3.561f; // float - liczby niecałkowite, podobnie jak double ale mniejszej precyzji (Na końcu liczby trzeba dopisać literkę 'f' lub 'F')
         decimal liczbyStaloPrzecinkowe = 3.4000m; // decimal - typ wykorzystywany do operacja na pieniądzach, na końcu dopisujemy literkę 'm' lub 'M' (od ang: Money)

            // pozostały typy
         string teksty = "Ala ma kota"; // typ na tekst (łańcuchy znaków), teksty zawsze zapisujemy w cudzysłowiu;
         char znak = 'A'; // typ na pojedynczy znak, zapisujemy w pojedynczych apostrofach ''
         bool logiczny = false; // typ logiczny przechowuje dwie wartości false lub true - informuje czy coś jest prawdą lub nie

         // polecienie do wyświetlania na konsoli informacji to Console.WriteLine(), w nawiasie podajemy co ma sie wyświetlić
         Console.WriteLine(teksty); // wypisze na konsole zawartość zmiennej 'teksty'

         Console.WriteLine("Zmienna b ma wartość {0}, natomiastz mienna 'znak' {1}", b, znak); // w taki sposób mozna formatować wyjście
         Console.WriteLine($"Zmienna b ma wartość {b}, natomiastz mienna 'znak' {znak}"); // od wersji C# 6 (.Net Framework 4.6) dostępna jest funkcjonalność interpolacji stringów

         Console.ReadLine(); // dodajemy zawsze na koniec w aplikacjach konsolowych, aby po wykonaniu programy zobaczyć wyniki (inaczej konsola nam się zamknie)
      }
   }
}
