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
using System.Globalization;

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
            LoadData();
            LoadLopData();
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
                textBox3.Text = row.Cells["ngaysinhDataGridViewTextBoxColumn"].Value?.ToString();
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
                textBox5.Text = row.Cells["malopDataGridViewTextBoxColumn"].Value?.ToString();
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
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            chkNam.Checked = true;
            chkNu.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoten = textBox2.Text.Trim();
            string ngaysinh = textBox3.Text.Trim();
            string malop = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(ngaysinh) ||
                string.IsNullOrWhiteSpace(malop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Chuyển ngày sinh sang kiểu DateTime với định dạng dd/MM/yyyy
            if (!DateTime.TryParseExact(ngaysinh, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                                        DateTimeStyles.None, out DateTime ngaySinhDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy (ví dụ: 25/12/2000).");
                return;
            }

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
            string ngaysinh = textBox3.Text.Trim();
            string malop = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(ngaysinh) ||
                string.IsNullOrWhiteSpace(malop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!DateTime.TryParseExact(ngaysinh, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                                        DateTimeStyles.None, out DateTime ngaySinhDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy (ví dụ: 25/12/2000).");
                return;
            }

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
        }

        // ====== KHU VỰC QUẢN LÝ LỚP HỌC ======

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
