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
            string sql = "SELECT * FROM `note` WHERE `note_has_delete`='0';";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }
        public MySqlDataReader list_note_notenook(int notebook_no)
        {
            string sql = "SELECT * FROM `note` WHERE `note_has_delete`='0' AND `notebook_no` = " + notebook_no + ";";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }
        public MySqlDataReader list_note_label(int lable_no)
        {
            string sql = "SELECT * FROM label a JOIN nl b JOIN note c WHERE `note_has_delete`='0' AND  a.label_no =b.label_no AND c.note_no=b.note_no AND b.label_no='" + lable_no + "';";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }
        public MySqlDataReader list_note_trash()
        {
            string sql = "SELECT * FROM `note` WHERE `note_has_delete`='1';";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }
        public MySqlDataReader list_note_favourite()
        {
            string sql = "SELECT * FROM `note` WHERE `note_favourite`='0' AND `note_has_delete`='0';";
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
        }
        //保存笔记
        public void SaveNote(int note_no, string note_name, DateTime note_modify_time, string note_content)
        {
            string sql = "UPDATE `note` SET `note_name`='" + note_name + "', `note_modify_time`='"+note_modify_time+"', `note_content`='" + note_content + "' WHERE (`note_no`='" + note_no + "')";
            new MysqlBase().execute(sql);

        }

        //显示笔记详情
        public MySqlDataReader ShowDetail(int note_no)
        {
            string sql = "SELECT * FROM `note` WHERE `note_no` = '" + note_no + "';";
            return new MysqlBase().query(sql);

        }

        //删除笔记
        public void deleteNote(int note_no)
        {
            string sql = "UPDATE `note` SET `note_has_delete`='1' WHERE (`note_no`='"+note_no+"'); ";
            new MysqlBase().query(sql);
        }
    }
}
