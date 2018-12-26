using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWstepAndRzutowanie
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         // na chwilę obecną to co musimy wiedzieć o tej części kodu to, że wszystko co jest w tych klamrach wykonuję się
         // w momencie tworzenia naszego okienka - jest to miejsce gdzie możemy ustawiać dodatkowe własności kontrolek formularza

         // TUTAJ JESZCZE KONTROLKI NIE ISTNIEJĄ
         InitializeComponent(); // ta metoda odpowiada za stworzenie wszystkich kontrolek na formularzu
         // TUTAJ JUŻ KONTROLKI SĄ I MOŻNA SIĘ DO NICH ODWOŁYWAC

         // to co chcemy ustawić to właściwość ReadOnly dla TextBoxa na wynik
         // wynik nie powinien być edytowalny, ale tylko do odczytu

         tbWynik.ReadOnly = true; // powoduje, że zawartość kontrolki jest tylko do odczytu
      }

      private void btnOblicz_Click(object sender, EventArgs e)
      {
         // wszystlo co napiszemy tutaj wykona się każdorazowo po naciśnięciu przypisku Oblicz
         // technicznie jest to metoda, która jest podpięta pod zdarzenie kliknięcia przypisku
         // o metoda i zdarzeniach będziemy się jeszcze uczyć.
        
         // pobieramy wartości z TexBoxów i zapisujemy do zmiennych.
         // wszystko co jest w TexbBoxie jest przechowywane jako tekst

         string txtMatematyka = tbMatematyka.Text; // pobranie zawartości tb i wpisanie do zmiennej
         string txtPolski = tbPolski.Text;
         string txtFizyka = tbFizyka.Text;
         string txtAngielski = tbAngielski.Text;
         string txtInformatyka = tbInformatyka.Text;

         // teraz parsujemy wartości zapisane tekstowo na liczby (zakładamy, że oceny sa liczbami całkowitymi)

         int mat = int.Parse(txtMatematyka);
         int pol = int.Parse(txtPolski);
         int fiz = int.Parse(txtFizyka);
         int ang = int.Parse(txtAngielski);
         int inf = int.Parse(txtInformatyka);

         // przygotowujemy się do obliczenia średniej
         int suma = mat + pol + fiz + ang + inf;
         int liczbaPrzedmiotow = 6;

         // srednia nie koniecznie będzie liczbą całkowitą. 
         // dzieleniem w naszym przypadku jest dzieleniem całkowitym, bo wykonujemy je na dwóch liczbach całkowitych
         // int / int = int, przez co stracilibyśmy część dziesiętną średniej. Zeby temu zapobieć potrzebujemy mieć dzielną jako lczbę zmiennoprzecinkową
         // w tym wypadku nalezy zastosować rzutowanie - zamianę jednego typu na inny
         double srednia = (double)suma / liczbaPrzedmiotow;  // rzutujemy sume na typ double i dopiero dzielimy


         // to tb można wpisać tylko tekst dlatego musimy srednia zamienić na tekst
         // służy do tego metoda ToString() - każda zmienna, nie zależnie od typu posiada taką metodę
         string txtSrednia = srednia.ToString();

         tbWynik.Text = txtSrednia; // ustawiamy właściwość Text TextBoxa tbWynik na naszą obliczoną średnią

      }
   }
}
