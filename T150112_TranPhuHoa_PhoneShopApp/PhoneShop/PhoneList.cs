using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T150112_TranPhuHoa_PhoneShopApp.PhoneShop
{
    public partial class PhoneList : Form
    {
        public PhoneList()
        {
            InitializeComponent();
        }

        private void phone_load(object sender, EventArgs e)
        {
            Manufacturer();
            ShowList();
        }

        private void ShowList()
        {
            
            int number = listview.RowCount;
            txtdem.Text = number.ToString();
        }

        void Manufacturer()
        {
            PhoneShopAppEntities db = new PhoneShopAppEntities();
            cbxhangsx.DataSource = db.manufacturers.ToList();
            cbxhangsx.ValueMember = "ID";
            cbxhangsx.DisplayMember = "Name";
            cbxhangsx.SelectedValue = 1;
        }

        void Product(int ID)
        {
            PhoneShopAppEntities db = new PhoneShopAppEntities();
            listview.DataSource = db.products.Where(b => b.Manufacturer_ID == ID).ToList();
            listview.Columns["ID"].Visible = false;
            listview.Columns["Manufacturer"].Visible = false;
            listview.Columns["Manufacturer_ID"].Visible = false;
        }

        private void cbxhangsx_SelectedValueChanged(object sender, EventArgs e)
        {
            var temp = cbxhangsx.SelectedValue;
            int ID = 0;
            int.TryParse(temp.ToString(), out ID);
            if (ID != 0)
            {
                Product(ID);
                ShowList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listview.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var row = listview.SelectedRows[0];
                    var cell = row.Cells["ID"];
                    int ID = (int)cell.Value;
                    PhoneShopAppEntities db = new PhoneShopAppEntities();
                    product bk = db.products.Single(b => b.ID == ID);
                    db.products.Remove(bk);
                    db.SaveChanges();
                    Product((int)cbxhangsx.SelectedValue);
                    ShowList();
                }
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            this.Manufacturer();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PhoneShop fr = new PhoneShop();
            fr.ShowDialog();
            Product((int)cbxhangsx.SelectedValue);
            ShowList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listview.SelectedRows.Count == 1)
            {
                var row = listview.SelectedRows[0];
                var cell = row.Cells["ID"];
                int ID = (int)cell.Value;
                PhoneShop edit = new PhoneShop(ID);
                edit.ShowDialog();
                Product((int)cbxhangsx.SelectedValue);
                ShowList();
            }
        }
    }
}
