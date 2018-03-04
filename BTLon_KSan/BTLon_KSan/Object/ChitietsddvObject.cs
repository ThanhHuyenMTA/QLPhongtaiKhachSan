using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_KSan.Object
{
    class ChitietsddvObject
    {
        private string makh;
        private string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        private string tendv;

        public string Tendv
        {
            get { return tendv; }
            set { tendv = value; }
        }
        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string madv;

        public string Madv
        {
            get { return madv; }
            set { madv = value; }
        }
        private DateTime ngaysd;

        public DateTime Ngaysd
        {
            get { return ngaysd; }
            set { ngaysd = value; }
        }
        private int sldv;

        public int Sldv
        {
            get { return sldv; }
            set { sldv = value; }
        }
        private int tongtien;

        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
    }
}
