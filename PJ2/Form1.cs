using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PJ2
{
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        List<string> colName = new List<string>();

        private void ViewSql(List<string> sarr)
        {
            if (sarr == null)
                return;
            dataView.Rows.Clear();
            dataView.Columns.Clear();
            for (int i = 0; i < colName.Count; i++)
            {
                dataView.Columns.Add(colName[i], colName[i]);
            }
            for (int i = 0; i < sarr.Count; i++)
            {
                int rindex = dataView.Rows.Add();
                for (int j = 0; j < colName.Count; j++)
                {
                    dataView.Rows[rindex].Cells[j].Value = sarr[i].Split(',')[j];
                }
            }
        }
        private List<string> RunSql(string sql)
        {
            try
            {
                List<string> sarr = new List<string>();
                sqlCommand.CommandText = sql;
                if (sql.Trim().ToLower().Substring(0, 6) == "select")
                {
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    colName.Clear();
                    for (int i = 0; i < sr.FieldCount; i++)
                    {
                        colName.Add(sr.GetName(i).ToString());
                    }
                    for (int i = 0; sr.Read(); i++)
                    {
                        string str = "";
                        for (int j = 0; j < sr.FieldCount; j++)
                        {
                            str += sr.GetValue(j).ToString() + ",";
                        }
                        sarr.Add(str);
                    }
                    sr.Close();
                    ViewSql(sarr);
                }
                else
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return sarr;
            }
            catch (Exception ex)
            {
                stLabel1.Text = ex.Message;
                return null;
            }
        }
        private void mnuLoad_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                sqlConn.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security = True;Connect Timeout = 30";
                sqlConn.Open();
                sqlCommand.Connection = sqlConn;
                stLabel1.Text = "성공적으로 불러왔습니다.";
                dataView.Rows.Clear();
                dataView.Columns.Clear();
                List<string> sarr = RunSql("select * from address");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string Data1 = NewNameTB.Text;
            string Data2 = NewPhoneTB.Text;
            string Data3 = NewAddressTB.Text;
            RunSql($"insert into address values('{Data1}', '{Data2}', '{Data3}')");
            RunSql($"select * from address");
            NewNameTB.Text = "";
            NewPhoneTB.Text = "";
            NewAddressTB.Text = "";
            stLabel1.Text = "저장이 완료되었습니다.";
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string Data1 = findName.Text;
            string Data2 = findPhone.Text;
            string Data3 = findAddress.Text;
            if (Data1 != "")
            {
                RunSql($"select * from address where Name like '%{Data1}%'");
                stLabel1.Text = "검색이 완료되었습니다.";
            }
            if (Data2 != "")
            {
                RunSql($"select * from address where Phone like '%{Data2}%'");
                stLabel1.Text = "검색이 완료되었습니다.";
            }
            if (Data3 != "")
            {
                RunSql($"select * from address where Address like '%{Data3}%'");
                stLabel1.Text = "검색이 완료되었습니다.";
            }
            else if ((Data1 == "") && (Data2 == "") && (Data3 == "")) 
            {
                stLabel1.Text = "검색할 항목을 입력하십시오";
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
