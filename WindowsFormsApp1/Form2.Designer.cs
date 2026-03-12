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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.chkNam = new System.Windows.Forms.RadioButton();
            this.chkNu = new System.Windows.Forms.RadioButton();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSinhVien = new System.Windows.Forms.TabPage();
            this.tabPageLopHoc = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tblsinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSinhVien.SuspendLayout();
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
            this.textBox1.Location = new System.Drawing.Point(398, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(714, 36);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(56, 19);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(27, 343);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(170, 343);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(27, 392);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(170, 392);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(75, 23);
            this.btn_reload.TabIndex = 7;
            this.btn_reload.Text = "Làm mới";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(42, 43);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(57, 13);
            this.lbl_hoten.TabIndex = 9;
            this.lbl_hoten.Text = "Họ và tên ";
            this.lbl_hoten.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(42, 97);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbl_ngaysinh.TabIndex = 11;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 10;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Location = new System.Drawing.Point(42, 148);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(48, 13);
            this.lbl_gioitinh.TabIndex = 13;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(45, 167);
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
            this.chkNu.Location = new System.Drawing.Point(120, 167);
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
            this.lbl_malop.Location = new System.Drawing.Point(42, 202);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(25, 13);
            this.lbl_malop.TabIndex = 15;
            this.lbl_malop.Text = "Lớp";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(45, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 20);
            this.textBox5.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsinhvienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(398, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 380);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tensinhvienDataGridViewTextBoxColumn
            // 
            this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "tensinhvien";
            this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "tensinhvien";
            this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewCheckBoxColumn
            // 
            this.gioitinhDataGridViewCheckBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.HeaderText = "gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.Name = "gioitinhDataGridViewCheckBoxColumn";
            this.gioitinhDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioitinhDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "malop";
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
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
            // 
            // tabPageSinhVien
            // 
            this.tabPageSinhVien.Controls.Add(this.dataGridView1);
            this.tabPageSinhVien.Controls.Add(this.lbl_malop);
            this.tabPageSinhVien.Controls.Add(this.textBox5);
            this.tabPageSinhVien.Controls.Add(this.lbl_gioitinh);
            this.tabPageSinhVien.Controls.Add(this.chkNu);
            this.tabPageSinhVien.Controls.Add(this.chkNam);
            this.tabPageSinhVien.Controls.Add(this.lbl_ngaysinh);
            this.tabPageSinhVien.Controls.Add(this.textBox3);
            this.tabPageSinhVien.Controls.Add(this.lbl_hoten);
            this.tabPageSinhVien.Controls.Add(this.textBox2);
            this.tabPageSinhVien.Controls.Add(this.btn_reload);
            this.tabPageSinhVien.Controls.Add(this.btn_xoa);
            this.tabPageSinhVien.Controls.Add(this.btn_sua);
            this.tabPageSinhVien.Controls.Add(this.btn_Them);
            this.tabPageSinhVien.Controls.Add(this.btn_timkiem);
            this.tabPageSinhVien.Controls.Add(this.textBox1);
            this.tabPageSinhVien.Location = new System.Drawing.Point(4, 22);
            this.tabPageSinhVien.Name = "tabPageSinhVien";
            this.tabPageSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSinhVien.Size = new System.Drawing.Size(1102, 528);
            this.tabPageSinhVien.TabIndex = 0;
            this.tabPageSinhVien.Text = "Quản lý sinh viên";
            this.tabPageSinhVien.UseVisualStyleBackColor = true;
            // 
            // tabPageLopHoc
            // 
            this.tabPageLopHoc.Location = new System.Drawing.Point(4, 22);
            this.tabPageLopHoc.Name = "tabPageLopHoc";
            this.tabPageLopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLopHoc.Size = new System.Drawing.Size(1102, 403);
            this.tabPageLopHoc.TabIndex = 1;
            this.tabPageLopHoc.Text = "Quản lý lớp học";
            this.tabPageLopHoc.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 558);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSinhVien.ResumeLayout(false);
            this.tabPageSinhVien.PerformLayout();
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
        private TextBox textBox3;
        private Label lbl_gioitinh;
        private RadioButton chkNam;
        private RadioButton chkNu;
        private Label lbl_malop;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioitinhDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private TabControl tabControl1;
        private TabPage tabPageSinhVien;
        private TabPage tabPageLopHoc;
    }
}