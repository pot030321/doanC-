using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        { 
            get { if (instance == null) instance = new AccountDAO();return instance; }
            set => instance = value; 
        }

        private AccountDAO() { }

        public bool Login(string userName , string passWord)
        {
            string query = "SELECT * FROM ACCOUNT WHERE USERNAME = N'" + userName + "' AND PASSWORDACCOUNT = N'" + passWord + "' ";

            DataTable result = DataProvLL.Instance.ExecuteQuery(query);



            return result.Rows.Count>0;
        }

    }
}
