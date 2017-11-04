using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Gnote.Interface;
using Gnote.Model;

namespace Gnote.Controller
{
    class Notebook : INotebook
    {
        //创建笔记本
        public void createNotebook(string notebookName)
        {
            //实例化Notebook的模型类，通过模型创建笔记本
            new MNotebook().create_notebook(notebookName);
        }

        public MySqlDataReader listNotebook()
        {
            MNotebook mnotebook = new MNotebook();
            MySqlDataReader reader = mnotebook.list_notebook();
            return reader;
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
        //删除笔记本
        public void deleteNotebook(int notebookNo)
        {
            new MNotebook().delete_notebook(notebookNo);
        }
    }
}
