using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GYMAPPLICTION
{
    internal class DataHandler
    {
        public DataHandler() { }

        static string connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
         
        public void create(string username,string password)
        {
            string query = $"INSERT INTO login WHERE Username='" + username + "'And password='" + password + "'";
            conn = new SqlConnection(connect);
            conn.Open();
            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("details created!!");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("details not created"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void update(string username,string password)
        {
            string query = $"UPDATE login SET Username='" + username + "'And password='" + password + "'";
            conn = new SqlConnection(connect);
            conn.Open();
            command= new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery ();
                System.Windows.Forms.MessageBox.Show(" Updated");
            }
            catch ( Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Not Updated"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void clear(string username,string password)
        {
            string query = $"DELETE FROM login WHERE Username='" + username + "'And password='" + password + "'";
            conn = new SqlConnection(connect);
            conn.Open();
            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(" Deleted");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Not Deleted" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public DataTable Read(string username,string password)
        {
            string query = $"SELECT*FROM login WHERE Username='" + username + "'And password='" + password + "' ";
            conn = new SqlConnection(connect);
            adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void Register(int ProgramID,string Programname,string Description,string Instructor,string Schedule,string Duration,int Capacity)
        {
            string query = $"INSERT INTO Program VALUES('{ProgramID}','{Programname}','{Description}','{Instructor}','{Schedule}','{Duration}','{Capacity}'";
            conn = new SqlConnection(connect);
            conn.Open();
            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("details created!!");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("details not created" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void UPDATE(int ProgramID, string Programname, string Description, string Instructor, string Schedule, string Duration, int Capacity)
        {
            string query = $"UPDATE Program SET Program='{ProgramID}',Programname='{Programname}',Description='{Description}',Instructor='{Instructor}',Schedule='{Schedule}',Duration='{Duration}',Capacity='{Capacity}'";
            conn = new SqlConnection(connect);
            conn.Open();
            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(" Updated");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Not Updated" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}   