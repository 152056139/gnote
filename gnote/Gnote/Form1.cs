using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gnote.Dialog;
using Gnote.Controller;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Gnote
{
    public partial class Gnote : Form
    {
        public Gnote()
        {
            InitializeComponent();
            Refresh_treeview();
        }

        //加载左侧导航栏
        public void Refresh_treeview()
        {
            //添加顶级节点
            TreeNode notebook_root = new TreeNode("笔记本");
            notebook_root.Name = "notebook_root";
            notebook_root.ContextMenuStrip = contextMenuStrip_notebook_root;
            this.treeview_nav.Nodes.Add(notebook_root);

            TreeNode label_root = new TreeNode("标签");
            label_root.Name = "label_root";
            this.treeview_nav.Nodes.Add(label_root);

            TreeNode facourite_root = new TreeNode("收藏夹");
            facourite_root.Name = "facourite_root";
            this.treeview_nav.Nodes.Add(facourite_root);

            TreeNode trash_root = new TreeNode("垃圾篓");
            trash_root.Name = "trash_root";
            this.treeview_nav.Nodes.Add(trash_root);
 
            //添加笔记本
            Notebook notebook = new Notebook();
            MySqlDataReader reader_notebook = notebook.listNotebook();
            while (reader_notebook.Read())
            {
                if (reader_notebook.HasRows)
                {
                    TreeNode newnode = new TreeNode(reader_notebook.GetString(1));
                    newnode.ContextMenuStrip = contextMenuStrip_notebook;
                    TreeNode tnParent = treeview_nav.Nodes["notebook_root"];
                    tnParent.Nodes.Add(newnode);
                    Console.WriteLine("编号:" + reader_notebook.GetInt32(0) + "|姓名:" + reader_notebook.GetString(1));
                }
            }
            //添加标签
            Controller.Label label = new Controller.Label();
            MySqlDataReader reader_label = label.list_label();
            while (reader_label.Read())
            {
                if (reader_label.HasRows)
                {
                    TreeNode newnode = new TreeNode(reader_label.GetString(1));
                    TreeNode tnParent = treeview_nav.Nodes["label_root"];
                    tnParent.Nodes.Add(newnode);
                }
            }
        }

        //点击刷新左侧导航栏
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeview_nav.Nodes.Clear();
            this.Refresh_treeview();
        }

        // 点击搜索按钮
        private void search_Click(object sender, EventArgs e)
        {

        }
        // 新建笔记本
        private void NewNotebook_Click(object sender, EventArgs e)
        {
            NewNotebook NewNotebook = new NewNotebook();
            NewNotebook.Show();
        }
        //测试按钮
        private void test_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();
            notebook.listNotebook();
        }


 


    }
}
