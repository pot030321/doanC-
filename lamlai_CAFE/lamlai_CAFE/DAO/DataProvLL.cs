using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DAO
{
    public class DataProvLL
    {
        private static DataProvLL instance;

        private string connectionSTR = " Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True ";

        public static DataProvLL Instance
        {
            get { if (instance == null) instance = new DataProvLL(); return DataProvLL.instance; }
            private set => instance = value;
        }

        private DataProvLL() { }

        public DataTable ExecuteQuery(string query, string[] parameter = null)
        {

            //đổ dữ liệu
            DataTable data = new DataTable();

            //tạo kết nối
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mở kết nối 
                connection.Open();

                //thực thi câu query(truy vấn)
                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@userName", id);

                if(parameter != null)
                {
                    string[] listPars = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPars)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }



                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                connection.Close();
            }



            return data;
        }

        public int ExecuteNonQuery(string query, string[] parameter = null)
        {

            int data = 0;

            //tạo kết nối
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mở kết nối 
                connection.Open();

                //thực thi câu query(truy vấn)
                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@userName", id);

                if (parameter != null)
                {
                    string[] listPars = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPars)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, string[] parameter = null)
        {//tra ra ô đầu tiên trong Dataset

            object data = 0;

            //tạo kết nối
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mở kết nối 
                connection.Open();

                //thực thi câu query(truy vấn)
                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@userName", id);

                if (parameter != null)
                {
                    string[] listPars = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPars)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
