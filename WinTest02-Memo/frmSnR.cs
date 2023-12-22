using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Memo
{
    public partial class frmSnR : Form
    {
        public frmSnR(int op)
        {
            InitializeComponent();
            if (op == 1)
            {
                label2.Visible = false;
                tbTo.Visible = false;
                button2.Visible = false;
            }
            else
            {
                label2.Visible = true;
                tbTo.Visible = true;
                button2.Visible = true;
            }
        }
    }
}
