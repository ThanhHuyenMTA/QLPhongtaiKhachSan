using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_KSan.Object
{
    class Nhanvienobject
    {
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string tennv;

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        private DateTime ngaysinh;


        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private int luong;

        public int Luong
        {
            get { return luong; }
            set { luong = value; }
        }
    }
}
