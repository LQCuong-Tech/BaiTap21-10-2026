namespace BaiTap4._6_4._7_4._8.Views
{
    partial class FormProduct
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;
        private System.Windows.Forms.TextBox txtId, txtName, txtPrice;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd, btnDelete;
        private System.Windows.Forms.DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(650, 140);
            this.groupBox1.Text = "Nhập liệu Sản phẩm";

            this.numQuantity.Location = new System.Drawing.Point(400, 65);
            this.cboCategory.Location = new System.Drawing.Point(100, 100);
            this.txtPrice.Location = new System.Drawing.Point(400, 30);
            this.txtName.Location = new System.Drawing.Point(100, 65);
            this.txtId.Location = new System.Drawing.Point(100, 30);

            this.label5.Location = new System.Drawing.Point(320, 68);
            this.label5.Text = "Số lượng:";
            this.label4.Location = new System.Drawing.Point(320, 33);
            this.label4.Text = "Đơn giá:";
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Text = "Loại SP:";
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Text = "Tên SP:";
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Text = "Mã SP:";

            this.btnAdd.Location = new System.Drawing.Point(12, 160);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnDelete.Location = new System.Drawing.Point(125, 160);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.dgvProducts.Location = new System.Drawing.Point(12, 210);
            this.dgvProducts.Size = new System.Drawing.Size(650, 230);
            this.dgvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProducts_MouseClick); // Context Menu

            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProduct";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.FormProduct_Load);

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}