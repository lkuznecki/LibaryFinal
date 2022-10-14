using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessClass.Classes
{
    [Serializable]
    public class BooksDTO
    {
        public virtual int ID { get; set; }

        public virtual string Imie { get; set; }
        public virtual string Tytul { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual int NrAlbumu { get; set; }
        public virtual DateTime DataWypozyczenia { get; set; }
        public virtual DateTime TerminZwrotu { get; set; }

        public virtual string Gatunek { get; set; }
    }
}
