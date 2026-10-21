using BaiTap4._6_4._7_4._8.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTap4._6_4._7_4._8.Views
{
    public partial class FormProduct : Form
    {
        private BindingList<Product> productList;
        private BindingSource bindingSource;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            productList = new BindingList<Product>();
            bindingSource = new BindingSource { DataSource = productList };

            cboCategory.Items.AddRange(new string[] { "Điện thoại", "Máy tính bảng", "Phụ kiện" });
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            SetupGrid();
            NotifyParent("Mở cửa sổ Quản lý Sản phẩm thành công.");
            dgvProducts.MouseClick += dgvProducts_MouseClick;
        }

        private void SetupGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.DataSource = bindingSource;

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Mã SP", Width = 80 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Tên Sản Phẩm", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Loại", Width = 100 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Đơn Giá", Width = 100 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số Lượng", Width = 80 });
        }

        // Tương tác giao tiếp form cha - con
        private void NotifyParent(string message)
        {
            if (this.MdiParent is FormMain parent)
            {
                parent.UpdateStatusMessage(message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text)) return;

            if (productList.Any(p => p.Id == txtId.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!"); return;
            }

            productList.Add(new Product
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Category = cboCategory.Text,
                Price = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0,
                Quantity = (int)numQuantity.Value
            });
            NotifyParent($"Đã thêm mới sản phẩm: {txtName.Text}");
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            numQuantity.Value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null && MessageBox.Show("Xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                NotifyParent("Đã xóa 1 sản phẩm khỏi danh sách.");
            }
        }

        // Tương tác ContextMenu trên Form con
        private void dgvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Tự động bôi đen dòng được click chuột phải
                var hitTestInfo = dgvProducts.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvProducts.ClearSelection();
                    dgvProducts.Rows[hitTestInfo.RowIndex].Selected = true;
                    bindingSource.Position = hitTestInfo.RowIndex; // Đồng bộ với BindingSource
                }

                ContextMenuStrip contextMenu = new ContextMenuStrip();

                // 1. Chức năng Xóa dòng
                contextMenu.Items.Add("Xóa dòng", null, btnDelete_Click);

                // 2. Chức năng Làm mới dữ liệu
                contextMenu.Items.Add("Làm mới dữ liệu", null, (s, ev) =>
                {
                    dgvProducts.Refresh();
                    dgvProducts.ClearSelection();
                });

                // 3. Chức năng Xem chi tiết
                contextMenu.Items.Add("Xem chi tiết", null, (s, ev) =>
                {
                    if (bindingSource.Current is Product p)
                    {
                        string detail = $"Mã SP: {p.Id}\n" +
                                        $"Tên SP: {p.Name}\n" +
                                        $"Loại: {p.Category}\n" +
                                        $"Đơn giá: {p.Price:C0}\n" +
                                        $"Số lượng: {p.Quantity}";
                        MessageBox.Show(detail, "Chi tiết Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });

                contextMenu.Show(dgvProducts, e.Location);
            }
        }
    }
}