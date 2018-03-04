using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_KSan.Object
{
    class P_Thueobject
    {
        private string maphieu;

        public string Maphieu
        {
            get { return maphieu; }
            set { maphieu = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        private int datcoc;

        public int Datcoc
        {
            get { return datcoc; }
            set { datcoc = value; }
        }
        private int thanhtien;

        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
