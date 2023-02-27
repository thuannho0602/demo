using System;
using BaiLam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BaiLam.Models
{
    public class DatatProvide
    {
        protected static string _connectionString;
        public static String ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
        protected SqlConnection cn;
        protected SqlDataAdapter da;
        protected SqlConnection cmd;
        protected readonly DataSet dt;
        public DatatProvide()
        {

        }
        public void Connect()
        {
            cn = new SqlConnection(ConnectionString);
            cn.Open();
        }
        public void Disconnect()
        {
            cn.Close();
        }
        public DataTable Qu
       

    }
}