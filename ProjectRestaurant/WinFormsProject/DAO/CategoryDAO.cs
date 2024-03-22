using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProject.DTO;

namespace WinFormsProject.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO()
        {
        }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT [id] ,[name] FROM [dbo].[FoodCategory]";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category c = null;

            string query = "SELECT [id] ,[name] FROM [dbo].[FoodCategory] where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                c = new Category(item);
                return c;

            }
            return c;

        }
    }
}
