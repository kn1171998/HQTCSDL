using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HQTCSDL
{
    class DataConnection
    {
        string conStr;
        SqlCommandBuilder sqlcb;
        SqlDataAdapter da;
        DataTable dt;
        public DataConnection()
        {
            conStr = "Data source = DESKTOP-VORTKLR; Initial Catalog = qlks3lop; Integrated Security = true";
        }
        public SqlConnection getConnection()
        {
            return new SqlConnection(conStr);
        }

        //HÀM TỔNG QUÁT ĐỂ SỬ DỤNG CÂU SELECT TRẢ VỀ 1 BẢNG
        public DataTable getData(string TenBang)
        {
            string query;
            DataTable data;
            SqlConnection con = getConnection();
            try
            {
                con.Open();
                query = "SELECT * FROM " + TenBang;
                da = new SqlDataAdapter(query, con);
                
                dt = new DataTable();
                da.Fill(dt);
                data = dt;
                
            }
            catch (Exception)
            {
                data = null;
            }
            finally
            {
                con.Close();
            }
            return data;
        }
        public List<string> getShowData_of_Table(string query, string table)
        {
            List<string> kq = new List<string>();
            SqlConnection con = getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kq.Add(dr[table].ToString());
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return kq;
        }
        /*//Hàm thêm dữ liệu 
         * tham số truyền vào: tên bảng cần thêm dữ liệu
         *                   : tên list của class lấy dữ liệu
         */
        public bool Insert_Data_KS(string TenBang, List<object> list_of_Table)
        {
            string value = "";
            
            SqlConnection con = getConnection();
            try
            {
                string n = "0";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                foreach (object i in list_of_Table)
                {
                    cmd.Parameters.AddWithValue(n, i);
                    value += "@" + n + ",";
                    n = (int.Parse(n) + 1).ToString();
                }
                string query = "INSERT INTO " + TenBang + " VALUES (" + value;
                query = query.Remove(query.LastIndexOf(',')) + ")";

                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                //----------------------------------------------------------
                //string n = "0";
                //SqlCommand cmd = new SqlCommand();
                //con.Open();
                //foreach (object i in list_of_Table)
                //{
                //    cmd.Parameters.AddWithValue(n, i);
                //   // value += "@" + n + ",";
                //    n = (int.Parse(n) + 1).ToString();
                //}
                ////string query = "INSERT INTO " + TenBang + " VALUES (" + value;
                ////query = query.Remove(query.LastIndexOf(',')) + ")";

                ////cmd.CommandText = query;
                ////cmd.Connection = con;
                ////cmd.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter();
                //da.InsertCommand = cmd;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        /*hàm xóa dữ liệu*/
        public bool Delete_Data_KS(string TenTable, List<object> list_of_Table, string tenMa)
        {
            SqlConnection con = getConnection();
            try
            {                
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("0", list_of_Table[0]);
                string query = "DELETE FROM " + TenTable + " WHERE " + tenMa + " = @0";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {                
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool Update_Data_KS(string tenTable, List<object> list_of_Table, List<object> cot_update)
        {
            SqlConnection con = getConnection();
            string n = "0", value = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                foreach(object i in list_of_Table)
                {
                    cmd.Parameters.AddWithValue(n, i);
                    value += "@" + n + ", ";
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        public bool Update_Fast()
        {
            SqlConnection con = getConnection();
            try
            {
                con.Open();
                sqlcb = new SqlCommandBuilder(da);
                da.Update(dt);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        //public bool Delete_Fast()
        //{
        //    SqlConnection con = getConnection();
        //    try
        //    {
        //        con.Open();
        //        sqlcb = new SqlCommandBuilder(da);
        //        da.d
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
