using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest01_Base
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            CMTest01.SelectedIndex = 0;
            CMTest02.SelectedIndex = 1;
            CMTest03.SelectedIndex = 2;
            CMTest04.SelectedIndex = 3;
        }

        int flag = 0;

        private void btnTest_Click(object sender, EventArgs e)
        {
            /*if(label1.Text == "Hello, world!" )
                label1.Text = "안녕하세요";
            else
                label1.Text = "Hello, world!";*/

            /*if (++flag == 1)
                label1.Text = "안녕하세요";
            else
            {
                label1.Text = "Hello, world!";
                flag = 0;
            }*/
            int n = (flag++) % 4;
            switch(n)
            {
                case 0:
                    if (CTest01.Checked == false)
                        break;
                    TBox01.Text = $"{n + 1}";
                    TBox02.Text = $"";
                    TBox03.Text = $"";
                    TBox04.Text = $"";
                    break;
                case 1:
                    if (CTest02.Checked == false)
                        break;
                    TBox01.Text = $"";
                    TBox02.Text = $"{n + 1}";
                    TBox03.Text = $"";
                    TBox04.Text = $"";
                    break;
                case 2:
                    if (CTest03.Checked == false)
                        break;
                    TBox01.Text = $"";
                    TBox02.Text = $"";
                    TBox03.Text = $"{n + 1}";
                    TBox04.Text = $"";
                    break;
                case 3:
                    if (CTest04.Checked == false)
                        break;
                    TBox01.Text = $"";
                    TBox02.Text = $"";
                    TBox03.Text = $"";
                    TBox04.Text = $"{n + 1}";
                    break;
            }
        }
        private void CTest01_CheckedChanged(object sender, EventArgs e)
        {
            if (CTest01.Checked)
                CMTest01.Enabled = true;
            else
                CMTest01.Enabled = false;
        }

        private void CTest02_CheckedChanged(object sender, EventArgs e)
        {
            if (CTest02.Checked)
                CMTest02.Enabled = true;
            else
                CMTest02.Enabled = false;
        }

        private void CTest03_CheckedChanged(object sender, EventArgs e)
        {
            if (CTest03.Checked)
                CMTest03.Enabled = true;
            else
                CMTest03.Enabled = false;
        }
        private void CTest04_CheckedChanged(object sender, EventArgs e)
        {
            if (CTest04.Checked)
                CMTest04.Enabled = true;
            else
                CMTest04.Enabled = false;
        }
        private void MnuExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuUpper_Click(object sender, EventArgs e)
        {
            TBox04.Text = TBox04.Text.ToUpper();
        }

        private void MnuLower_Click(object sender, EventArgs e)
        {
            TBox04.Text = TBox04.Text.ToLower();
        }

        private void CMTest01_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBox01.Text = CMTest01.Text; 
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog1.FileName;
            }
        }
    }
}
