using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DAO
{
    public class DataProvider
    {

        /* tạo sigleton */
        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get {  if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } 
        }

        //TẠO hàng dựng
        private DataProvider() { }




        private string connectionSTR = " Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True ";

        public DataTable ExecuteQuery (string query , object[]  parameter = null)
            //trả ra bảng dữ liệu
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
                //using là cho dù vấn đề gì thì khi kết thúc khối lệnh => dữ liệu được khai báo trong using sẽ tự giải phóng
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null ) 
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara )
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


        public int ExecuteNonQuery(string query, object[] parameter = null)
        //trả ra số dòng thành công hay không
        {
            int data = 0 ; 
            //trả ra mặc định là 0 dòng thành công

            using (SqlConnection connection = new SqlConnection(connectionSTR))
           
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data= command.ExecuteNonQuery();

                connection.Close();

            }

            return data;
        }


        public object ExecuteScalarQuery(string query, object[] parameter = null)
       
        {
            object data = 0;
            //trả ra mặc định là 0 dòng thành công

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            //using là cho dù vấn đề gì thì khi kết thúc khối lệnh => dữ liệu được khai báo trong using sẽ tự giải phóng
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
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
