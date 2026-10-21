namespace BaiTap4._6_4._7_4._8.Views
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // Các thành phần UI theo yêu cầu[cite: 1]
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerClock;

        // Menu Items
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuCategory;
        private System.Windows.Forms.ToolStripMenuItem menuManageStudents;
        private System.Windows.Forms.ToolStripMenuItem menuManageProducts;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;

        // ToolStrip Items
        private System.Windows.Forms.ToolStripButton toolBtnStudents;
        private System.Windows.Forms.ToolStripButton toolBtnProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnLoadDataAsync;

        // StatusStrip Items
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusPercent;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnStudents = new System.Windows.Forms.ToolStripButton();
            this.toolBtnProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnLoadDataAsync = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuSystem, this.menuCategory, this.menuWindow });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);

            // menuSystem
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuLogout, this.menuExit });
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Text = "Hệ thống";

            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Text = "Đăng xuất";

            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);

            // menuCategory
            this.menuCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuManageStudents, this.menuManageProducts });
            this.menuCategory.Name = "menuCategory";
            this.menuCategory.Text = "Danh mục";

            this.menuManageStudents.Name = "menuManageStudents";
            this.menuManageStudents.Text = "Quản lý Sinh viên";
            this.menuManageStudents.Click += new System.EventHandler(this.menuManageStudents_Click);

            this.menuManageProducts.Name = "menuManageProducts";
            this.menuManageProducts.Text = "Quản lý Sản phẩm";
            this.menuManageProducts.Click += new System.EventHandler(this.menuManageProducts_Click);

            // menuWindow
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuCascade, this.menuTileHorizontal, this.menuTileVertical });
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Text = "Cửa sổ";

            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Text = "Cascade";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);

            this.menuTileHorizontal.Name = "menuTileHorizontal";
            this.menuTileHorizontal.Text = "Tile Horizontal";
            this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);

            this.menuTileVertical.Name = "menuTileVertical";
            this.menuTileVertical.Text = "Tile Vertical";
            this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);

            // toolStrip1
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolBtnStudents, this.toolBtnProducts, this.toolStripSeparator1, this.toolBtnLoadDataAsync });
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 27);

            // toolBtnStudents
            this.toolBtnStudents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnStudents.Name = "toolBtnStudents";
            this.toolBtnStudents.Text = "🎓 Sinh viên";
            this.toolBtnStudents.Click += new System.EventHandler(this.menuManageStudents_Click);

            // toolBtnProducts
            this.toolBtnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnProducts.Name = "toolBtnProducts";
            this.toolBtnProducts.Text = "📦 Sản phẩm";
            this.toolBtnProducts.Click += new System.EventHandler(this.menuManageProducts_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);

            // toolBtnLoadDataAsync
            this.toolBtnLoadDataAsync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnLoadDataAsync.Name = "toolBtnLoadDataAsync";
            this.toolBtnLoadDataAsync.Text = "⚡ Tải dữ liệu (Async)";
            this.toolBtnLoadDataAsync.Click += new System.EventHandler(this.toolBtnLoadDataAsync_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusUser, this.lblStatusMessage, this.statusProgressBar, this.lblStatusPercent, this.lblStatusTime });
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 26);

            // lblStatusUser
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(150, 20);
            this.lblStatusUser.Text = "Tài khoản:";

            // lblStatusMessage
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(200, 20);
            this.lblStatusMessage.Text = "Trạng thái...";
            this.lblStatusMessage.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);

            // statusProgressBar
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(150, 18);
            this.statusProgressBar.Margin = new System.Windows.Forms.Padding(20, 4, 0, 4);

            // lblStatusPercent
            this.lblStatusPercent.Name = "lblStatusPercent";
            this.lblStatusPercent.Size = new System.Drawing.Size(30, 20);
            this.lblStatusPercent.Text = "";

            // lblStatusTime
            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(415, 20);
            this.lblStatusTime.Spring = true;
            this.lblStatusTime.Text = "Thời gian";
            this.lblStatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // timerClock
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // FormMain
            this.ClientSize = new System.Drawing.Size(1008, 676);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng Dụng Quản Lý (MDI & Async)";
            this.Load += new System.EventHandler(this.FormMain_Load);

            this.menuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}