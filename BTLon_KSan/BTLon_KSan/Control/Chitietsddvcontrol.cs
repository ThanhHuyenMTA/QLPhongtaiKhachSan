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
    class Chitietsddvcontrol
    {
        public static DataTable  getdatachitietdv()
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            return ctsd.getdatachitietdv();
        }
        public static  DataTable timctdvbymakh(string makh)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            return ctsd.timbymakh(makh);
        }
        public static DataTable timctdvbytenkh(string tenkh)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            return ctsd.timbytenkh(tenkh);
        }
        public static DataTable timctdvbytendv(string tendv)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            return ctsd.timbytendv(tendv);
        }
        public static DataTable timctdvbysldv(int soluongdv)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            return ctsd.timbysoluongdv(soluongdv);
        }
        public static DataTable timctdvbymadv(string madv)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            return ctsd.timbymadv(madv);
        }
        public static void ADDchitietsddv(ChitietsddvObject chitiet)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            ctsd.themchitietsddv(chitiet);
        }
        public static void updatechitietsddv(ChitietsddvObject chitiet)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();
            ctsd.suachitietsddv(chitiet);
        }
        public static void deletechitietsddv(ChitietsddvObject chitiet)
        {
            Chitietsddvmodel ctsd = new Chitietsddvmodel();

            ctsd.xoachitietsddv(chitiet);
        }
    }
}
