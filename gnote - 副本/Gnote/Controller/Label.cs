using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gnote.Model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gnote.Controller
{
    class Label
    {
        //获得label列表
        public MySqlDataReader list_label()
        {
            MLabel mlabel = new MLabel();
            MySqlDataReader reader = mlabel.list_label();
            return reader;
        }

        //删除标签
        public void deleteLabel(int label_no)
        {
            new MLabel().deleteLabel(label_no);
        }

        //重命名标签
        public void renameLabel(int label_no, string new_label_name)
        {
            new MLabel().renameLabel(label_no, new_label_name);
        }
    }
}
