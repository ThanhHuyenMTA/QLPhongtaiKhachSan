using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTLon_KSan.Object;
using BTLon_KSan.Model;
using System.Data;
using System.Data.SqlClient;

namespace BTLon_KSan.Control
{
    class Doancontrol
    {
        public static DataTable getdatadoan()
        {
            Doanmodel da = new Doanmodel();
            return da.getdatadoan();
        }
        public static DataTable timnhanh_doan(string key)
        {
            Doanmodel da = new Doanmodel();
            return da.timnhanhdoan(key);
        }
        public static void adddoan(Doanobject doan)
        {
            Doanmodel a = new Doanmodel();
            a.adddoan(doan);
        }
        public static void updatedoan(Doanobject doan)
        {
            Doanmodel a = new Doanmodel();
            a.updatedoan(doan);
        }
        public static void deletedoan(Doanobject doan)
        {
            Doanmodel a = new Doanmodel();
            a.deletedoan(doan);
        }

    }
}
