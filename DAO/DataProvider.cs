using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlyquancafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionSTR = "Data Source=DESKTOP-6D634Q5\\SQLEXPRESS;Initial Catalog=QuanLy;Persist Security Info=True;User ID=admin;Password=1234567;";

        public static DataProvider Instance {

            get {if (instance == null) instance = new DataProvider(); return DataProvider.instance;}
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số vào câu lệnh SQL nếu có
                    if (parameter != null)
                    {
                        string[] listParams = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParams)
                        {
                            if (param.Contains("@"))
                            {
                                command.Parameters.AddWithValue(param, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số vào câu lệnh SQL nếu có
                    if (parameter != null)
                    {
                        string[] listParams = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParams)
                        {
                            if (param.Contains("@"))
                            {
                                command.Parameters.AddWithValue(param, parameter[i]);
                                i++;
                            }
                        }
                    }

                   data = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số vào câu lệnh SQL nếu có
                    if (parameter != null)
                    {
                        string[] listParams = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParams)
                        {
                            if (param.Contains("@"))
                            {
                                command.Parameters.AddWithValue(param, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return data;
        }
    }
}
