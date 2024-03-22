using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProject.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string  FoodName { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public float  TotalPrice{ get; set; }

        public Menu(string foodName, int count, float price, float totalPrice)
        {
            FoodName = foodName;
            Count = count;
            Price = price;
            TotalPrice = totalPrice;
        }


        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
    }
}
