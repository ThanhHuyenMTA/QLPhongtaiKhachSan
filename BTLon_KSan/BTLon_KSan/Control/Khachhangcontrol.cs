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
    class Khachhangcontrol
    {
        public static DataTable getdataK()
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.getdatak();
        }
        public static DataTable getdatabyTENDOAN(string tendoan)
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.getdatabytendoan(tendoan);
        }
        public static DataTable getdatabyDOAN(string madoan)
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.getdatabymadoan(madoan);
        }
        public static DataTable getdatabyMAKH(string makhach)
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.getdatabymaKH(makhach);
        }
        public static DataTable getdatabyTenkh(string tenkh)
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.TimbytenKH(tenkh);
        }
        public static DataTable getdatabySDT(string sdt)
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.getdatabySDT(sdt);
        }
        public static DataTable getdatabyCMT(string cmt){
            Khachhangmodel a=new Khachhangmodel();
             return  a.getdatabyCMT(cmt);
        }
        public static DataTable locnhanhKH(string key)
        {
            Khachhangmodel a = new Khachhangmodel();
            return a.locnhanhKH(key);
        }
        public static bool Addkhachhang(Khachhangobject khach)
        {
            Khachhangmodel kh = new Khachhangmodel();
            kh.addkhachhang(khach);
            return true;
        }
        public static bool Updatekhachhang(Khachhangobject khach)
        {
            Khachhangmodel kh = new Khachhangmodel();
            kh.suakhachhang(khach);
            return true;
        }
        public static bool Deletekhachhang(Khachhangobject khach)
        {
            Khachhangmodel kh = new Khachhangmodel();
            kh.xoakhachhang(khach);
            return true;
        }
    }
}
