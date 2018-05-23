namespace T150112_TranPhuHoa_PhoneShopApp.PhoneShop
{
    partial class PhoneList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtdem = new System.Windows.Forms.TextBox();
            this.listview = new System.Windows.Forms.DataGridView();
            this.lblhangsx = new System.Windows.Forms.Label();
            this.cbxhangsx = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisplay = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.listview)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(219, 47);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 92;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtdem
            // 
            this.txtdem.Location = new System.Drawing.Point(280, 44);
            this.txtdem.Name = "txtdem";
            this.txtdem.Size = new System.Drawing.Size(52, 20);
            this.txtdem.TabIndex = 91;
            // 
            // listview
            // 
            this.listview.AllowUserToAddRows = false;
            this.listview.AllowUserToDeleteRows = false;
            this.listview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listview.Location = new System.Drawing.Point(0, 69);
            this.listview.Name = "listview";
            this.listview.ReadOnly = true;
            this.listview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listview.Size = new System.Drawing.Size(742, 253);
            this.listview.TabIndex = 90;
            this.listview.VirtualMode = true;
            this.listview.AllowUserToAddRowsChanged += new System.EventHandler(this.cbxhangsx_SelectedValueChanged);
            // 
            // lblhangsx
            // 
            this.lblhangsx.AutoSize = true;
            this.lblhangsx.Location = new System.Drawing.Point(12, 47);
            this.lblhangsx.Name = "lblhangsx";
            this.lblhangsx.Size = new System.Drawing.Size(73, 13);
            this.lblhangsx.TabIndex = 89;
            this.lblhangsx.Text = "Manufacturer:";
            // 
            // cbxhangsx
            // 
            this.cbxhangsx.FormattingEnabled = true;
            this.cbxhangsx.Location = new System.Drawing.Point(96, 43);
            this.cbxhangsx.Name = "cbxhangsx";
            this.cbxhangsx.Size = new System.Drawing.Size(102, 21);
            this.cbxhangsx.TabIndex = 88;
            this.cbxhangsx.SelectedIndexChanged += new System.EventHandler(this.cbxhangsx_SelectedValueChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnUpdate,
            this.btnDelete,
            this.btnRefesh,
            this.btnDisplay});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(742, 24);
            this.menuStrip.TabIndex = 87;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(53, 20);
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 20);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 20);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(54, 20);
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(57, 20);
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // PhoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 317);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtdem);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.lblhangsx);
            this.Controls.Add(this.cbxhangsx);
            this.Controls.Add(this.menuStrip);
            this.Name = "PhoneList";
            this.Text = "PhoneList";
            this.Load += new System.EventHandler(this.phone_load);
            ((System.ComponentModel.ISupportInitialize)(this.listview)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtdem;
        private System.Windows.Forms.DataGridView listview;
        private System.Windows.Forms.Label lblhangsx;
        private System.Windows.Forms.ComboBox cbxhangsx;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnRefesh;
        private System.Windows.Forms.ToolStripMenuItem btnDisplay;
    }
}