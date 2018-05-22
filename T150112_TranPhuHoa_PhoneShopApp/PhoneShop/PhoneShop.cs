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
    public partial class PhoneShop : Form
    {
        int ProductID = 0;
        product bkedit = new product();
        PhoneShopAppEntities db = new PhoneShopAppEntities();
        public PhoneShop()
        {
            InitializeComponent();
            Manufacture();
        }

        public PhoneShop(int ID)
        {
            InitializeComponent();
            ProductID = ID;
            Manufacture();
            Product();
        }

        void Manufacture()
        {
            PhoneShopAppEntities db = new PhoneShopAppEntities();
            cbxManufacturer.DataSource = db.manufacturers.ToList();
            cbxManufacturer.DisplayMember = "Name";
            cbxManufacturer.ValueMember = "ID";
        }

        void Product()
        {
            
            bkedit = db.products.Single(b => b.ID == ProductID);
            txtProduct.Text = bkedit.Product_Name;
            txtWarranty.Text = bkedit.Warranty;
            txtPrice.Text = bkedit.Price;
            txtStuation.Text = bkedit.Situation;
            cbxManufacturer.SelectedValue = bkedit.Manufacturer_ID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ProductID == 0)
            {
                try
                {
                    PhoneShopAppEntities db = new PhoneShopAppEntities();
                    product bk = new product();
                    bk.Product_Name = txtProduct.Text;
                    bk.Warranty = txtWarranty.Text;
                    bk.Price = txtPrice.Text;
                    bk.Situation = txtStuation.Text;
                    bk.Manufacturer_ID = (int)cbxManufacturer.SelectedValue;
                    ImageConverter converter = new ImageConverter();
                    byte[] image = (byte[])converter.ConvertTo(pictureBox.Image, typeof(byte[]));
                    product upload = new product();
                    upload.Image = image;
                    bk.Image = image;
                    db.products.Add(bk);
                    db.SaveChanges();
                    MessageBox.Show("Add new product success");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    PhoneShopAppEntities db = new PhoneShopAppEntities();
                    bkedit = db.products.Find(bkedit.ID);
                    bkedit.Product_Name = txtProduct.Text;
                    bkedit.Warranty = txtWarranty.Text;
                    bkedit.Price = txtPrice.Text;
                    bkedit.Situation = txtStuation.Text;
                    bkedit.Manufacturer_ID = (int)cbxManufacturer.SelectedValue;
                    ImageConverter converter = new ImageConverter();
                    byte[] image = (byte[])converter.ConvertTo(pictureBox.Image, typeof(byte[]));
                    product upload = new product();
                    upload.Image = image;
                    bkedit.Image = image;
                    db.Entry(bkedit).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Edit product success");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
                txtImage.Text = open.FileName;
            pictureBox.ImageLocation = open.FileName;
        }
    }
}
