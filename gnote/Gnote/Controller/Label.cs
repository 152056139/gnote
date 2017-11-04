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
    }
}
