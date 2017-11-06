using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gnote.Model
{
    class MNote : MysqlBase
    {
        //查询笔记
        public MySqlDataReader list_note()
        {
            string sql = "SELECT * FROM `note`;";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }
        public MySqlDataReader list_note(int notebook_no)
        {
            string sql = "SELECT * FROM `note` WHERE `notebook_no` = " + notebook_no + ";";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }
        //新建笔记
        public void newnote(string notename, DateTime createtime, DateTime modifytime, int hasdelete, int notebook, string content)
        {
            
            string sql = "INSERT INTO `note` (`note_name`,`note_create_time`, `note_modify_time`, `note_has_delete`, `notebook_no`, `note_content`) VALUES ('" + notename + "','" + createtime + "','" + modifytime + "','" + hasdelete + "','" + notebook + "','" + content + "');";

            MysqlBase mysqlbase = new MysqlBase();
            mysqlbase.execute(sql);
            Console.WriteLine("新建笔记插入数据库成功");
        }

        //显示笔记详情
        public MySqlDataReader ShowDetail(int note_no)
        {
            string sql = "SELECT * FROM `note` WHERE `note_no` = '" + note_no + "';";
            return new MysqlBase().query(sql);

        }
    }
}
