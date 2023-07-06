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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                if (txtMK.Text != txtConfirmMK.Text)
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                    return;
                }

                SqlCommand checkUserCmd = new SqlCommand("SELECT COUNT(*) FROM taikhoan WHERE tentaikhoan = @Username", db.con);
                checkUserCmd.Parameters.AddWithValue("@Username", txtTK.Text);
                int existingUserCount = (int)checkUserCmd.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return; 
                }

                // Tạo SqlCommand để thực hiện truy vấn INSERT vào cơ sở dữ liệu
                SqlCommand insertCmd = new SqlCommand("INSERT INTO taikhoan (tentaikhoan, matkhau) VALUES (@Username, @Userpass)", db.con);

                SqlParameter p1 = new SqlParameter("@Username", SqlDbType.NVarChar);
                p1.Value = txtTK.Text;
                SqlParameter p2 = new SqlParameter("@Userpass", SqlDbType.NVarChar);
                p2.Value = txtMK.Text;

                insertCmd.Parameters.Add(p1);
                insertCmd.Parameters.Add(p2);

                // Thực hiện truy vấn INSERT
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    Form login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                db.CloseConnection();
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Register_Load_1(object sender, EventArgs e)
        {

        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            txtTK.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtMK.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtConfirmMK.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtTK.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txtConfirmMK.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
        }
        private void txtConfirmMK_Click(object sender, EventArgs e)
        {
            txtMK.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtTK.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txtConfirmMK.BackColor = Color.White;
            panel5.BackColor = Color.White;
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Login();
           
            login.FormClosing += (s, args) => this.Show(); 
            login.Opacity = 0; 
            login.Show();

            Timer timer = new Timer();
            timer.Interval = 30; 
            timer.Tick += (s, args) =>
            {
                login.Opacity += 0.1; 
                if (login.Opacity >= 1)
                {
                    timer.Stop();
                    this.Hide();
                }
            };
            timer.Start();
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmMK.UseSystemPasswordChar = false;
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmMK.UseSystemPasswordChar = true;
        }
    }
}
