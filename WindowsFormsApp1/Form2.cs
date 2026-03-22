using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ApplyModernUi();
            LoadData();
            LoadLopData();
            LoadLopCombo();
        }

        private void ApplyModernUi()
        {
            var bg = Color.FromArgb(237, 242, 247);
            var surface = Color.White;
            var textMuted = Color.FromArgb(71, 85, 105);
            var accent = Color.FromArgb(37, 99, 235);
            var accentHover = Color.FromArgb(29, 78, 216);
            var danger = Color.FromArgb(220, 38, 38);
            var dangerHover = Color.FromArgb(185, 28, 28);
            var border = Color.FromArgb(226, 232, 240);

            BackColor = bg;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Text = "Quản lý sinh viên";

            tabControl1.Padding = new Point(8, 4);
            tabPageSinhVien.BackColor = bg;
            tabPageLopHoc.BackColor = bg;

            StyleDataGridView(dataGridView1);
            StyleDataGridView(dgvLop);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.DataPropertyName == "ngaysinh")
                    col.DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            foreach (Control c in GetAllControls(this))
            {
                if (c is Label lbl && lbl.Name != "lblTimKiem" && lbl.Name != "lblTimKiemLop")
                {
                    lbl.ForeColor = textMuted;
                    if (lbl.Font.Style != FontStyle.Bold)
                        lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
                if (c is RadioButton rb)
                {
                    rb.ForeColor = textMuted;
                    rb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
                if (c is TextBox tb)
                {
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.BackColor = surface;
                    tb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
                if (c is ComboBox cb)
                {
                    cb.FlatStyle = FlatStyle.Standard;
                    cb.BackColor = surface;
                }
                if (c is DateTimePicker dtp)
                {
                    dtp.CalendarForeColor = textMuted;
                }
                if (c is GroupBox gb)
                {
                    gb.ForeColor = textMuted;
                    gb.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
                }
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    btn.Height = Math.Max(btn.Height, 30);
                    btn.Padding = new Padding(10, 2, 10, 2);

                    string t = btn.Text ?? "";
                    if (t.IndexOf("Xóa", StringComparison.Ordinal) >= 0)
                    {
                        btn.BackColor = danger;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.MouseOverBackColor = dangerHover;
                    }
                    else if (t.IndexOf("Làm mới", StringComparison.Ordinal) >= 0 || t.IndexOf("Tìm", StringComparison.Ordinal) >= 0)
                    {
                        btn.BackColor = Color.FromArgb(241, 245, 249);
                        btn.ForeColor = textMuted;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.FlatAppearance.BorderColor = border;
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 232, 240);
                    }
                    else
                    {
                        btn.BackColor = accent;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.MouseOverBackColor = accentHover;
                    }
                }
            }

            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimKiem.ForeColor = Color.FromArgb(30, 41, 59);
            lblTimKiemLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimKiemLop.ForeColor = Color.FromArgb(30, 41, 59);
        }

        private static IEnumerable<Control> GetAllControls(Control root)
        {
            foreach (Control c in root.Controls)
            {
                yield return c;
                foreach (Control child in GetAllControls(c))
                    yield return child;
            }
        }

        private static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(248, 250, 252);
            dgv.GridColor = Color.FromArgb(226, 232, 240);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeight = 38;
            dgv.RowTemplate.Height = 28;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
        }

        private void LoadLopCombo()
        {
            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT malop, tenlop FROM tbl_lophoc ORDER BY tenlop";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboLop.DisplayMember = "tenlop";
                        cboLop.ValueMember = "malop";
                        cboLop.DataSource = dt;
                        cboLop.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách lớp (combo): " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tìm kiếm theo tên sinh viên
            string keyword = textBox1.Text.Trim();
            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT id, tensinhvien, ngaysinh, gioitinh, malop 
                                     FROM tbl_sinhvien
                                     WHERE tensinhvien LIKE @keyword";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["tensinhvienDataGridViewTextBoxColumn"].Value?.ToString();
                object nsVal = row.Cells["ngaysinhDataGridViewTextBoxColumn"].Value;
                if (nsVal != null && nsVal != DBNull.Value)
                {
                    if (nsVal is DateTime dtNs)
                        dtpNgaySinh.Value = dtNs;
                    else if (DateTime.TryParse(nsVal.ToString(), out DateTime parsedNs))
                        dtpNgaySinh.Value = parsedNs;
                }
                var gioiTinhVal = row.Cells["gioitinhDataGridViewCheckBoxColumn"].Value;
                bool isNam = false;
                if (gioiTinhVal != null)
                {
                    string s = gioiTinhVal.ToString();
                    if (s == "True" || s == "1" || s.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                    {
                        isNam = true;
                    }
                }
                chkNam.Checked = isNam;
                chkNu.Checked = !isNam;
                object malopVal = row.Cells["malopDataGridViewTextBoxColumn"].Value;
                if (malopVal != null && malopVal != DBNull.Value && int.TryParse(malopVal.ToString(), out int malop))
                {
                    try
                    {
                        cboLop.SelectedValue = malop;
                    }
                    catch
                    {
                        cboLop.SelectedIndex = -1;
                    }
                }
                else
                {
                    cboLop.SelectedIndex = -1;
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang xử lý ở cột giới tính
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "gioitinh")
            {
                if (e.Value != null)
                {
                    // Ép kiểu giá trị về boolean hoặc so sánh chuỗi
                    if (e.Value.ToString() == "True" || e.Value.ToString() == "1")
                    {
                        e.Value = "Nam";
                    }
                    else
                    {
                        e.Value = "Nữ";
                    }
                    e.FormattingApplied = true; // Xác nhận đã xử lý xong định dạng
                }
            }
        }

        private void ClearInputs()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Today;
            cboLop.SelectedIndex = -1;
            chkNam.Checked = true;
            chkNu.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoten = textBox2.Text.Trim();
            DateTime ngaySinhDate = dtpNgaySinh.Value.Date;

            if (string.IsNullOrWhiteSpace(hoten) || cboLop.SelectedValue == null || cboLop.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn lớp.");
                return;
            }

            int malop = Convert.ToInt32(cboLop.SelectedValue);

            if (!chkNam.Checked && !chkNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính Nam hoặc Nữ.");
                return;
            }

            int gioitinh = chkNam.Checked ? 1 : 0;

            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO tbl_sinhvien (tensinhvien, ngaysinh, gioitinh, malop)
                                     VALUES (@ten, @ngaysinh, @gioitinh, @malop)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ten", hoten);
                        cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaySinhDate;
                        cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@malop", malop);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm sinh viên thành công.");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm sinh viên: " + ex.Message);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
                return;
            }

            object idValue = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value;
            if (idValue == null)
            {
                MessageBox.Show("Không xác định được ID sinh viên.");
                return;
            }

            int id = Convert.ToInt32(idValue);
            string hoten = textBox2.Text.Trim();
            DateTime ngaySinhDate = dtpNgaySinh.Value.Date;

            if (string.IsNullOrWhiteSpace(hoten) || cboLop.SelectedValue == null || cboLop.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn lớp.");
                return;
            }

            int malop = Convert.ToInt32(cboLop.SelectedValue);

            if (!chkNam.Checked && !chkNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính Nam hoặc Nữ.");
                return;
            }

            int gioitinh = chkNam.Checked ? 1 : 0;

            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE tbl_sinhvien
                                     SET tensinhvien = @ten,
                                         ngaysinh = @ngaysinh,
                                         gioitinh = @gioitinh,
                                         malop = @malop
                                     WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ten", hoten);
                        cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaySinhDate;
                        cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@malop", malop);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật sinh viên thành công.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật sinh viên: " + ex.Message);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }

            object idValue = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value;
            if (idValue == null)
            {
                MessageBox.Show("Không xác định được ID sinh viên.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            int id = Convert.ToInt32(idValue);
            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"DELETE FROM tbl_sinhvien WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa sinh viên thành công.");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message);
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
            LoadLopData();
            LoadLopCombo();
        }

      

        private void LoadLopData()
        {
            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT malop, tenlop FROM tbl_lophoc";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvLop.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
                }
            }
        }

        private void ClearLopInputs()
        {
            txtMaLop.Text = string.Empty;
            txtTenLop.Text = string.Empty;
            txtSearchLop.Text = string.Empty;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["malopLopColumn"].Value?.ToString();
                txtTenLop.Text = row.Cells["tenlopLopColumn"].Value?.ToString();
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenlop = txtTenLop.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenlop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp.");
                return;
            }

            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Giả định malop là ID tự tăng, chỉ lưu tên lớp
                    string query = @"INSERT INTO tbl_lophoc (tenlop) VALUES (@tenlop)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenlop", tenlop);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm lớp học thành công.");
                    LoadLopData();
                    LoadLopCombo();
                    ClearLopInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm lớp học: " + ex.Message);
                }
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa.");
                return;
            }

            string tenlop = txtTenLop.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenlop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp.");
                return;
            }

            if (!int.TryParse(txtMaLop.Text, out int malop))
            {
                MessageBox.Show("Mã lớp không hợp lệ.");
                return;
            }

            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE tbl_lophoc SET tenlop = @tenlop WHERE malop = @malop";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenlop", tenlop);
                        cmd.Parameters.AddWithValue("@malop", malop);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật lớp học thành công.");
                    LoadLopData();
                    LoadLopCombo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật lớp học: " + ex.Message);
                }
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa.");
                return;
            }

            if (!int.TryParse(txtMaLop.Text, out int malop))
            {
                MessageBox.Show("Mã lớp không hợp lệ.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"DELETE FROM tbl_lophoc WHERE malop = @malop";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@malop", malop);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa lớp học thành công.");
                    LoadLopData();
                    LoadLopCombo();
                    ClearLopInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp học: " + ex.Message);
                }
            }
        }

        private void btnReloadLop_Click(object sender, EventArgs e)
        {
            ClearLopInputs();
            LoadLopData();
            LoadLopCombo();
        }

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchLop.Text.Trim();
            string connString = @"Data Source=DESKTOP-L5410I7;Initial Catalog=quanlysinhvien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT malop, tenlop FROM tbl_lophoc WHERE tenlop LIKE @keyword";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvLop.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm lớp: " + ex.Message);
                }
            }
        }
    }
}
