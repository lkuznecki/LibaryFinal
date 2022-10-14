using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessClass.Classes
{
    [Serializable]
    public class Borrowages
    {
        public virtual int ID { get; set; }
        public virtual string Gatunek { get; set; }
        
        public virtual List<Books> Books { get; set; }
    }
}
