using BaiTap4._6_4._7_4._8.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4._6_4._7_4._8.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Thiết lập thuộc tính IsMdiContainer = true cho Form chính
            this.IsMdiContainer = true;

            // Khởi động đồng hồ và cập nhật tên người dùng đang đăng nhập
            timerClock.Start();
            lblStatusUser.Text = "Tài khoản: Lương Quốc Cường";
            lblStatusMessage.Text = "Hệ thống sẵn sàng";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            // Hiển thị thời gian hệ thống
            lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // ================= QUẢN LÝ FORM CON (MDI CHILD) =================

        // Thuật toán kiểm tra Form con khi mở
        private void OpenOrActivateForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    // Nếu Form đã mở thì chỉ thực hiện kích hoạt (Activate)
                    child.Activate();
                    return;
                }
            }
            // Nếu Form chưa mở thì tiến hành khởi tạo và hiển thị
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.Show();
        }

        // Cơ chế truyền thông điệp để Form con cập nhật văn bản lên StatusStrip của Form cha
        public void UpdateStatusMessage(string message)
        {
            lblStatusMessage.Text = message;
        }

        // ================= SỰ KIỆN MENU =================

        private void menuManageStudents_Click(object sender, EventArgs e) => OpenOrActivateForm<FormStudent>();
        private void menuManageProducts_Click(object sender, EventArgs e) => OpenOrActivateForm<FormProduct>();
        private void menuExit_Click(object sender, EventArgs e) => Application.Exit();

        // Sắp xếp các cửa sổ con
        private void menuCascade_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);
        private void menuTileHorizontal_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);
        private void menuTileVertical_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);


        // ================= BÀI 4.8: BẤT ĐỒNG BỘ (ASYNC/AWAIT) =================

        private async void toolBtnLoadDataAsync_Click(object sender, EventArgs e)
        {
            // Tự động khóa nút bấm nạp dữ liệu để tránh kích hoạt trùng lặp
            toolBtnLoadDataAsync.Enabled = false;
            lblStatusMessage.Text = "Đang nạp dữ liệu...";
            statusProgressBar.Value = 0;
            lblStatusPercent.Text = "0%";

            // Đối tượng IProgress<T> để truyền phần trăm tiến trình về UI Thread
            var progress = new Progress<int>(percent =>
            {
                statusProgressBar.Value = percent;
                lblStatusPercent.Text = $"{percent}%";
            });

            // Sử dụng khối try...catch...finally
            try
            {
                // Nạp dữ liệu danh sách sinh viên dạng bất đồng bộ
                List<Student> data = await LoadStudentDataAsync(progress);
                UpdateStatusMessage($"Đã nạp xong {data.Count} sinh viên.");

                // Hiển thị thông báo hoàn tất
                MessageBox.Show("Nạp dữ liệu hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatusMessage("Lỗi nạp dữ liệu.");
            }
            finally
            {
                // Mở lại nút bấm ngay sau khi tiến trình kết thúc
                toolBtnLoadDataAsync.Enabled = true;
                statusProgressBar.Value = 0;
                lblStatusPercent.Text = "";
            }
        }

        // Sử dụng Task.Run() kết hợp với await để giả lập tác vụ nạp dữ liệu lớn
        private Task<List<Student>> LoadStudentDataAsync(IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                var list = new List<Student>();
                int totalSteps = 100;
                for (int i = 1; i <= totalSteps; i++)
                {
                    // Sử dụng Thread.Sleep trong tiến trình ngầm
                    Thread.Sleep(30);
                    list.Add(new Student { StudentId = "SV" + i, FullName = "Sinh viên " + i });

                    // Cập nhật phần trăm tiến trình
                    progress?.Report((i * 100) / totalSteps);
                }
                return list;
            });
        }
    }
}