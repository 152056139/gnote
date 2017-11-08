using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gnote.Model
{
    class MLabel : MysqlBase
    {
        //创建标签

        //删除标签

        public void deleteLabel(int label_no)
        {
            string sql = "DELETE FROM `label` WHERE (`label_no`='" + label_no + "')";
            new MysqlBase().query(sql);
        }
        //列出标签列表
        public MySqlDataReader list_label()
        {
            string sql = "SELECT * FROM `label`;";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }

        //修改标签
        public void renameLabel(int label_no, string new_label_name)
        {
            string sql = "UPDATE `label` SET `label_name`='" + new_label_name + "' WHERE (`label_no`='" + label_no + "');";
        }
    }
}
