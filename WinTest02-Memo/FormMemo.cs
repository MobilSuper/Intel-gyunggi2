using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest02_Memo
{
    public partial class FormMemo : Form
    {
        public FormMemo()
        {
            InitializeComponent();
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if(r == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                FileStream fi = new FileStream(fn, FileMode.Open);
                StreamReader sr = new StreamReader(fi);
                tbMemo.Text = sr.ReadToEnd();
            }
        }

        private void MnuFind_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
            string str = frm.tbFind.Text;
        }

        private void MnuFnR_Click(object sender, EventArgs e)
        {
            frmSnR frm = new frmSnR();
            frm.ShowDialog();
            string s1 = frm.tbFrom.Text;
            string s2 = frm.tbTo.Text;
            tbMemo.Text = tbMemo.Text.Replace(s1, s2);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
