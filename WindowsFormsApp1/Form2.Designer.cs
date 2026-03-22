using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

      
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
            this.components = new System.ComponentModel.Container();
            this.tblsinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysinhvienDataSet = new WindowsFormsApp1.quanlysinhvienDataSet();
            this.tbl_sinhvienTableAdapter = new WindowsFormsApp1.quanlysinhvienDataSetTableAdapters.tbl_sinhvienTableAdapter();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.chkNam = new System.Windows.Forms.RadioButton();
            this.chkNu = new System.Windows.Forms.RadioButton();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSinhVien = new System.Windows.Forms.TabPage();
            this.tabPageLopHoc = new System.Windows.Forms.TabPage();
            this.txtSearchLop = new System.Windows.Forms.TextBox();
            this.btnTimKiemLop = new System.Windows.Forms.Button();
            this.lblMaLopLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnReloadLop = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.malopLopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopLopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinSV = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblTimKiemLop = new System.Windows.Forms.Label();
            this.grpLopHoc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblsinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSinhVien.SuspendLayout();
            this.tabPageLopHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblsinhvienBindingSource
            // 
            this.tblsinhvienBindingSource.DataMember = "tbl_sinhvien";
            this.tblsinhvienBindingSource.DataSource = this.quanlysinhvienDataSet;
            // 
            // quanlysinhvienDataSet
            // 
            this.quanlysinhvienDataSet.DataSetName = "quanlysinhvienDataSet";
            this.quanlysinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_sinhvienTableAdapter
            // 
            this.tbl_sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(328, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 23);
            this.textBox1.TabIndex = 2;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(700, 40);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 30);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(20, 252);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(118, 32);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(148, 252);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(118, 32);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(20, 296);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(118, 32);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(148, 296);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(118, 32);
            this.btn_reload.TabIndex = 7;
            this.btn_reload.Text = "Làm mới";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 23);
            this.textBox2.TabIndex = 8;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(20, 40);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(57, 13);
            this.lbl_hoten.TabIndex = 9;
            this.lbl_hoten.Text = "Họ và tên ";
            this.lbl_hoten.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(20, 88);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbl_ngaysinh.TabIndex = 11;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 104);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(248, 23);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Location = new System.Drawing.Point(20, 138);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(48, 13);
            this.lbl_gioitinh.TabIndex = 13;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(20, 156);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(48, 17);
            this.chkNam.TabIndex = 12;
            this.chkNam.TabStop = true;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(110, 156);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(39, 17);
            this.chkNu.TabIndex = 13;
            this.chkNu.TabStop = true;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // lbl_malop
            // 
            this.lbl_malop.AutoSize = true;
            this.lbl_malop.Location = new System.Drawing.Point(20, 190);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(25, 13);
            this.lbl_malop.TabIndex = 15;
            this.lbl_malop.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(20, 206);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(248, 25);
            this.cboLop.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsinhvienBindingSource;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(328, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 420);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tensinhvienDataGridViewTextBoxColumn
            // 
            this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "tensinhvien";
            this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewCheckBoxColumn
            // 
            this.gioitinhDataGridViewCheckBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewCheckBoxColumn.Name = "gioitinhDataGridViewCheckBoxColumn";
            this.gioitinhDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioitinhDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            // 
            // grpThongTinSV
            // 
            this.grpThongTinSV.Controls.Add(this.btn_reload);
            this.grpThongTinSV.Controls.Add(this.btn_xoa);
            this.grpThongTinSV.Controls.Add(this.btn_sua);
            this.grpThongTinSV.Controls.Add(this.btn_Them);
            this.grpThongTinSV.Controls.Add(this.cboLop);
            this.grpThongTinSV.Controls.Add(this.lbl_malop);
            this.grpThongTinSV.Controls.Add(this.chkNu);
            this.grpThongTinSV.Controls.Add(this.chkNam);
            this.grpThongTinSV.Controls.Add(this.lbl_gioitinh);
            this.grpThongTinSV.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinSV.Controls.Add(this.lbl_ngaysinh);
            this.grpThongTinSV.Controls.Add(this.textBox2);
            this.grpThongTinSV.Controls.Add(this.lbl_hoten);
            this.grpThongTinSV.Location = new System.Drawing.Point(16, 16);
            this.grpThongTinSV.Name = "grpThongTinSV";
            this.grpThongTinSV.Size = new System.Drawing.Size(300, 360);
            this.grpThongTinSV.TabIndex = 18;
            this.grpThongTinSV.TabStop = false;
            this.grpThongTinSV.Text = "Thông tin sinh viên";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(328, 20);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(123, 15);
            this.lblTimKiem.TabIndex = 19;
            this.lblTimKiem.Text = "Tìm theo tên sinh viên";
            // 
            // grpLopHoc
            // 
            this.grpLopHoc.Controls.Add(this.btnReloadLop);
            this.grpLopHoc.Controls.Add(this.btnXoaLop);
            this.grpLopHoc.Controls.Add(this.btnSuaLop);
            this.grpLopHoc.Controls.Add(this.btnThemLop);
            this.grpLopHoc.Controls.Add(this.txtTenLop);
            this.grpLopHoc.Controls.Add(this.lblTenLop);
            this.grpLopHoc.Controls.Add(this.txtMaLop);
            this.grpLopHoc.Controls.Add(this.lblMaLopLop);
            this.grpLopHoc.Location = new System.Drawing.Point(16, 16);
            this.grpLopHoc.Name = "grpLopHoc";
            this.grpLopHoc.Size = new System.Drawing.Size(300, 244);
            this.grpLopHoc.TabIndex = 20;
            this.grpLopHoc.TabStop = false;
            this.grpLopHoc.Text = "Thông tin lớp học";
            // 
            // lblTimKiemLop
            // 
            this.lblTimKiemLop.AutoSize = true;
            this.lblTimKiemLop.Location = new System.Drawing.Point(328, 20);
            this.lblTimKiemLop.Name = "lblTimKiemLop";
            this.lblTimKiemLop.Size = new System.Drawing.Size(95, 15);
            this.lblTimKiemLop.TabIndex = 21;
            this.lblTimKiemLop.Text = "Tìm theo tên lớp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSinhVien);
            this.tabControl1.Controls.Add(this.tabPageLopHoc);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 554);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            // 
            // tabPageSinhVien
            // 
            this.tabPageSinhVien.Controls.Add(this.dataGridView1);
            this.tabPageSinhVien.Controls.Add(this.btn_timkiem);
            this.tabPageSinhVien.Controls.Add(this.textBox1);
            this.tabPageSinhVien.Controls.Add(this.lblTimKiem);
            this.tabPageSinhVien.Controls.Add(this.grpThongTinSV);
            this.tabPageSinhVien.Location = new System.Drawing.Point(4, 22);
            this.tabPageSinhVien.Name = "tabPageSinhVien";
            this.tabPageSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSinhVien.Size = new System.Drawing.Size(1102, 528);
            this.tabPageSinhVien.TabIndex = 0;
            this.tabPageSinhVien.Text = "  Quản lý sinh viên  ";
            this.tabPageSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            // 
            // tabPageLopHoc
            // 
            this.tabPageLopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.tabPageLopHoc.Controls.Add(this.dgvLop);
            this.tabPageLopHoc.Controls.Add(this.btnTimKiemLop);
            this.tabPageLopHoc.Controls.Add(this.txtSearchLop);
            this.tabPageLopHoc.Controls.Add(this.lblTimKiemLop);
            this.tabPageLopHoc.Controls.Add(this.grpLopHoc);
            this.tabPageLopHoc.Location = new System.Drawing.Point(4, 22);
            this.tabPageLopHoc.Name = "tabPageLopHoc";
            this.tabPageLopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLopHoc.Size = new System.Drawing.Size(1102, 528);
            this.tabPageLopHoc.TabIndex = 1;
            this.tabPageLopHoc.Text = "  Quản lý lớp học  ";
            // 
            // txtSearchLop
            // 
            this.txtSearchLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchLop.Location = new System.Drawing.Point(328, 44);
            this.txtSearchLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchLop.Name = "txtSearchLop";
            this.txtSearchLop.Size = new System.Drawing.Size(360, 23);
            this.txtSearchLop.TabIndex = 0;
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.Location = new System.Drawing.Point(700, 40);
            this.btnTimKiemLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiemLop.TabIndex = 1;
            this.btnTimKiemLop.Text = "Tìm lớp";
            this.btnTimKiemLop.UseVisualStyleBackColor = true;
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // lblMaLopLop
            // 
            this.lblMaLopLop.AutoSize = true;
            this.lblMaLopLop.Location = new System.Drawing.Point(20, 40);
            this.lblMaLopLop.Name = "lblMaLopLop";
            this.lblMaLopLop.Size = new System.Drawing.Size(46, 13);
            this.lblMaLopLop.TabIndex = 2;
            this.lblMaLopLop.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(20, 58);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(248, 23);
            this.txtMaLop.TabIndex = 3;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(20, 88);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(47, 13);
            this.lblTenLop.TabIndex = 4;
            this.lblTenLop.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(20, 104);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(248, 23);
            this.txtTenLop.TabIndex = 5;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(20, 148);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(118, 32);
            this.btnThemLop.TabIndex = 6;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(148, 148);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(118, 32);
            this.btnSuaLop.TabIndex = 7;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(20, 192);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(118, 32);
            this.btnXoaLop.TabIndex = 8;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnReloadLop
            // 
            this.btnReloadLop.Location = new System.Drawing.Point(148, 192);
            this.btnReloadLop.Name = "btnReloadLop";
            this.btnReloadLop.Size = new System.Drawing.Size(118, 32);
            this.btnReloadLop.TabIndex = 9;
            this.btnReloadLop.Text = "Làm mới";
            this.btnReloadLop.UseVisualStyleBackColor = true;
            this.btnReloadLop.Click += new System.EventHandler(this.btnReloadLop_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopLopColumn,
            this.tenlopLopColumn});
            this.dgvLop.Location = new System.Drawing.Point(328, 82);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(748, 420);
            this.dgvLop.TabIndex = 10;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // malopLopColumn
            // 
            this.malopLopColumn.DataPropertyName = "malop";
            this.malopLopColumn.HeaderText = "Mã lớp";
            this.malopLopColumn.Name = "malopLopColumn";
            // 
            // tenlopLopColumn
            // 
            this.tenlopLopColumn.DataPropertyName = "tenlop";
            this.tenlopLopColumn.HeaderText = "Tên lớp";
            this.tenlopLopColumn.Name = "tenlopLopColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1134, 558);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSinhVien.ResumeLayout(false);
            this.tabPageSinhVien.PerformLayout();
            this.tabPageLopHoc.ResumeLayout(false);
            this.tabPageLopHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        private void LoadData()
        {
            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = @"SELECT id, tensinhvien, ngaysinh, gioitinh, malop FROM tbl_sinhvien";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        #endregion
        private quanlysinhvienDataSet quanlysinhvienDataSet;
        private BindingSource tblsinhvienBindingSource;
        private quanlysinhvienDataSetTableAdapters.tbl_sinhvienTableAdapter tbl_sinhvienTableAdapter;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private TextBox textBox1;
        private Button btn_timkiem;
        private Button btn_Them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_reload;
        private TextBox textBox2;
        private Label lbl_hoten;
        private Label lbl_ngaysinh;
        private DateTimePicker dtpNgaySinh;
        private Label lbl_gioitinh;
        private RadioButton chkNam;
        private RadioButton chkNu;
        private Label lbl_malop;
        private ComboBox cboLop;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioitinhDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private TabControl tabControl1;
        private TabPage tabPageSinhVien;
        private TabPage tabPageLopHoc;
        private TextBox txtSearchLop;
        private Button btnTimKiemLop;
        private Label lblMaLopLop;
        private TextBox txtMaLop;
        private Label lblTenLop;
        private TextBox txtTenLop;
        private Button btnThemLop;
        private Button btnSuaLop;
        private Button btnXoaLop;
        private Button btnReloadLop;
        private DataGridView dgvLop;
        private DataGridViewTextBoxColumn malopLopColumn;
        private DataGridViewTextBoxColumn tenlopLopColumn;
        private GroupBox grpThongTinSV;
        private Label lblTimKiem;
        private Label lblTimKiemLop;
        private GroupBox grpLopHoc;
    }
}