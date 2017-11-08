using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gnote.Controller;
using Gnote;

namespace Gnote.Dialog
{
    public partial class NewNotebook : Form
    {
        public NewNotebook()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxNotebook.Text == "")
            {
                MessageBox.Show("笔记本名称不能为空！");
            }
            else
            {
                Notebook notebook = new Notebook();
                notebook.createNotebook(textBoxNotebook.Text);
                MessageBox.Show("创建成功");
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
