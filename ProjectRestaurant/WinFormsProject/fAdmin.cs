using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProject.DAO;
using WinFormsProject.DTO;

namespace WinFormsProject
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();

        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            Load();
        }


        #region methods

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }

        void Load()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePikerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            LoadAccount();
            AddFoodBinding();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            nmAccountRole.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "role", true, DataSourceUpdateMode.Never));

        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void LoadDateTimePikerBill()
        {
            DateTime today = DateTime.Today;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void AddFoodBinding()
        {
            txtFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtFoodName.DataBindings.Add(new Binding("text", dtgvFood.DataSource, "name", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));

        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        #endregion






        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.Rows.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["idCategory"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbFoodCategory.SelectedItem = category;
                    //int index = cbFoodCategory.Items.IndexOf(category);

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int categoryId = (cbFoodCategory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryId, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn!");
            }

        }


        private void btnEditFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFoodID.Text);
            string name = txtFoodName.Text;
            int categoryId = (cbFoodCategory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.UpdateFood(id, name, categoryId, price))
            {
                MessageBox.Show("Cập nhật món thành công");
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật thức ăn!");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();

                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn!");
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFoodName.Text);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        void AddAccount(string username, string displayNmae, int role)
        {
            if (AccountDAO.Instance.InsertAccount(username, displayNmae, role))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string displayname = txtDisplayName.Text;
            int role = (int)nmAccountRole.Value;
            AddAccount(username, displayname, role);
        }

        void UpdateAccount(string username, string displayNmae, int role)
        {
            if (AccountDAO.Instance.UpdateAccount(username, displayNmae, role))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            }
            LoadAccount();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string displayname = txtDisplayName.Text;
            int role = (int)nmAccountRole.Value;
            UpdateAccount(username, displayname, role);
        }


        void DeleteAccount(string username)
        {
            if (loginAccount.UserName.Equals(username))
            {
                MessageBox.Show("Vui lòng không xóa tài khoản hiện tại của bạn!");
                return;
            }

            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!");
            }
            LoadAccount();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            DeleteAccount(username);
        }

        void ResetPassword(string username)
        {
            if (AccountDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
            }
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            ResetPassword(username);
        }

        private void btnFirstBillPage_Click(object sender, EventArgs e)
        {
            txtPageBill.Text = "1";
        }

        private void btnLastBillPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumListByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            txtPageBill.Text = lastPage.ToString();
        }

        private void txtPageBill_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txtPageBill.Text));
        }

        private void btnPreviousBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageBill.Text);
            if (page > 1)
            {
                page--;
            }
            txtPageBill.Text = page.ToString();
        }

        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumListByDate(dtpkFromDate.Value, dtpkToDate.Value);
            if (page < sumRecord)
            {
                page++;
            }
            txtPageBill.Text = page.ToString();
        }

        private event EventHandler insertFood;

        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;

        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler deleteFood;

        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }




        #endregion



        //void LoadFoodList()
        //{
        //    string query = "select * from Food";

        //    dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}

        //void LoadAccountList()
        //{
        //    string query = "select * from Account";

        //    dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}

    }

}
