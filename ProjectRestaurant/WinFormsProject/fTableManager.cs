using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProject.DAO;
using WinFormsProject.DTO;

namespace WinFormsProject
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Role); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            ChangeAccount(loginAccount.Role);

            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
        }

        void ChangeAccount(int role)
        {
            adminToolStripMenuItem.Enabled = role == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LoginAccount.DisplayName + ")";
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;

            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryId(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryId(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }



        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight
                };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += btn_Click;
                btn.Tag = table;
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.DarkGray;
                        break;
                    default:
                        btn.BackColor = Color.Lime;
                        break;

                }
                flpTable.Controls.Add(btn);




            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<WinFormsProject.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenyByTable(id);
            float totalPrice = 0;
            foreach (Menu info in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(info.FoodName.ToString());
                lsvItem.SubItems.Add(info.Count.ToString());
                lsvItem.SubItems.Add(info.Price.ToString());
                lsvItem.SubItems.Add(info.TotalPrice.ToString());
                totalPrice += info.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            //Cách để gọi đa ngôn ngữ
            CultureInfo current = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c", current);

        }


        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object? sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.UpdateFood += f_UpdateFood;
            f.DeleteFood += f_DeleteFood;

            f.InsertCategory += f_InsertCategory;
            f.UpdateCategory += f_UpdateCategory;
            f.DeleteCategory += f_DeleteCategory;

            f.InsertTable += f_InsertTable;
            f.UpdateTable += f_UpdateTable;
            f.DeleteTable += f_DeleteTable;


            f.ShowDialog();
        }

        private void f_DeleteTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        private void f_UpdateTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        private void f_InsertTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        private void f_DeleteCategory(object? sender, EventArgs e)
        {
            cbCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        private void f_UpdateCategory(object? sender, EventArgs e)
        {
            cbCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        private void f_InsertCategory(object? sender, EventArgs e)
        {
            cbCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        private void f_UpdateFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }

        private void f_DeleteFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }

        private void f_InsertFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCategoryId(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int foodId = (cbFood.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodId, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodId, count);
            }
            ShowBill(table.Id);
            LoadTable();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int discount = (int)nmDisCount.Value;

            if (txtTotalPrice.Text.Equals("0 ₫"))
            {
                MessageBox.Show("Không có hóa đơn nào để thanh toán!");
            }
            else
            {
                double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split('.')[0]);
                double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn thanh toán hóa đơn cho bàn {0}\n Tổng tiền - (Tổng tiền / 100) x Giảm giá => {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                        ShowBill(table.Id);
                        LoadTable();
                    }
                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).Id;
            int id2 = (cbSwitchTable.SelectedItem as Table).Id;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }
    }
}
