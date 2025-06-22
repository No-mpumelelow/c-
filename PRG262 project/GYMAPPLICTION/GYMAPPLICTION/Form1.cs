using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYMAPPLICTION
{
    public partial class loginclass : Form
    {
        DataHandler handler = new DataHandler();
        signin sign = new signin();
        public loginclass()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Username, password;

            Username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                string query = "SELECT * FROM login_details WHERE Username='" + txt_username + "'AND password='" + txt_password + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    Username = txt_username.Text;
                    password = txt_password.Text;

                    mainprogram form = new mainprogram();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid login details","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();


            txt_username.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Would you like to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            sign.Username1 = txt_username.Text;
            sign.Password = txt_password.Text;

            handler.create(sign.Username1, sign.Password);
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            sign.Username1 = txt_username.Text;
            sign.Password = txt_password.Text;

            handler.update(sign.Username1, sign.Password);

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
           sign.Username1= txt_username.Text;
            sign.Password = txt_password.Text;

            dgvlogin.DataSource=handler.Read(sign.Username1, sign.Password);
            
        }
    }
}
