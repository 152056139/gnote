using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectString = "Server=localhost;Database=gnote;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(connectString);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO notebook (notebook_name) VALUE (@name)";
                cmd.Parameters.AddWithValue("@name", "我的第一个笔记本");
                cmd.ExecuteNonQuery();
                Console.WriteLine("执行完了");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
