namespace BaiTap4._6_4._7_4._8.Views
{
    partial class FormStudent
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.TextBox txtStudentId, txtFullName, txtAge;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage, btnAdd, btnUpdate, btnDelete, btnExportCSV;
        private System.Windows.Forms.DataGridView dgvStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();

            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(760, 190);
            this.groupBox1.Text = "Cụm nhập liệu Sinh viên";

            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(580, 20);
            this.picAvatar.Size = new System.Drawing.Size(120, 130);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnChooseImage.Location = new System.Drawing.Point(580, 155);
            this.btnChooseImage.Size = new System.Drawing.Size(120, 25);
            this.btnChooseImage.Text = "Chọn ảnh...";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);

            this.cboGender.Location = new System.Drawing.Point(120, 140);
            this.cboGender.Size = new System.Drawing.Size(200, 24);
            this.txtAge.Location = new System.Drawing.Point(120, 105);
            this.txtAge.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.Location = new System.Drawing.Point(120, 70);
            this.txtFullName.Size = new System.Drawing.Size(350, 22);
            this.txtStudentId.Location = new System.Drawing.Point(120, 35);
            this.txtStudentId.Size = new System.Drawing.Size(200, 22);

            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Text = "Giới tính:";
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Text = "Tuổi:";
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Text = "Họ tên:";
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Text = "Mã SV:";

            this.btnAdd.Location = new System.Drawing.Point(12, 215);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(125, 215);
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(238, 215);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnExportCSV.Location = new System.Drawing.Point(632, 215);
            this.btnExportCSV.Size = new System.Drawing.Size(140, 35);
            this.btnExportCSV.Text = "Xuất file CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            this.dgvStudents.Location = new System.Drawing.Point(12, 265);
            this.dgvStudents.Size = new System.Drawing.Size(760, 230);

            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStudent";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.FormStudent_Load);

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }
    }
}