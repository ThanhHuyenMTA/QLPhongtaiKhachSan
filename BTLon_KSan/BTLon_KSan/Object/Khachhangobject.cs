using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_KSan.Object
{
    class Khachhangobject
    {
        private string makh;
        private string tendoan;

        public string Tendoan
        {
            get { return tendoan; }
            set { tendoan = value; }
        }

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        private string cmt;

        public string Cmt
        {
            get { return cmt; }
            set { cmt = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
       
        private string gt;

        public string Gt
        {
            get { return gt; }
            set { gt = value; }
        }
        private string madoan;

        public string Madoan
        {
            get { return madoan; }
            set { madoan = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public Khachhangobject()
        {

        }
        public Khachhangobject(string makh,string tenkh,string cmt,string sdt,string gt,string madoan,string diachi)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.cmt = cmt;
            this.sdt = sdt;
            this.gt = gt;
            this.madoan = madoan;
            this.diachi = diachi;
        }
    }
}
