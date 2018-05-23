﻿using System;
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
    public partial class Details : Form
    {
        public Details(byte[] image)
        {
            InitializeComponent();
            Image = image;
        }

        byte[] Image;

        private void Details_Load(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            pictureBox1.Image = (Image)converter.ConvertFrom(Image);
        }

    }
}
