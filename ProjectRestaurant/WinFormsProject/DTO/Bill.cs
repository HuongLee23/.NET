using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProject.DTO
{
    public class Bill
    {
        private int id;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime? DateCheckIn
        {
            get => dateCheckIn;
            set { dateCheckIn = value; }
        }

        public DateTime? DateCheckOut
        {
            get => DateCheckOut;
            set { dateCheckOut = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public Bill()
        {

        }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        private int discount;

        public int Discount { get; set; }

        public Bill(DataRow row)
        {
            //this.Id = (int)row["id"];
            //this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            //var dateCheckOutTemp = row["DateCheckOut"];
            //if (dateCheckOutTemp != "")
            //    this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            //this.Status = (int)row["status"];



            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];

            var dateCheckOutTemp = row["DateCheckOut"];
            if (dateCheckOutTemp != DBNull.Value) // Kiểm tra xem giá trị có phải DBNull không
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }

            this.Status = (int)row["status"];

            if(row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }
    }
}
