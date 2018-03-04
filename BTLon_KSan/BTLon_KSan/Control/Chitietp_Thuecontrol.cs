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
    class Chitietp_Thuecontrol
    {
        public static DataTable getdatactThue()
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.getdatactThue();
        }
        public static DataTable getdateloadbymakh(string makh)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.getdataloadbymakh(makh);
        }
        public static DataTable timctp_thuebymaphieu(string maphieu)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.timctP_thuebymaphieu(maphieu);
        }
        public static DataTable timctp_thuebymap(string map)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.timctP_thuebymap(map);
        }
        public static DataTable timctp_thuebyngaythue(DateTime ngaythue)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.timctP_thuebyngaythue(ngaythue);
        }
        public static DataTable timctp_thuebyngaytradk(DateTime ngaytradk)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.timctP_thuebyngaytradk(ngaytradk);
        }
        //chú ý
        public static DataTable timctp_thue(string a)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.timctP_thue(a);
        }
        public static DataTable timctp_thuengay(DateTime a)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            return ct.timctP_thuengay(a);
        }
        //
        public static void addctp_thue(Chitietp_Thueobject ctp)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            ct.addctp_thue(ctp);
        }
        public static void updatectp_thue(Chitietp_Thueobject ctp)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            ct.updatep_thue(ctp);
        }
        public static void deletectp_thue(Chitietp_Thueobject ctp)
        {
            Chitietp_Thuemodel ct = new Chitietp_Thuemodel();
            ct.deletep_thue(ctp); 
        }

    }
}
