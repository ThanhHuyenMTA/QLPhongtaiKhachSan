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
    class Phongcontrol
    {
        public static DataTable getdatap()
        {
            Phongmodel a = new Phongmodel();
            return a.getdatap();
        }
        public static DataTable getdataphbymap(string map)
        {
            Phongmodel a = new Phongmodel();
            return a.timphbymap(map);
        }
        public static DataTable getdataphbyloaip(string loaip)
        {
            Phongmodel a = new Phongmodel();
            return a.timphbyloaip(loaip);
        }
        public static DataTable getdataphbyhangp(string hangp)
        {
            Phongmodel a = new Phongmodel();
            return a.timphbyhangp(hangp);
        }
        public static DataTable getdataphbyttp(string ttp)
        {
            Phongmodel a = new Phongmodel();
            return a.timphbyttp(ttp);
        }
        public static DataTable getdataphbygiap(int giap)
        {
            Phongmodel a = new Phongmodel();
            return a.timphbygiap(giap);
        }
        public static bool addphong(Phongbject phong)
        {
            Phongmodel b = new Phongmodel();
            b.insertphong(phong);
            return true;
        }
        public static bool updatephong(Phongbject phong)
        {
            Phongmodel c = new Phongmodel();
            c.suaphong(phong);
            return true;
        }
        public static bool deletephong(Phongbject phong)
        {
           Phongmodel c=new Phongmodel();
           c.Xoaphong(phong);
           return true;
        }

    }
}
