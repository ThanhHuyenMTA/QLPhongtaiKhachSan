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
    class Dichvucontrol
    {
        public static DataTable getdatadv()
        {
            Dichvumodel dv = new Dichvumodel();
            return dv.getdatadv();
        }
        public static DataTable getdatabytendv(string tendv)
        {
            Dichvumodel dv = new Dichvumodel();
            return dv.timdvbytendv(tendv);
        }
        public static DataTable getdatabygiadv(int giadv)
        {
            Dichvumodel dv = new Dichvumodel();
            return dv.timdvbygiadv(giadv);
        }
        public static void adddv(Dichvuobject dichvu)
        {
            Dichvumodel dv = new Dichvumodel();
            dv.themdichvu(dichvu);
        }
        public static void updatedv(Dichvuobject dichvu)
        {
            Dichvumodel dv = new Dichvumodel();
            dv.suadichvu(dichvu);
        }
        public static void deletedv(Dichvuobject dichvu)
        {
            Dichvumodel dv = new Dichvumodel();
            dv.xoadichvu(dichvu);
        }
    }
}
