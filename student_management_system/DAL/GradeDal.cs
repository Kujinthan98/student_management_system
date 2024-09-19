using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system.DAL
{
    public class GradeDal
    {

        static SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());

        public static DataTable GetAll()
        {
            //MessageBox.Show("This is Get All grade details");
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM grades";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); 
                dt.Load(dr);
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static void GetId(int id)
        {
            MessageBox.Show("this is Get id from Grade");
        }

        public static void insert(string GradeName, string GradeOrder)
        {
            MessageBox.Show("this is insert by Grade");
        }

        public static void update(string GradeName, string GradeOrder)
        {
            MessageBox.Show("this is update by Grade");
        }

        public static void delete(int id)
        {
            MessageBox.Show("this is delete by Grade");
        }
    }
}
