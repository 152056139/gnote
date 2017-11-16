using MySql.Data;

namespace Gnote
{
    partial class Gnote
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gnote));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于GnoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShortCut = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.NewNotebook = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip_treeview_nav = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_notebook_root = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建笔记本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_notebook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重命名ToolStripMenuItem_notebook = new System.Windows.Forms.ToolStripMenuItem();
            this.新建笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.设置为默认笔记本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListBoxNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.移动到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的笔记本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标签管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标签1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标签2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.新建标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.labelEditNoteNo = new System.Windows.Forms.Label();
            this.textBoxEdit = new System.Windows.Forms.RichTextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeview_nav = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip_label = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重命名ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_label_root = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建标签ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_trash = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空垃圾篓ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListBoxTrash = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.彻底删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripShortCut.SuspendLayout();
            this.contextMenuStrip_treeview_nav.SuspendLayout();
            this.contextMenuStrip_notebook_root.SuspendLayout();
            this.contextMenuStrip_notebook.SuspendLayout();
            this.contextMenuStripListBoxNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip_label.SuspendLayout();
            this.contextMenuStrip_label_root.SuspendLayout();
            this.contextMenuStrip_trash.SuspendLayout();
            this.contextMenuStripListBoxTrash.SuspendLayout();
            this.contextMenuStripListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTip});
            this.statusStrip.Location = new System.Drawing.Point(0, 500);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(928, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTip
            // 
            this.toolStripStatusLabelTip.Name = "toolStripStatusLabelTip";
            this.toolStripStatusLabelTip.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabelTip.Text = "就绪";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.toolStripSeparator1,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.关于GnoteToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 关于GnoteToolStripMenuItem
            // 
            this.关于GnoteToolStripMenuItem.Name = "关于GnoteToolStripMenuItem";
            this.关于GnoteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.关于GnoteToolStripMenuItem.Text = "关于Gnote";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStripShortCut
            // 
            this.toolStripShortCut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.NewNotebook});
            this.toolStripShortCut.Location = new System.Drawing.Point(0, 25);
            this.toolStripShortCut.Name = "toolStripShortCut";
            this.toolStripShortCut.Size = new System.Drawing.Size(928, 25);
            this.toolStripShortCut.TabIndex = 3;
            this.toolStripShortCut.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "保存";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // NewNotebook
            // 
            this.NewNotebook.Image = ((System.Drawing.Image)(resources.GetObject("NewNotebook.Image")));
            this.NewNotebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewNotebook.Name = "NewNotebook";
            this.NewNotebook.Size = new System.Drawing.Size(88, 22);
            this.NewNotebook.Text = "新建笔记本";
            this.NewNotebook.Click += new System.EventHandler(this.NewNotebook_Click);
            // 
            // contextMenuStrip_treeview_nav
            // 
            this.contextMenuStrip_treeview_nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip_treeview_nav.Name = "contextMenuStrip_treeview_nav";
            this.contextMenuStrip_treeview_nav.Size = new System.Drawing.Size(101, 26);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // contextMenuStrip_notebook_root
            // 
            this.contextMenuStrip_notebook_root.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建笔记本ToolStripMenuItem});
            this.contextMenuStrip_notebook_root.Name = "contextMenuStrip_notebook_root";
            this.contextMenuStrip_notebook_root.Size = new System.Drawing.Size(137, 26);
            // 
            // 新建笔记本ToolStripMenuItem
            // 
            this.新建笔记本ToolStripMenuItem.Name = "新建笔记本ToolStripMenuItem";
            this.新建笔记本ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建笔记本ToolStripMenuItem.Text = "新建笔记本";
            this.新建笔记本ToolStripMenuItem.Click += new System.EventHandler(this.新建笔记本ToolStripMenuItem_Click);
            // 
            // contextMenuStrip_notebook
            // 
            this.contextMenuStrip_notebook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem_notebook,
            this.新建笔记ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.toolStripSeparator8,
            this.设置为默认笔记本ToolStripMenuItem});
            this.contextMenuStrip_notebook.Name = "contextMenuStrip_notebook";
            this.contextMenuStrip_notebook.Size = new System.Drawing.Size(173, 98);
            // 
            // 重命名ToolStripMenuItem_notebook
            // 
            this.重命名ToolStripMenuItem_notebook.Name = "重命名ToolStripMenuItem_notebook";
            this.重命名ToolStripMenuItem_notebook.Size = new System.Drawing.Size(172, 22);
            this.重命名ToolStripMenuItem_notebook.Text = "重命名";
            this.重命名ToolStripMenuItem_notebook.Click += new System.EventHandler(this.重命名ToolStripMenuItem_notebook_Click);
            // 
            // 新建笔记ToolStripMenuItem
            // 
            this.新建笔记ToolStripMenuItem.Name = "新建笔记ToolStripMenuItem";
            this.新建笔记ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.新建笔记ToolStripMenuItem.Text = "新建笔记";
            this.新建笔记ToolStripMenuItem.Click += new System.EventHandler(this.新建笔记ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(169, 6);
            // 
            // 设置为默认笔记本ToolStripMenuItem
            // 
            this.设置为默认笔记本ToolStripMenuItem.Name = "设置为默认笔记本ToolStripMenuItem";
            this.设置为默认笔记本ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置为默认笔记本ToolStripMenuItem.Text = "设置为默认笔记本";
            this.设置为默认笔记本ToolStripMenuItem.Click += new System.EventHandler(this.设置为默认笔记本ToolStripMenuItem_Click);
            // 
            // contextMenuStripListBoxNote
            // 
            this.contextMenuStripListBoxNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem1,
            this.收藏ToolStripMenuItem,
            this.toolStripSeparator7,
            this.移动到ToolStripMenuItem,
            this.标签管理ToolStripMenuItem});
            this.contextMenuStripListBoxNote.Name = "contextMenuStripListBox";
            this.contextMenuStripListBoxNote.Size = new System.Drawing.Size(153, 120);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // 收藏ToolStripMenuItem
            // 
            this.收藏ToolStripMenuItem.Name = "收藏ToolStripMenuItem";
            this.收藏ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.收藏ToolStripMenuItem.Text = "收藏";
            this.收藏ToolStripMenuItem.Click += new System.EventHandler(this.收藏ToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // 移动到ToolStripMenuItem
            // 
            this.移动到ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的笔记本ToolStripMenuItem});
            this.移动到ToolStripMenuItem.Name = "移动到ToolStripMenuItem";
            this.移动到ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.移动到ToolStripMenuItem.Text = "移动到";
            // 
            // 我的笔记本ToolStripMenuItem
            // 
            this.我的笔记本ToolStripMenuItem.Name = "我的笔记本ToolStripMenuItem";
            this.我的笔记本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.我的笔记本ToolStripMenuItem.Text = "我的笔记本";
            // 
            // 标签管理ToolStripMenuItem
            // 
            this.标签管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标签1ToolStripMenuItem,
            this.标签2ToolStripMenuItem,
            this.toolStripSeparator3,
            this.新建标签ToolStripMenuItem});
            this.标签管理ToolStripMenuItem.Name = "标签管理ToolStripMenuItem";
            this.标签管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.标签管理ToolStripMenuItem.Text = "添加标签";
            // 
            // 标签1ToolStripMenuItem
            // 
            this.标签1ToolStripMenuItem.Name = "标签1ToolStripMenuItem";
            this.标签1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.标签1ToolStripMenuItem.Text = "标签1";
            // 
            // 标签2ToolStripMenuItem
            // 
            this.标签2ToolStripMenuItem.Name = "标签2ToolStripMenuItem";
            this.标签2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.标签2ToolStripMenuItem.Text = "标签2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // 新建标签ToolStripMenuItem
            // 
            this.新建标签ToolStripMenuItem.Name = "新建标签ToolStripMenuItem";
            this.新建标签ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建标签ToolStripMenuItem.Text = "新建标签";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox);
            this.splitContainer2.Panel1.Controls.Add(this.panelSearch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelEditNoteNo);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxEdit);
            this.splitContainer2.Panel2.Controls.Add(this.panelTitle);
            this.splitContainer2.Size = new System.Drawing.Size(771, 450);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(0, 26);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(130, 424);
            this.listBox.TabIndex = 1;
            this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Controls.Add(this.search);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelSearch.Size = new System.Drawing.Size(130, 26);
            this.panelSearch.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 21);
            this.textBox1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Right;
            this.search.Location = new System.Drawing.Point(90, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(40, 21);
            this.search.TabIndex = 0;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // labelEditNoteNo
            // 
            this.labelEditNoteNo.AutoSize = true;
            this.labelEditNoteNo.Location = new System.Drawing.Point(81, 44);
            this.labelEditNoteNo.Name = "labelEditNoteNo";
            this.labelEditNoteNo.Size = new System.Drawing.Size(29, 12);
            this.labelEditNoteNo.TabIndex = 3;
            this.labelEditNoteNo.Text = "NULL";
            this.labelEditNoteNo.Visible = false;
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEdit.Location = new System.Drawing.Point(-1, 32);
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.Size = new System.Drawing.Size(635, 418);
            this.textBoxEdit.TabIndex = 1;
            this.textBoxEdit.Text = "";
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.Controls.Add(this.textBoxTitle);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Location = new System.Drawing.Point(2, 3);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(635, 25);
            this.panelTitle.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(38, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(594, 21);
            this.textBoxTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // treeview_nav
            // 
            this.treeview_nav.ContextMenuStrip = this.contextMenuStrip_treeview_nav;
            this.treeview_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeview_nav.HideSelection = false;
            this.treeview_nav.HotTracking = true;
            this.treeview_nav.Location = new System.Drawing.Point(0, 0);
            this.treeview_nav.Name = "treeview_nav";
            this.treeview_nav.Size = new System.Drawing.Size(153, 450);
            this.treeview_nav.TabIndex = 0;
            this.treeview_nav.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeview_nav_AfterLabelEdit);
            this.treeview_nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeview_nav_MouseDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeview_nav);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(928, 450);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 4;
            // 
            // contextMenuStrip_label
            // 
            this.contextMenuStrip_label.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem1,
            this.删除ToolStripMenuItem2});
            this.contextMenuStrip_label.Name = "contextMenuStrip_label";
            this.contextMenuStrip_label.Size = new System.Drawing.Size(113, 48);
            // 
            // 重命名ToolStripMenuItem1
            // 
            this.重命名ToolStripMenuItem1.Name = "重命名ToolStripMenuItem1";
            this.重命名ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.重命名ToolStripMenuItem1.Text = "重命名";
            this.重命名ToolStripMenuItem1.Click += new System.EventHandler(this.重命名ToolStripMenuItem1_Click);
            // 
            // 删除ToolStripMenuItem2
            // 
            this.删除ToolStripMenuItem2.Name = "删除ToolStripMenuItem2";
            this.删除ToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.删除ToolStripMenuItem2.Text = "删除";
            this.删除ToolStripMenuItem2.Click += new System.EventHandler(this.删除ToolStripMenuItem2_Click);
            // 
            // contextMenuStrip_label_root
            // 
            this.contextMenuStrip_label_root.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建标签ToolStripMenuItem1});
            this.contextMenuStrip_label_root.Name = "contextMenuStrip_label_root";
            this.contextMenuStrip_label_root.Size = new System.Drawing.Size(125, 26);
            // 
            // 新建标签ToolStripMenuItem1
            // 
            this.新建标签ToolStripMenuItem1.Name = "新建标签ToolStripMenuItem1";
            this.新建标签ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.新建标签ToolStripMenuItem1.Text = "新建标签";
            // 
            // contextMenuStrip_trash
            // 
            this.contextMenuStrip_trash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空垃圾篓ToolStripMenuItem});
            this.contextMenuStrip_trash.Name = "contextMenuStrip_trash";
            this.contextMenuStrip_trash.Size = new System.Drawing.Size(137, 26);
            // 
            // 清空垃圾篓ToolStripMenuItem
            // 
            this.清空垃圾篓ToolStripMenuItem.Name = "清空垃圾篓ToolStripMenuItem";
            this.清空垃圾篓ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.清空垃圾篓ToolStripMenuItem.Text = "清空垃圾篓";
            // 
            // contextMenuStripListBoxTrash
            // 
            this.contextMenuStripListBoxTrash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.彻底删除ToolStripMenuItem,
            this.恢复ToolStripMenuItem});
            this.contextMenuStripListBoxTrash.Name = "contextMenuStripListBoxTrash";
            this.contextMenuStripListBoxTrash.Size = new System.Drawing.Size(125, 48);
            // 
            // 彻底删除ToolStripMenuItem
            // 
            this.彻底删除ToolStripMenuItem.Name = "彻底删除ToolStripMenuItem";
            this.彻底删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.彻底删除ToolStripMenuItem.Text = "彻底删除";
            // 
            // 恢复ToolStripMenuItem
            // 
            this.恢复ToolStripMenuItem.Name = "恢复ToolStripMenuItem";
            this.恢复ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.恢复ToolStripMenuItem.Text = "恢复";
            // 
            // contextMenuStripListBox
            // 
            this.contextMenuStripListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem1});
            this.contextMenuStripListBox.Name = "contextMenuStripListBox";
            this.contextMenuStripListBox.Size = new System.Drawing.Size(101, 26);
            // 
            // 刷新ToolStripMenuItem1
            // 
            this.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1";
            this.刷新ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.刷新ToolStripMenuItem1.Text = "刷新";
            // 
            // Gnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 522);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripShortCut);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gnote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gnote";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripShortCut.ResumeLayout(false);
            this.toolStripShortCut.PerformLayout();
            this.contextMenuStrip_treeview_nav.ResumeLayout(false);
            this.contextMenuStrip_notebook_root.ResumeLayout(false);
            this.contextMenuStrip_notebook.ResumeLayout(false);
            this.contextMenuStripListBoxNote.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip_label.ResumeLayout(false);
            this.contextMenuStrip_label_root.ResumeLayout(false);
            this.contextMenuStrip_trash.ResumeLayout(false);
            this.contextMenuStripListBoxTrash.ResumeLayout(false);
            this.contextMenuStripListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于GnoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripShortCut;
        private System.Windows.Forms.ToolStripButton NewNotebook;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_treeview_nav;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notebook_root;
        private System.Windows.Forms.ToolStripMenuItem 新建笔记本ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notebook;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem_notebook;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置为默认笔记本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListBoxNote;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 移动到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的笔记本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标签管理ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeview_nav;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_label;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 标签1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标签2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 新建标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTip;
        private System.Windows.Forms.RichTextBox textBoxEdit;
        private System.Windows.Forms.ToolStripMenuItem 收藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建笔记ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_label_root;
        private System.Windows.Forms.ToolStripMenuItem 新建标签ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_trash;
        private System.Windows.Forms.ToolStripMenuItem 清空垃圾篓ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListBoxTrash;
        private System.Windows.Forms.ToolStripMenuItem 彻底删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复ToolStripMenuItem;
        private System.Windows.Forms.Label labelEditNoteNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListBox;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem1;
    }
}

