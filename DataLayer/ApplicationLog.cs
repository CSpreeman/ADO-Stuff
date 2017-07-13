using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ApplicationLog
    {
        public static void Add(string comment)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"AddAppLog";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("comment", System.Data.SqlDbType.NVarChar, 100);
                    p1.Value = comment;

                    cmd.Parameters.Add(p1);

                    int res = cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Add2(string comment)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"AddAppLog2";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("comment", System.Data.SqlDbType.NVarChar, 100);
                    p1.Value = comment;

                    cmd.Parameters.Add(p1);

                    object res = cmd.ExecuteScalar();
                }
            }
        }

        public static void Add3(string comment)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"AddAppLog3";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("comment", System.Data.SqlDbType.NVarChar, 100);
                    p1.Value = comment;

                    cmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("outid", System.Data.SqlDbType.Int);
                    p2.Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.Add(p2);

                    cmd.ExecuteNonQuery();

                    object result = p2.Value;
                }
            }
        }
        //return value
        public static void Add4(string comment)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"AddAppLog4";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("comment", System.Data.SqlDbType.NVarChar, 100);
                    p1.Value = comment;

                    cmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("outid", System.Data.SqlDbType.Int);
                    p2.Direction = System.Data.ParameterDirection.ReturnValue;

                    cmd.Parameters.Add(p2);

                    cmd.ExecuteNonQuery();

                    object result = p2.Value;
                }
            }
        }

        public static void DeleteCommentsForApp(string appName)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DeleteAppLog";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("appName", System.Data.SqlDbType.NVarChar, 100);
                    p1.Value = appName;

                    cmd.Parameters.Add(p1);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateDepartmentName(int departmentId, string newName)
        {
            using (SqlConnection conn = DB.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UpdateDepartmentName";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("id", System.Data.SqlDbType.Int);
                    p1.Value = departmentId;
                    cmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("name", System.Data.SqlDbType.NVarChar, 100);
                    p2.Value = newName;
                    cmd.Parameters.Add(p2);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
