using BaiTap4._6_4._7_4._8.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTap4._6_4._7_4._8.Views
{
    public partial class FormStudent : Form
    {
        private BindingList<Student> studentList;
        private BindingSource bindingSource;

        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            studentList = new BindingList<Student>();
            bindingSource = new BindingSource { DataSource = studentList };

            cboGender.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            SetupDataGridView();

            // Cấu hình BindingSource 2 chiều (DataBindings.Add)
            txtStudentId.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("SelectedItem", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnValidation);

            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
            NotifyParent("Mở cửa sổ Quản lý Sinh viên thành công.");
            dgvStudents.MouseClick += dgvStudents_MouseClick;
        }

        private void SetupDataGridView()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.DataSource = bindingSource;

            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã SV", Width = 100 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ và Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Age", HeaderText = "Tuổi", Width = 60 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Giới Tính", Width = 80 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AvatarPath", HeaderText = "Đường Dẫn Ảnh", Width = 150 });
        }

        // Truyền thông điệp lên FormMain (MDI Parent)
        private void NotifyParent(string message)
        {
            if (this.MdiParent is FormMain parent)
            {
                parent.UpdateStatusMessage(message);
            }
        }

        // Tự động hiển thị ảnh khi đổi dòng
        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student st && !string.IsNullOrEmpty(st.AvatarPath) && File.Exists(st.AvatarPath))
                picAvatar.ImageLocation = st.AvatarPath;
            else
                picAvatar.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newStudent = new Student
            {
                StudentId = "0",
                FullName = "",
                Age = 0,
                Gender = ""
            };
            bindingSource.Add(newStudent);
            bindingSource.MoveLast();
            txtFullName.Focus();
            NotifyParent("Đang thêm sinh viên mới...");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student st)
            {
                if (string.IsNullOrWhiteSpace(st.StudentId) || studentList.Any(s => s.StudentId == st.StudentId && s != st))
                {
                    MessageBox.Show("Mã SV trống hoặc bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bindingSource.EndEdit();
                dgvStudents.Refresh();
                NotifyParent($"Cập nhật thành công sinh viên: {st.FullName}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null && MessageBox.Show("Xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                NotifyParent("Đã xóa 1 sinh viên.");
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png;*.bmp" }) // OpenFileDialog chọn ảnh
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ((Student)bindingSource.Current).AvatarPath = ofd.FileName;
                    picAvatar.ImageLocation = ofd.FileName;
                    bindingSource.ResetCurrentItem();
                    NotifyParent("Đã cập nhật ảnh Avatar.");
                }
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (studentList.Count == 0) return;
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|*.csv", FileName = "SinhVien.csv" }) // SaveFileDialog xuất file CSV
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Mã SV,Họ Tên,Tuổi,Giới Tính,Đường Dẫn Ảnh");
                    foreach (var st in studentList)
                    {
                        string safeName = st.FullName?.Contains(",") == true ? $"\"{st.FullName}\"" : st.FullName;
                        sb.AppendLine($"{st.StudentId},{safeName},{st.Age},{st.Gender},{st.AvatarPath}");
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true)); // Hỗ trợ tiếng Việt UTF-8
                    NotifyParent($"Xuất file CSV thành công: {Path.GetFileName(sfd.FileName)}");
                    MessageBox.Show("Xuất file thành công!");
                }
            }
        }
        private void dgvStudents_MouseClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem người dùng có đang bấm chuột phải không
            if (e.Button == MouseButtons.Right)
            {
                // Xác định xem chuột phải đang bấm vào dòng số mấy
                var hitTestInfo = dgvStudents.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    // Tự động bôi đen dòng được click chuột phải
                    dgvStudents.ClearSelection();
                    dgvStudents.Rows[hitTestInfo.RowIndex].Selected = true;
                    bindingSource.Position = hitTestInfo.RowIndex; // Đồng bộ với BindingSource
                }

                // Khởi tạo Menu ngữ cảnh
                ContextMenuStrip contextMenu = new ContextMenuStrip();

                // 1. Chức năng: Xóa dòng (gọi lại hàm btnDelete_Click đã viết sẵn)
                contextMenu.Items.Add("Xóa dòng", null, btnDelete_Click);

                // 2. Chức năng: Làm mới dữ liệu
                contextMenu.Items.Add("Làm mới dữ liệu", null, (s, ev) =>
                {
                    dgvStudents.Refresh();
                    dgvStudents.ClearSelection();
                });

                // 3. Chức năng: Xem chi tiết
                contextMenu.Items.Add("Xem chi tiết", null, (s, ev) =>
                {
                    if (bindingSource.Current is Student st)
                    {
                        string detail = $"Mã SV: {st.StudentId}\n" +
                                        $"Họ tên: {st.FullName}\n" +
                                        $"Tuổi: {st.Age}\n" +
                                        $"Giới tính: {st.Gender}";
                        MessageBox.Show(detail, "Chi tiết Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });

                // Hiển thị Menu ngay tại tọa độ mũi tên chuột
                contextMenu.Show(dgvStudents, e.Location);
            }
        }
    }
}