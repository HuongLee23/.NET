using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProject.DTO;

namespace WinFormsProject.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + id + " and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "update dbo.Bill set status = 1 , DateCheckOut = getdate() , discount = " + discount + " , totalPrice = " + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkout", new object[] { checkIn, checkOut });
        }



        public DataTable GetBillListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn , @checkout , @page ", new object[] { checkIn, checkOut, pageNum });
        }


        public int GetNumListByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkout", new object[] { checkIn, checkOut });
        }



        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");

            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }
}
