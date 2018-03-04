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
    class P_Thuecontrol
    {
        public static DataTable getdatap_thue()
        {
            P_Thuemodel ph = new P_Thuemodel();
            return ph.getdataP_thue();
        }
        public static DataTable timp_thuebymaphieu(string maphieu)
        {
             P_Thuemodel ph = new P_Thuemodel();
             return ph.timp_thuebymaphieu(maphieu);
        }
        public static DataTable timp_thuebymakh(string makh)
        {
             P_Thuemodel ph = new P_Thuemodel();
             return ph.timp_thuebymakh(makh);
        }
        public static DataTable timp_thuebyngaylap(DateTime ngaylap)
        {
             P_Thuemodel ph = new P_Thuemodel();
             return ph.timp_thuebyngaylap(ngaylap);
        }
        public static void addp_thue(P_Thueobject ph)
        {
             P_Thuemodel a = new P_Thuemodel();
             a.addP_thue(ph);
        }
        public static void updatep_thue(P_Thueobject ph)
        {
             P_Thuemodel a = new P_Thuemodel();
             a.updateP_thue(ph);
        }
        public static void deletep_thue(P_Thueobject ph)
        {
             P_Thuemodel a = new P_Thuemodel();
             a.deleteP_thue(ph);
        }
    }
}
