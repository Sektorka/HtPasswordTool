using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HtPasswordTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            HtPassword passwd = new HtPassword();
            passwd.Name = tbName.Text;
            passwd.Password = tbPassword.Text;

            tbHtpasswd.Text = passwd.ToString();
            tbHtaccess.Text = GetHtaccessData();
        }

        private string GetHtaccessData()
        {
            return "AuthType Basic\r\n" + 
                   "AuthName \"" + tbMessage.Text + "\"\r\n" + 
                   "AuthUserFile \"" + tbHtpassPath.Text + "\"\r\n" + 
                   "Require valid-user";
        }
    }
}
