using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTLon_KSan.Object;
using BTLon_KSan.Model;
namespace BTLon_KSan.Control
{
    class Hoadoncontrol
    {
        public static DataTable getdatahd()
        {
            Hoadonmodel hd = new Hoadonmodel();
            return hd.getdatahoadon();
        }
         public static DataTable timhdbymahd(string mahd)
         {
              Hoadonmodel hd = new Hoadonmodel();
             return hd.timhdbymahd(mahd);
         }
        public static DataTable timhdbymakh(string makh){
            Hoadonmodel hd = new Hoadonmodel();
            return hd.timhdbymakh(makh);
        }
         public static DataTable timhdbymanv(string manv){
              Hoadonmodel hd = new Hoadonmodel();
             return hd.timhdbymanv(manv);
         }
         public static DataTable timhdbyngaylap(DateTime ngaylap)
         {
             Hoadonmodel hd = new Hoadonmodel();
             return hd.timhdbyngaylap(ngaylap);
         }
        public static void addhoadon(Hoadonobject hoadon)
        {
            Hoadonmodel hd = new Hoadonmodel();
            hd.addhoadon(hoadon);
        }
        public static void updatehoadon(Hoadonobject hoadon)
        {
            Hoadonmodel hd = new Hoadonmodel();
            hd.updatehoadon(hoadon);
        }
        public static void deletehoadon(Hoadonobject hoadon)
        {
            Hoadonmodel hd = new Hoadonmodel();
            hd.deletehoadon(hoadon);
        }
    }
}
