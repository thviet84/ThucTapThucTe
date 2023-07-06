using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM taikhoan WHERE tentaikhoan= @Username AND matkhau= @Userpass", db.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlParameter p1 = new SqlParameter("@Username", SqlDbType.NVarChar);
                p1.Value = txtTK.Text;
                SqlParameter p2 = new SqlParameter("@Userpass", SqlDbType.NVarChar);
                p2.Value = txtMK.Text;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {

                    Form frm2 = new HomePage();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    db.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM taikhoan WHERE tentaikhoan= @Username AND matkhau= @Userpass", db.con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    SqlParameter p1 = new SqlParameter("@Username", SqlDbType.NVarChar);
                    p1.Value = txtTK.Text;
                    SqlParameter p2 = new SqlParameter("@Userpass", SqlDbType.NVarChar);
                    p2.Value = txtMK.Text;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {

                        Form frm2 = new HomePage();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            txtTK.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtMK.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtTK.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form register = new Register();

            register.FormClosing += (s, args) => this.Show();
            register.Opacity = 0;
            register.Show();

            Timer timer = new Timer();
            timer.Interval = 30;
            timer.Tick += (s, args) =>
            {
                register.Opacity += 0.1;
                if (register.Opacity >= 1)
                {
                    timer.Stop();
                    this.Hide();
                }
            };
            timer.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
