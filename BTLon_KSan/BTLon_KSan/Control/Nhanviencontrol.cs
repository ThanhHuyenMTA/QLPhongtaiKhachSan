using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTLon_KSan.Model;
using BTLon_KSan.Object;
namespace BTLon_KSan.Control
{
    class Nhanviencontrol
    {
        public static DataTable getdatanv()
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            return nv.getdatanv();
        }
        public static DataTable timnvbymanv(string manv)
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            return nv.timnvbymanv(manv);
        }
        public static DataTable timnvbytennv(string tennv)
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            return nv.timnvbytennv(tennv);
        }
        public static DataTable timnvbyluong(int luong)
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            return nv.timnvbyluong(luong);
        }
        public static void addnv(Nhanvienobject nhanvien)
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            nv.addNV(nhanvien);
        }
        public static void updatenv(Nhanvienobject nhanvien)
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            nv.updateNV(nhanvien);
        }
        public static void deletenv(Nhanvienobject nhanvien) 
        {
            Nhanvienmodel nv = new Nhanvienmodel();
            nv.deleteNV(nhanvien);
        }
    }
}
