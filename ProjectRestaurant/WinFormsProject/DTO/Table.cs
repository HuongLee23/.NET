using System.Data;

namespace WinFormsProject.DTO
{
    public class Table
    {
        private int id;

        private string name;
        private string status;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Table()
        {

        }

        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"].ToString();
            this.Status = (string)row["status"].ToString();
        }
    }
}
