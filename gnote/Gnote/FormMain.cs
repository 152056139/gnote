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
using System.IO;

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
        #region 左侧导航栏

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
            facourite_root.Name = "favourite_root";
            treenodefavouriteroottag.node_type = "favourite_root";
            facourite_root.Tag = treenodefavouriteroottag;
            this.treeview_nav.Nodes.Add(facourite_root);

            TreeNodeTag treenodetrashroottag = new TreeNodeTag();
            TreeNode trash_root = new TreeNode("垃圾篓");
            trash_root.Name = "trash_root";
            treenodetrashroottag.node_type = "trash_root";
            trash_root.Tag = treenodetrashroottag;
            trash_root.ContextMenuStrip = contextMenuStrip_trash;
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
                    TreeNodeTag treenodenotebooktag = new TreeNodeTag();
                    treenodenotebooktag.no = reader_notebook.GetInt32("notebook_no");
                    treenodenotebooktag.name = reader_notebook.GetString("notebook_name");
                    treenodenotebooktag.is_default = reader_notebook.GetInt32("notebook_default");
                    treenodenotebooktag.node_type = "notebook";
                    newnode.Tag = treenodenotebooktag;
                    newnode.ContextMenuStrip = contextMenuStrip_notebook;
                    //找到父节点
                    if (treenodenotebooktag.is_default == 1)
                    {
                        newnode.ForeColor = Color.Red;
                    }
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
                    TreeNodeTag treenodelabeltag = new TreeNodeTag();
                    treenodelabeltag.no = reader_label.GetInt32("label_no");
                    treenodelabeltag.name = reader_label.GetString("label_name");
                    treenodelabeltag.node_type = "label";
                    newnode.Tag = treenodelabeltag;
                    newnode.ContextMenuStrip = contextMenuStrip_label;
                    TreeNode tnParent = treeview_nav.Nodes["label_root"];
                    tnParent.Nodes.Add(newnode);
                }
            }
            treeview_nav.ExpandAll();
        }



        /////////////////////////////右击左侧导航栏//////////////////////////
        //点击刷新左侧导航栏
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeview_nav.Nodes.Clear();
            this.Load_treeview();
        }
        ///////////////////////////笔记本右击菜单///////////////////////////////
        //新建笔记本
        private void 新建笔记本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNotebook NewNotebook = new NewNotebook();
            NewNotebook.Show();
        }


        ///////////////////////////笔记本右击菜单&左键选中/////////////////////////////////
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
                if (treeview_nav.SelectedNode != null)
                {
                    TreeNodeTag treenodetag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
                    if (treenodetag != null)
                    {
                        if (treenodetag.node_type == "label")
                        {
                            int nodeLabelNo = treenodetag.no;
                            Load_label_list(nodeLabelNo);
                        }
                        else if (treenodetag.node_type == "notebook")
                        {
                            int nodeNotebookNo = treenodetag.no;
                            Load_note_list(nodeNotebookNo);
                        }
                        else if (treenodetag.node_type == "favourite_root")
                        {
                            int nodeNotebookNo = treenodetag.no;
                            Load_favourite_list();
                        }
                        else if (treenodetag.node_type == "trash_root")
                        {
                            int nodeNotebookNo = treenodetag.no;
                            Load_trash_list();
                        }

                    }
                }
                
            }
        }
        //删除笔记本
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("删除笔记本将会同时删除笔记本内所有笔记，确认删除?", "删除笔记本", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                //创建tag对象
                TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
                //取值
                string nodename = treenodenotebooktag.name;
                int nodeno = treenodenotebooktag.no;
                //用控制器删掉
                Controller.Notebook notebookno = new Controller.Notebook();
                notebookno.deleteNotebook(nodeno);
                //刷新
                treeview_nav.Nodes.Clear();
                this.Load_treeview();
            }
            else//如果点击“取消”按钮
            {

            }
        }
        //新建笔记
        private void 新建笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "无标题笔记";
            textBoxEdit.Text = "";
            TreeNodeTag treenodetag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
            new Note().newNote(treenodetag.no);
            Load_note_list(treenodetag.no);
            toolStripStatusLabelTip.Text = "笔记新建成功";
        }
        private void 设置为默认笔记本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
            int nodeno = treenodenotebooktag.no;
            Controller.Notebook notebookno = new Controller.Notebook();
            notebookno.setDefault(nodeno);
            treeview_nav.Nodes.Clear();
            this.Load_treeview();
        }

        //重命名笔记本
        private void 重命名ToolStripMenuItem_notebook_Click(object sender, EventArgs e)
        {
            treeview_nav.LabelEdit = true;
            treeview_nav.SelectedNode.BeginEdit();
        }
        private void treeview_nav_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string newtext = e.Label;//获取新文本
            string oldtext = e.Node.Text;//获取原来的文本
            newtext = oldtext;
            if (newtext != oldtext)
            {
                Console.WriteLine("不一样");
                TreeNodeTag treenodenotebooktag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
                //获得节点信息
                string nodename = treenodenotebooktag.name;
                int nodeno = treenodenotebooktag.no;
                //判断类型
                string nodetype = treenodenotebooktag.node_type;
                if (nodetype == "notebook")
                {
                    Controller.Notebook notebookno = new Controller.Notebook();
                    notebookno.renameNotebook(nodeno, newtext);

                }
                else if (nodetype == "label")
                {
                    Controller.Label label = new Controller.Label();
                    label.renameLabel(nodeno, newtext);
                }
                //刷新
                treeview_nav.Nodes.Clear();
                this.Load_treeview();
                treeview_nav.LabelEdit = false;
            }
            else
            {
                Console.WriteLine("一样的");
                treeview_nav.LabelEdit = false;
            }
            
        }

        //////////////////////////////标签右击菜单///////////////////////////////
        //重命名标签
        private void 重命名ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeview_nav.LabelEdit = true;
            treeview_nav.SelectedNode.BeginEdit();
        }

        //删除标签
        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //创建tag对象
            TreeNodeTag treenodelabeltag = treeview_nav.SelectedNode.Tag as TreeNodeTag;
            //取值
            string nodename = treenodelabeltag.name;
            int nodeno = treenodelabeltag.no;
            //用控制器删掉
            Controller.Label label = new Controller.Label();
            label.deleteLabel(nodeno);
            //刷新
            treeview_nav.Nodes.Clear();
            this.Load_treeview();
        }

        #endregion


        #region 中间列表栏

        //笔记右击菜单移动到笔记本
        public void contextMenuStripListBoxNote_move_notebook()
        {

            ((ToolStripDropDownItem)contextMenuStripListBoxNote.Items["移动到ToolStripMenuItem"]).DropDownItems.Clear();
            MySqlDataReader reader = new Notebook().listNotebook();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    ((ToolStripDropDownItem)contextMenuStripListBoxNote.Items["移动到ToolStripMenuItem"]).DropDownItems.Add(reader.GetString("notebook_name"));
                }
            }
        }
        //笔记右击菜单添加标签
        public void contextMenuStripListBoxNote_add_label()
        {
            ((ToolStripDropDownItem)contextMenuStripListBoxNote.Items["标签管理ToolStripMenuItem"]).DropDownItems.Clear();
            MySqlDataReader reader = new Controller.Label().list_label();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    ((ToolStripDropDownItem)contextMenuStripListBoxNote.Items["标签管理ToolStripMenuItem"]).DropDownItems.Add(reader.GetString("label_name"));
                }
            }
        }

        //加载所有笔记列表
        public void Load_note_list()
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote();
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {
                    
                    收藏ToolStripMenuItem.Checked = true;
                    listBox.Items.Add(new ListBoxItems 
                    { 
                        Name = reader_note.GetString("note_name"), 
                        No = reader_note.GetInt32("note_no"),
                        Is_favourite = reader_note.GetInt32("note_favourite")
                    });
                    contextMenuStripListBoxNote_move_notebook();
                    contextMenuStripListBoxNote_add_label();
                    listBox.ContextMenuStrip = contextMenuStripListBoxNote;
                    listBox.DisplayMember = "Name";
                }
            }
        }
        //加载指定笔记本的笔记列表
        public void Load_note_list(int notebook_no)
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote(notebook_no, "notebook");
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {

                    listBox.Items.Add(new ListBoxItems
                    {
                        Name = reader_note.GetString("note_name"),
                        No = reader_note.GetInt32("note_no"),
                        Is_favourite = reader_note.GetInt32("note_favourite")
                    });
                    contextMenuStripListBoxNote_move_notebook();
                    contextMenuStripListBoxNote_add_label();
                    listBox.ContextMenuStrip = contextMenuStripListBoxNote;
                    listBox.DisplayMember = "Name";
                    
                }
            }
        }
        //加载指定标签笔记
        public void Load_label_list(int label_no)
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote(label_no, "label");
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {
                    listBox.Items.Add(new ListBoxItems
                    {
                        Name = reader_note.GetString("note_name"),
                        No = reader_note.GetInt32("note_no"),
                        Is_favourite = reader_note.GetInt32("note_favourite")
                    });
                    contextMenuStripListBoxNote_move_notebook();
                    contextMenuStripListBoxNote_add_label();
                    listBox.ContextMenuStrip = contextMenuStripListBoxNote;
                    listBox.DisplayMember = "Name";
                }
            }
        }
        //加载删除掉的笔记
        public void Load_trash_list()
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote("trash");
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {
                    listBox.Items.Add(new ListBoxItems
                    {
                        Name = reader_note.GetString("note_name"),
                        No = reader_note.GetInt32("note_no"),
                        Is_favourite = reader_note.GetInt32("note_favourite")
                    });
                    listBox.ContextMenuStrip = contextMenuStripListBoxTrash; ;
                    listBox.DisplayMember = "Name";
                }
            }
        }
        //加载收藏的笔记
        public void Load_favourite_list()
        {
            listBox.Items.Clear();
            Note note = new Note();
            MySqlDataReader reader_note = note.listNote("favourite");
            while (reader_note.Read())
            {
                if (reader_note.HasRows)
                {
                    listBox.Items.Add(new ListBoxItems
                    {
                        Name = reader_note.GetString("note_name"),
                        No = reader_note.GetInt32("note_no"),
                        Is_favourite = reader_note.GetInt32("note_favourite")
                    });
                    contextMenuStripListBoxNote_move_notebook();
                    contextMenuStripListBoxNote_add_label();
                    listBox.ContextMenuStrip = contextMenuStripListBoxNote;
                    listBox.DisplayMember = "Name";
                }
            }
        }
        //点击笔记
        public void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBox.SelectedIndex = listBox.IndexFromPoint(e.Location);

                ListBoxItems listboxitems = listBox.SelectedItem as ListBoxItems;
                if (listboxitems != null)
                {
                    //修改收藏是否选中
                    if (listboxitems.Is_favourite == 1)
                    {
                        收藏ToolStripMenuItem.Checked = true;
                    }
                    else
                    {
                        收藏ToolStripMenuItem.Checked = false;
                    }
                }
                else
                {
                    
                }

            }
            if (e.Button == MouseButtons.Left)
            {
                //左击显示列表,显示笔记详情
                ListBoxItems listboxitems = new ListBoxItems();
                listboxitems = this.listBox.SelectedItem as ListBoxItems;
                if (listboxitems != null)
                {
                    MySqlDataReader reader_note_detail = new Note().ShowDetail(listboxitems.No);
                    while (reader_note_detail.Read())
                    {
                        if (reader_note_detail.HasRows)
                        {
                            labelEditNoteNo.Text = reader_note_detail.GetInt32("note_no").ToString();
                            textBoxTitle.Text = reader_note_detail.GetString("note_name");
                            textBoxEdit.Text = reader_note_detail.GetString("note_text");
                        }
                    }
                    reader_note_detail.Close();
                }

            }
        }
        // 点击搜索按钮
        private void search_Click(object sender, EventArgs e)
        {

        }

        #endregion  


        #region 工具栏
        // 新建笔记本
        private void NewNotebook_Click(object sender, EventArgs e)
        {
            NewNotebook NewNotebook = new NewNotebook();
            NewNotebook.Show();
            Load_treeview();
        }
        //保存
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (labelEditNoteNo.Text != "NULL")
            {
                
                new Note().SaveNote(int.Parse(labelEditNoteNo.Text), textBoxTitle.Text, DateTime.Now, textBoxEdit.Text);
                Load_note_list();
                toolStripStatusLabelTip.Text = "保存成功";  
            }
        }
        #endregion



        #region 菜单栏
        //////////////文件
        //新建笔记
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "无标题笔记";
            textBoxEdit.Text = "";
            //添加到默认笔记本
            new Note().newNote(new Notebook().getDefault());
            //显示默认笔记本列表
            Load_note_list(new Notebook().getDefault());
            toolStripStatusLabelTip.Text = "笔记新建成功";
            
        }
        //保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (labelEditNoteNo.Text != "NULL")
            {
                new Note().SaveNote(int.Parse(labelEditNoteNo.Text), textBoxTitle.Text, DateTime.Now, textBoxEdit.Text);
                Load_note_list();
                toolStripStatusLabelTip.Text = "保存成功";
            }
            
        }
        ////////////////////////////////右击笔记///////////////////////////////////
        //删除笔记
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListBoxItems listboxitems = listBox.SelectedItem as ListBoxItems;
            new Note().deleteNote(listboxitems.No);
            Load_note_list();
            toolStripStatusLabelTip.Text = "删除成功";
        }
        private void 收藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxItems listboxitems = listBox.SelectedItem as ListBoxItems;
            if(收藏ToolStripMenuItem.Checked == false)
                new Note().favouriteNote(listboxitems.No);
            else
                new Note().unfavouriteNote(listboxitems.No);
            Load_note_list();
            toolStripStatusLabelTip.Text = "收藏成功";
        }

        #endregion


        #region 状态栏

        #endregion


        #region 右侧编辑栏
        //加粗
        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            Font oldFont = textBoxEdit.SelectionFont;
            Font newFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            textBoxEdit.SelectionFont = newFont;
        }
        #endregion





        

        


    }
    #region treeview节点类
    public class TreeNodeTag
    {
        public int no;
        public string name;
        public int is_default;
        public string node_type;
    }
    #endregion

    #region listboxitem类
    public class ListBoxItems
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _no;  //可以存放其他属性（int型）

        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        private int _is_favourite;

        public int Is_favourite
        {
            get { return _is_favourite; }
            set { _is_favourite = value; }
        }
    }
    #endregion
}
