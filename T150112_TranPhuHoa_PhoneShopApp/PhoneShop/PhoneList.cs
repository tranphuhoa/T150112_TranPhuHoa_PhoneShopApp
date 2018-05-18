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
            // get id from combobox
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
                    // get first rows
                    var row = listview.SelectedRows[0];
                    // get ID cell
                    var cell = row.Cells["ID"];
                    // return ID
                    int ID = (int)cell.Value;
                    // get employees has ID
                    PhoneShopAppEntities db = new PhoneShopAppEntities();
                    product bk = db.products.Single(b => b.ID == ID);
                    //db.DeleteObject(bk);
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
    }
}
