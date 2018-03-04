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
    class NgCPcontrol
    {
        public static DataTable getdataNCP()
        {
            NgCPmodel ng = new NgCPmodel();
            return ng.getdataNCP();
        }
        public static DataTable TimNCP(string makh)
        {
            NgCPmodel ng = new NgCPmodel();
            return ng.timkiemNCP(makh);
        }
        public static void addNCP(NgCPobject nguoi)
        {
            NgCPmodel ng = new NgCPmodel();
            ng.addNCP(nguoi);
        }
        public static void updateNCP(NgCPobject nguoi)
        {
            NgCPmodel ng = new NgCPmodel();
            ng.updateNCP(nguoi);
        }
        public static void deleteNCP(NgCPobject nguoi)
        {
            NgCPmodel ng = new NgCPmodel();
            ng.deleteNCP(nguoi);
        }
    }
}
