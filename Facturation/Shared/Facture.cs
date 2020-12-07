using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {
        public DateTime DateE { get; set; }

        public DateTime DateR { get; set; }

        public int MontantD { get; set; }

        public int MontantR { get; set; }

        public string Numero { get; set; }

        public string Client { get; set; }


    }
}
