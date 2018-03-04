using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_KSan.Object
{
    class Phongbject
    {
        private string map;

        public string Map
        {
            get { return map; }
            set { map = value; }
        }
        private string loaip;

        public string Loaip
        {
            get { return loaip; }
            set { loaip = value; }
        }
        private string hangp;

        public string Hangp
        {
            get { return hangp; }
            set { hangp = value; }
        }
        private int giap;

        public int Giap
        {
            get { return giap; }
            set { giap = value; }
        }
        private string ttp;

        public string Ttp
        {
            get { return ttp; }
            set { ttp = value; }
        }
        private int sdtp;

        public int Sdtp
        {
            get { return sdtp; }
            set { sdtp = value; }
        }
        public Phongbject() { }
        public Phongbject(string map,string loaip,string hangp,int giap,string ttp,int sdtp)
        {
            this.map = map;
            this.loaip = loaip;
            this.loaip = loaip;
            this.hangp = hangp;
            this.giap = giap;
            this.ttp = ttp;
            this.sdtp = sdtp;
        }
    }
}
