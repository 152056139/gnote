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

        //列出标签列表
        public MySqlDataReader list_label()
        {
            string sql = "SELECT * FROM `label`;";
            MysqlBase mysqlbase = new MysqlBase();
            MySqlDataReader reader = mysqlbase.query(sql);
            return reader;
        }

        //修改标签
    }
}
