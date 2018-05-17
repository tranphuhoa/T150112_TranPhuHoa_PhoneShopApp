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
            HangSX();
            ShowList();
        }

        private void ShowList()
        {
            int number = listview.RowCount;
            txtdem.Text = number.ToString();
        }

        void HangSX()
        {
            T150112Entities db = new T150112Entities();
            cbxhangsx.DataSource = db.HangSXes.ToList();
            cbxhangsx.ValueMember = "MaHSX";
            cbxhangsx.DisplayMember = "TenHSX";
            cbxhangsx.SelectedValue = 1;
        }

        void SanPham(int ID)
        {
            T150112Entities db = new T150112Entities();
            listview.DataSource = db.SanPhams.Where(b => b.MaHSX == ID).ToList();
            listview.Columns["MaHSX"].Visible = false;
            listview.Columns["TenHSX"].Visible = false;
            listview.Columns["MaSP"].Visible = false;
        }

        private void cbxhangsx_SelectedValueChanged(object sender, EventArgs e)
        {
            // get id from combobox
            var temp = cbxhangsx.SelectedValue;
            int MaSP = 0;
            int.TryParse(temp.ToString(), out MaSP);
            if (MaSP != 0)
            {
                SanPham(MaSP);
                ShowList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            this.ShowList();
        }
    }
}
