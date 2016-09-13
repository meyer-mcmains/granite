using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granite
{
    public partial class Granite : Form
    {
        public Granite()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usrlabel.Left = (this.ClientSize.Width - username.Width) / 2;
            usrlabel.Top = (this.ClientSize.Height - username.Height) / 2;
            username.Left = this.usrlabel.Left;
            username.Top = (this.usrlabel.Top + usrlabel.Height);
            pswdLabel.Left = this.usrlabel.Left;
            pswdLabel.Top = (this.username.Top + username.Height);
            pswd.Left = this.usrlabel.Left;
            pswd.Top = (this.pswdLabel.Top + pswd.Height);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            usrlabel.Left = (this.ClientSize.Width - username.Width) / 2;
            usrlabel.Top = (this.ClientSize.Height - username.Height) / 2;
            username.Left = this.usrlabel.Left;
            username.Top = (this.usrlabel.Top + usrlabel.Height);
            pswdLabel.Left = this.usrlabel.Left;
            pswdLabel.Top = (this.username.Top + username.Height);
            pswd.Left = this.usrlabel.Left;
            pswd.Top = (this.pswdLabel.Top + pswd.Height);
        }

        private void pswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
