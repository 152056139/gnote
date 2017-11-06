using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gnote.Model
{
    class MNotebook
    {
        //新建笔记本
        public void create_notebook(string notebook_name)
        {
            //构建创建笔记本的sql语句
            string sql = "INSERT INTO `notebook` (`notebook_name`) VALUES ('" + notebook_name + "')";
            //实例化一个mysql连接基本对象,然后执行
            MysqlBase mysqlbase = new MysqlBase();
            mysqlbase.execute(sql);
        }

        //查询笔记本
        public MySqlDataReader list_notebook()
        {
            string sql = "SELECT * FROM `notebook`;";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader =  mysqlbase.query(sql);
            return reader;
        }
        //删除笔记本
        public void delete_notebook(int notebook_no)
        {
            string sql = "DELETE FROM `notebook` WHERE (`notebook_no`='" + notebook_no + "');";
            //实例化一个mysql连接基本对象,然后执行
            MysqlBase mysqlbase = new MysqlBase();
            mysqlbase.execute(sql);
        }
        //重命名
        public void renameNotebook(int notebook_no, string new_notebook_name)
        {
            string sql = "UPDATE `notebook` SET `notebook_name`='" + new_notebook_name + "' WHERE (`notebook_no`='" + notebook_no + "');";
            Console.WriteLine(sql);
            MysqlBase mysqlbase = new MysqlBase();
            mysqlbase.execute(sql);
        }
        //设置默认笔记本
        public void setDefault(int notebook_no)
        {
            string sql = "UPDATE `notebook` SET `notebook_default`='0' WHERE `notebook_default`='1';";
            string sql1 = "UPDATE `notebook` SET `notebook_default`='1' WHERE `notebook_no`="+notebook_no+";";
            MysqlBase mysqlbase = new MysqlBase();
            mysqlbase.execute(sql);
            mysqlbase.execute(sql1);
        }
        //获得默认笔记本
        public int getDefault()
        {
            string sql = "SELECT `notebook_no` FROM `notebook` WHERE `notebook_default`='1'";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader =  mysqlbase.query(sql);
            reader.Read();
            if (reader.HasRows)
            {
                return reader.GetInt32("notebook_no");
            }
            else
            {
                return 0;
            }
        }
    }
}
