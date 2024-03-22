using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.Metadata;

namespace WinFormsProject.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connection = "Server=LAPTOP-HDP7JM9D\\SQLEXPRESS; uid=sa; pwd=123; database=ProjectRestaurant; TrustServerCertificate=true; Integrated Security=true";


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connect.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connect.Close();
            }
            return data;
        }
    }
}
