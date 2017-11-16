using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form
{
    public partial class FormMain : Form
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            
        }

    }
}
