using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyLoginTheme();
        }

        private void ApplyLoginTheme()
        {
            var bg = Color.FromArgb(237, 242, 247);
            var heading = Color.FromArgb(30, 41, 59);
            var muted = Color.FromArgb(71, 85, 105);
            var accent = Color.FromArgb(37, 99, 235);
            var accentHover = Color.FromArgb(29, 78, 216);

            BackColor = bg;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = heading;
            label1.ForeColor = muted;
            label2.ForeColor = muted;

            txtUsername.Font = Font;
            txtPassword.Font = Font;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;

            StylePrimaryButton(btnLogin, accent, accentHover);
            StyleNeutralButton(btnExit);
            btnExit.Click += (s, e) => Close();
        }

        private static void StylePrimaryButton(Button btn, Color back, Color hover)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = back;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = hover;
        }

        private static void StyleNeutralButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btn.BackColor = Color.FromArgb(241, 245, 249);
            btn.ForeColor = Color.FromArgb(71, 85, 105);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 232, 240);
        }
    }
}
