using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace Dict
{
    class conn
    {
        //用于连接数据库的配置
        private string myconn = "Data Source=localhost/Dict;User ID=kasui;PassWord=CxyXxt626525";

        //查
        public DataTable ExecuteQuery(string sqlStr)
        {
            OracleConnection conn = new OracleConnection(myconn);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlStr,conn);
            DataTable dt = new DataTable();
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            oda.Fill(dt);
            conn.Close();
            return dt;
        }

        //增删改
        public int ExecuteUpdate(string sqlStr)
        {
            OracleConnection conn = new OracleConnection(myconn);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlStr,conn);
            int rst = 0;
            rst = cmd.ExecuteNonQuery();
            conn.Close();
            return rst;
        }

        //管理员登录
        public int ExecuteLogin(string sqlStr)
        {
            OracleConnection conn = new OracleConnection(myconn);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlStr, conn);
            DataSet ds = new DataSet();
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = cmd;
            int rst = 0;
            rst = oda.Fill(ds);
            conn.Close();
            return rst;
        }

        //调用存储过程
        public string ExecutePrc(string prc,string cs)
        {
            OracleConnection conn = new OracleConnection(myconn);
            OracleCommand cmd = new OracleCommand(prc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter op = new OracleParameter(cs, OracleType.Cursor);
            op.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(op);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            string rst = "";
            rst = dt.Rows[0][0].ToString();
            conn.Close();
            return rst;
        }
    }
}
