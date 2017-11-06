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
            Load_treeview();
            Load_note_list();
        }
        /**
         * 左侧导航栏
         *
         * */
         
        //加载左侧导航栏
        public void Load_treeview()
        {
            //添加顶级节点
            TreeNodeTag treenodenotebookroottag = new TreeNodeTag();
            TreeNode notebook_root = new TreeNode("笔记本");
            notebook_root.Name = "notebook_root";
            notebook_root.ContextMenuStrip = contextMenuStrip_notebook_root;
            treenodenotebookroottag.node_type = "notebook_root";
            notebook_root.Tag = treenodenotebookroottag;
            this.treeview_nav.Nodes.Add(notebook_root);

            TreeNodeTag treenodelabelroottag = new TreeNodeTag();
            TreeNode label_root = new TreeNode("标签");
            label_root.Name = "label_root";
            treenodelabelroottag.node_type = "label_root";
            label_root.Tag = treenodelabelroottag;
            this.treeview_nav.Nodes.Add(label_root);

            TreeNodeTag treenodefavouriteroottag = new TreeNodeTag();
            TreeNode facourite_root = new TreeNode("收藏夹");
            facourite_root.Name = "facourite_root";
            treenodefavouriteroottag.node_type = "facourite_root";
            facourite_root.Tag = treenodefavouriteroottag;
            this.treeview_nav.Nodes.Add(facourite_root);

            TreeNodeTag treenodetrashroottag = new TreeNodeTag();
            TreeNode trash_root = new TreeNode("垃圾篓");
            trash_root.Name = "trash_root";
            treenodetrashroottag.node_type = "trash_root";
            trash_root.Tag = treenodetrashroottag;
            this.treeview_nav.Nodes.Add(trash_root);
 
            //添加笔记本
            Notebook notebook = new Notebook();
            MySqlDataReader reader_notebook = notebook.listNotebook();
            while (reader_notebook.Read())
            {
                if (reader_notebook.HasRows)
                {
                    //创建新节点对象
                    TreeNode newnode = new TreeNode(reader_notebook.GetString(1));
                    //创建notebooktag类对象
                    TreeNodeTag treenodenotebooktag = new TreeNodeTag();
                    //给对象赋值
                    treenodenotebooktag.notebook_no = reader_notebook.GetInt32(0);
                    treenodenotebooktag.notebook_name = reader_notebook.GetString(1);
                    treenodenotebooktag.is_default = reader_notebook.GetInt32("notebook_default");
                    treenodenotebooktag.node_type = "notebook";
                    //传给节点
                    newnode.Tag = treenodenotebooktag;
                    if (treenodenotebooktag.is_default == 1)
                    {
                        newnode.BackColor = Color.Silver;
                    }
                    
                    //给节点添加右击菜单
                    newnode.ContextMenuStrip = contextMenuStrip_notebook;
                    //找到父节点
                    TreeNode tnParent = treeview_nav.Nodes["notebook_root"];
                    //添加到父节点
                    tnParent.Nodes.Add(newnode);
                    //Console.WriteLine("编号:" + reader_notebook.GetInt32(0) + "|姓名:" + reader_notebook.GetString(1));
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
            this.Load_treeview();
        }
        // 新建笔记本
        private void NewNotebook_Click(object sender, EventArgs e)
        {
            NewNotebook NewNotebook = new NewNotebook();
            NewNotebook.Show();
        }

        //笔记本右击菜单
        //新建笔记本
        private void 新建笔记本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNotebook NewNotebook = new NewNotebook();
            NewNotebook.Show();
        }

        //笔记本管理器

        //笔记右击菜单
        private void treeview_nav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //右击获取焦点
                treeview_nav.SelectedNode = treeview_nav.GetNodeAt(e.X, e.Y);
            }
            if (e.Button == MouseButtons.Left)
            {
                //左击显示列表
                treeview_nav.SelectedNode = treeview_nav.GetNodeAt(e.X, e.Y);
                TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
                if (treenodenotebooktag.node_type == "notebook")
                {
                    int nodeno = treenodenotebooktag.notebook_no;
                    Load_note_list(nodeno);
                }
            }
        }
        //删除笔记笔记本
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建tag对象
            TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
            //取值
            string nodename = treenodenotebooktag.notebook_name;
            int nodeno = treenodenotebooktag.notebook_no;
            //用控制器删掉
            Controller.Notebook notebookno = new Controller.Notebook();
            notebookno.deleteNotebook(nodeno);
            //刷新
            treeview_nav.Nodes.Clear();
            this.Load_treeview();
        }
        private void 设置为默认笔记本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
            int nodeno = treenodenotebooktag.notebook_no;
            Controller.Notebook notebookno = new Controller.Notebook();
            notebookno.setDefault(nodeno);
            treeview_nav.Nodes.Clear();
            this.Load_treeview();
        }

        //重命名笔记本
        private void ToolStripMenuItem_notebook_Click(object sender, EventArgs e)
        {
            treeview_nav.LabelEdit = true;
            treeview_nav.SelectedNode.BeginEdit();
        }
        private void treeview_nav_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string newTxt = e.Label;//获取新文本
            //string id = e.Node.Text;//获取原来的文本
            TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
            string nodename = treenodenotebooktag.notebook_name;
            int nodeno = treenodenotebooktag.notebook_no;
            Controller.Notebook notebookno = new Controller.Notebook();
            notebookno.renameNotebook(nodeno, newTxt);
            treeview_nav.Nodes.Clear();
            this.Load_treeview();
            treeview_nav.LabelEdit = false;
        }


        /**
         * 中间列表栏
         * 
         * 
         * 
         * */
        //加载笔记列表
        public void Load_note_list()
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote();
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {
                    listBox.Items.Add(new ListBoxItems { Name = reader_note.GetString("note_name"), Value = reader_note.GetInt32("note_no") });
                    listBox.ContextMenuStrip = contextMenuStripListBox;
                    listBox.DisplayMember = "Name";
                }
            }
        }

        public void Load_note_list(int notebook_no)
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote(notebook_no);
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {
                    this.listBox.Items.Add(reader_note.GetString("note_name"));
                }
            }
        }

        //点击笔记
        public void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBox.SelectedIndex = listBox.IndexFromPoint(e.Location);

            }
            if (e.Button == MouseButtons.Left)
            {
                //左击显示列表,显示笔记详情
                ListBoxItems listboxitems = new ListBoxItems();
                listboxitems = this.listBox.SelectedItem as ListBoxItems;
                MySqlDataReader reader_note_detail = new Note().ShowDetail(listboxitems.Value);
                while (reader_note_detail.Read())
                {
                    if (reader_note_detail.HasRows)
                    {
                        textBoxTitle.Text = reader_note_detail.GetString("note_name");
                        richTextBoxEdit.Text = reader_note_detail.GetString("note_content");
                    }
                }
                
            }
        }
        // 点击搜索按钮
        private void search_Click(object sender, EventArgs e)
        {

        }

        //测试按钮
        private void test_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();
            notebook.listNotebook();
        }

        /**
         * 菜单栏
         * 
         * */
        //新建笔记
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击了新建笔记");
            textBoxTitle.Text = "无标题笔记";
            richTextBoxEdit.Text = "";
            new Note().newNote(new Notebook().getDefault());
            //重新加载笔记列表
            Load_note_list();
        }




        /**
         * 状态栏
         * 
         * */

        
    }
    public class TreeNodeTag
    {
        public int notebook_no;
        public string notebook_name;
        public int is_default;
        public string node_type;
    }
    public class ListBoxItems
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _value;  //可以存放其他属性（int型）

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}
