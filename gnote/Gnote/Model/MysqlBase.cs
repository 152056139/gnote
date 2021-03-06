﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gnote.Model
{
    class MysqlBase
    {
        //建立连接
        protected MySqlConnection getMySqlCon()
        {
            String mysqlStr = "Server=localhost;Database=gnote;Uid=root;Pwd=root;pooling=false;CharSet=utf8;port=3306";
            // String mySqlCon = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
            MySqlConnection mysqlconnection = new MySqlConnection(mysqlStr);
            return mysqlconnection;
        }

        //建立sql语句对象
        protected MySqlCommand getSqlCommand(String sql)
        {
            MySqlCommand mySqlCommand = null;
            try
            {
                MySqlConnection mysqlconnection = getMySqlCon();
                mysqlconnection.Open();
                 mySqlCommand = new MySqlCommand(sql, mysqlconnection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return mySqlCommand;
        }

        //查询操作
        public MySqlDataReader query(String sql)
        {
            MySqlCommand mysqlcommand = null;
            MySqlDataReader mysqldatareader = null;
            try
            {
                mysqlcommand = getSqlCommand(sql);
                mysqldatareader = mysqlcommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return mysqldatareader;
            
            /*
            try
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        Console.WriteLine("编号:" + reader.GetInt32(0) + "|姓名:" + reader.GetString(1));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("查询失败了！");
            }
            finally
            {
                reader.Close();
            }*/
        }

        //执行操作
        public void execute(String sql)
        {
            MySqlCommand mysqlcommand = null;
            try
            {
                mysqlcommand = getSqlCommand(sql);
                mysqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                Console.WriteLine("插入数据失败了！" + message);
            }
            finally
            {
                mysqlcommand.Connection.Close();
            }
      
        }
    }
}
