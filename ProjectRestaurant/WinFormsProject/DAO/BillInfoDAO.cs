using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProject.DTO;

namespace WinFormsProject.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }

        }

        private BillInfoDAO() { }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("delete BillInfo where idFood = " + id);

        }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill = " + id);

            foreach (DataRow row in data.Rows)
            {
                BillInfo info = new BillInfo(row);
                listBillInfo.Add(info);
            }


            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }



    }
}
