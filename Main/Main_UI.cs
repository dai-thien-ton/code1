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
using WindowsFormsApp1;
using Server;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Design;
using System.CodeDom;


namespace QuanTri_UI
{
    public partial class Main_UI : Form
    {
        private Server_UI server;
        public Main_UI()
        {
            InitializeComponent();
            server = new Server_UI();
        }
        private void reset()
        {
            txtTK_DK.Text = "";
            txtMK_DK.Text = "";
            txtIP.Text = "";
            user.Text = "";
            oldPass.Text = "";
            newPass.Text = "";
        }
        public bool KiemTraTT()
        {

            if (txtIP.Text == "")
            {
                MessageBox.Show("Vui long nhap Ip");
                txtIP.Focus();
                return false;
            }
            if (txtTK_DK.Text == "")
            {
                MessageBox.Show("Vui long nhap tai khoan");
                txtTK_DK.Focus();
                return false;
            }
            if (txtMK_DK.Text == "")
            {
                MessageBox.Show("Vui long nhap mat khau");
                txtMK_DK.Focus();
                return false;
            }
            return true;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text;
            string tk = txtTK_DK.Text;
            string mk = txtMK_DK.Text;
            if (KiemTraTT())
            {
                SqlConnection conn = new SqlConnection(@"Data Source=laptop-qacb40r1;Initial Catalog=DTB_multichat;Integrated Security=True");
                conn.Open();
                string sqlTK = "select trim(Taikhoan) as Taikhoan from dataTaikhoan where Taikhoan ='" + tk + "'";
                SqlCommand Cmd = new SqlCommand(sqlTK, conn);
                Cmd.Connection = conn;
                SqlDataReader Dtr = Cmd.ExecuteReader();
                if (Dtr.Read() == true)
                {
                    MessageBox.Show("Tai khoan da ton tai, vui long nhap tai khoan moi");
                    txtTK_DK.Focus();
                }
                else
                {
                    Dtr.Close();
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "SP_DKTaikhoan";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Ip", SqlDbType.NChar).Value = ip;
                        cmd.Parameters.Add("@Taikhoan", SqlDbType.NChar).Value = tk;
                        cmd.Parameters.Add("@Matkhau", SqlDbType.NChar).Value = mk;
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        reset();
                        MessageBox.Show("Dang ky tai khoan thanh cong");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=laptop-qacb40r1;Initial Catalog=DTB_multichat;Integrated Security=True");
            string userIp = string.Empty;
            if (txtTK.Text == "" || txtPass.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("vui long nhap day du thong tin");
            }
            else {
                try
                {
                    conn.Open();
                    string username = txtTK.Text;
                    string password = txtPass.Text;
                    string name = txtName.Text;
                    string sql = "select rtrim(IP) as IP from dataTaikhoan where Taikhoan = '" + username + "' and Matkhau = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dtr = cmd.ExecuteReader();

                    if (dtr.Read() == true)
                    {
                        userIp = dtr["Ip"].ToString();
                        Client_UI chatform = new Client_UI(userIp,name);
                        chatform.Show();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tai khoan hoac mat khau khong dung");
                        this.txtTK.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connect errors");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Show();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            server.Close();
            server = new Server_UI();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btndoi_Click(object sender, EventArgs e)
        {

            string username = user.Text;
            string password = oldPass.Text;
            string newPassword = newPass.Text;
            if (username == "" || password == "" || newPassword == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QACB40R1;Initial Catalog=multichat;Integrated Security=True;");

                conn.Open();
                try
                {
                    string sql = "select Trim(Taikhoan) as Taikhoan, Trim(Matkhau) as Matkhau   from dataTaikhoan where Taikhoan = '" + username + "' and Matkhau = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Connection = conn;
                    SqlDataReader dtr = cmd.ExecuteReader();

                    if (dtr.Read() == true)
                    {
                        dtr.Close();
                        SqlCommand Cmd = new SqlCommand();
                        Cmd.CommandText = "SP_DoiMK";
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.Add("@Taikhoan", SqlDbType.NChar).Value = username;
                        Cmd.Parameters.Add("@Matkhau", SqlDbType.NChar).Value = newPassword;
                        Cmd.Connection = conn;
                        Cmd.ExecuteNonQuery();
                        conn.Close();
                        reset();
                        MessageBox.Show("Doi mat khau thanh cong");
                    }


                    else
                    {
                        MessageBox.Show("Tai khoan hoac mat khau khong dung");
                        this.txtTK.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connect errors");
                }
            }

        }
    }
}
    

    

