using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3_kamsülleme
{
    class emlak
    {
        private string semt;
          
        public string semt
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }


        private int odasayisi;
        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi =Math.Abs(value); }
        }
        private int kat;
        public int Kat
        {
            get { return kat; }
            set { kat = Math.Abs(value); }
        }

    }
}
