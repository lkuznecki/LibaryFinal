using System;
using Baza;
using AccessClass.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public static class MethodClass
    {
        public static void Add(string Imie,string Nazwisko, int nralbumu, DateTime DataWypozyczenia, DateTime TerminZwrotu, string Gatunek,string Tytul)
        {
            Model1 modelbazy = new Model1();
            modelbazy.Books.Add(new Books() { BorrowagesG = modelbazy.Borrowages.FirstOrDefault(n => n.Gatunek == Gatunek), DataWypozyczenia = DataWypozyczenia, TerminZwrotu = TerminZwrotu, NrAlbumu = nralbumu, Imie = Imie, Nazwisko = Nazwisko, Tytul=Tytul });
            modelbazy.SaveChanges();
        }

        public static List<BooksDTO> BooksDTOs()
        {
            Model1 modelBazy = new Model1();
            return modelBazy.Books.ToList().Select(n =>
            {
                return new BooksDTO() { Nazwisko = n.Nazwisko, Imie = n.Imie, DataWypozyczenia = n.DataWypozyczenia, TerminZwrotu = n.TerminZwrotu, Gatunek = n.BorrowagesG.Gatunek, NrAlbumu = n.NrAlbumu , Tytul=n.Tytul};
            }).ToList();
        }
        public static List<Borrowages> Borrowages()
        {
            Model1 modelBazy = new Model1();
            return modelBazy.Borrowages.ToList();
        }
    }



}
