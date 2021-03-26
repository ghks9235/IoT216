using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    public partial class Form1 : Form
    {
        public class myLib
        {
            public static string GetToken(int index, char deli, string str)
            {
                string[] Strs = str.Split(deli);
                string ret = Strs[index];
                return ret;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void mnuMygration_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret != DialogResult.OK) return;
            string nFile = openFileDialog1.FileName;    //Full name

            StreamReader sr = new StreamReader(nFile);

            //============================================================
            //  Header 처리 프로세스
            //============================================================

            string buf = sr.ReadLine(); 
            if (buf == null) return; // 1 Line Road : Header Line
            string[] sArr = buf.Split(',');
            for (int i = 0; i < sArr.Length; i++)
            {
               dataGrid.Columns.Add(sArr[i], sArr[i]);
            }

            //============================================================
            //  Row 처리 프로세스
            //============================================================
            while (true)
            {
                buf = sr.ReadLine();    // 1Line Road
                if (buf == null) break;
                sArr = buf.Split(',');
                //dataGrid.Rows.Add(sArr);
                int ridx = dataGrid.Rows.Add();    // 1 Line 생성
                for (int i = 0; i < sArr.Length; i++)
                {
                    dataGrid.Rows[ridx].Cells[i].Value = sArr[i];
                }
            }
        }

        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        string sConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=;Integrated Security=True;Connect Timeout=30";
        private void mnuDBOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret = openFileDialog1.ShowDialog();    //DB File
                if (ret != DialogResult.OK) return;
                string nFile = openFileDialog1.FileName;    //Full name
                string[] ss = sConn.Split(';');

                sqlCmd.Connection = sqlCon;
                sqlCon.ConnectionString = $"{ss[0]};{ss[1]}{nFile};{ss[2]};{ss[3]}";
                sqlCon.Open();
                sbPanel1.Text = openFileDialog1.SafeFileName;
                sbPannel2.Text = " DB File open success";
                sbPanel1.BackColor = Color.Green;

                DataTable dt = sqlCon.GetSchema("Tables");
                for(int i =0; i < dt.Rows.Count; i++)
                {
                    String s = dt.Rows[i].ItemArray[2].ToString();
                    sbButton1.DropDownItems.Add(s);
                }

                //string sample = "column1, column2";
                //string[] sa = sample.Split(',');
                //string buf = "";
                
                //foreach (string col in sa)
                //{
                //    //buf = string.Format("(0," + 30 + ")", col); 
                //    buf += $"{col,30}";
                //}
                //sbPannel2.Text = buf;
            }

            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
                sbPannel2.Text = "DB File cannor open";
                sbPannel2.BackColor = Color.Red;
            }
        }

        private void mnuDBClose_Click(object sender, EventArgs e)
        {
            sqlCon.Close();
            sbPanel1.Text = "DB File Name";
            sbPanel1.BackColor = Color.Gray;
            sbPannel2.Text = " DB File close success";

            sbButton1.DropDownItems.Clear();
        }


    String Tablename;   // 다른 메뉴에서 사용할 DB Table 이름. 현재 오픈된 테이블
        int Runsql(string s1)
        {
            try
            {   //ex) select* from  fstatus : select.id.fname.fdesc.from __
                string sql = s1.Trim(); 
                sqlCmd.CommandText = sql;   //insert into fatatus values (1,2,3,4)
                if (myLib.GetToken(0, ' ', sql).ToUpper() == "SELECT")
                {
                    SqlDataReader sr = sqlCmd.ExecuteReader();

                    Tablename = myLib.GetToken(3, ' ', sql);
                    //sbPanel3.Text = Tablename;
                    dataGrid.Rows.Clear();
                    dataGrid.Columns.Clear();

                    for (int i =0; i< sr.FieldCount; i++)   //Header 처리
                    {
                        string ss = sr.GetName(i);
                        dataGrid.Columns.Add(ss,ss);
                    }
                    for (int i = 0; sr.Read(); i++)
                    {
                        int ridx = dataGrid.Rows.Add();
                        for (int j = 0; j < sr.FieldCount; j++)
                        {
                            object str = sr.GetValue(j);
                            dataGrid.Rows[ridx].Cells[j].Value = str;
                        }
                    }
                
                    sr.Close();

                    //for (int i = 0; sr.Read(); i++)  // 1 record read
                    //{
                    //    string buf = "";
                    //    for (int j = 0; j < sr.FieldCount; j++)
                    //    {
                    //        object str = sr.GetValue(j);
                    //        buf += $" {str}";
                    //    }
                    //    tbsql.Text += $"\r\n{buf}";
                    //}
                    //sr.Close();
                }
                else
                {
                    sqlCmd.ExecuteNonQuery();   //select문 제외 - no return value
                                                //update isert delete create alt
                }

                sbPannel2.Text = "Success";
                sbPannel2.BackColor = Color.AliceBlue;
            }
            catch(SqlException e1)
            {
                MessageBox.Show(e1.Message);
                sbPannel2.Text = "Error";
                sbPannel2.BackColor = Color.Red;
            }
            catch(InvalidAsynchronousStateException e2)
            {
                MessageBox.Show(e2.Message);
                sbPannel2.Text = "Error";
                sbPannel2.BackColor = Color.Red;
            }
                return 0;
        }

        private void mnuExecsql_Click(object sender, EventArgs e)
        {
            Runsql(tbsql.Text);
        }

        private void mnuSelsql_Click(object sender, EventArgs e)
        {
            Runsql(tbsql.Text);
        }

        private void tbsql_KeyDown(object sender, KeyEventArgs e)
        {
            if (!mnuEnterKey.Checked) return;
            if (e.KeyCode != Keys.Enter) return;

            string str = tbsql.Text;
            string[] sArr = str.Split('\n');    // 줄바꿈문자 : \r\n
            int n = sArr.Length;
            string sql = sArr[n - 1].Trim();
            Runsql(sql);
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = ",";

        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for(int j =0; j < dataGrid.Columns.Count; j++)
                {
                    string s = dataGrid.Rows[i].Cells[j].ToolTipText;
                    if(s == ",")    
 //update [Table]   set [field]=(CellText) where[KeyName]=(Key.CellText)
 //update [fStatus] set [Temp]=(10)        where [ID]=(6)
                    {
                        string tn = Tablename;
                        string fn = dataGrid.Columns[j].HeaderText;
                        string ct = (string)dataGrid.Rows[i].Cells[j].Value;
                        //윗줄과 같음 object ct = dataGrid.Rows[i].Cells[j].Value;
                        string kn = dataGrid.Columns[0].HeaderText;
                        int kt = (int)dataGrid.Rows[i].Cells[0].Value;
                        string sql = $"update {tn} set {fn} ={ct} where {kn} = {kt}";
                        Runsql(sql);
                    }
                }
            }
        }

        private void sbButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.Text; //. 사용할 테이블명
            string sql = $"select * from {s}";
            sbButton1.Text = s;
            Runsql(sql);
        }

        private void mnuEditRowAdd_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Add();
        }

        private void mnuEditColAdd_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2("input Column Name");
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string s = dlg.sinput;
                dataGrid.Columns.Add(s, s);
            }
        }

        private void mnuEnterKey_Click(object sender, EventArgs e)
        {
            mnuEnterKey.Checked = !mnuEnterKey.Checked;
        }

        //create table [TableName] (
        //[column1] ncahr(숫자),
        //[column2] ncahr(숫자),
        //[column3] ncahr(숫자),
        //)

        private void mnuNewTable_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2("신규 테이블 명");
            if (dlg.ShowDialog() == DialogResult.OK) return;
            string tableName = dlg.sinput;

            string sql = $"create table {tableName} (";
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                sql += $"{dataGrid.Columns[i].HeaderCell} nchar(20), ";
                if (i < dataGrid.ColumnCount - 1) sql += ",";
            }
            sql += ")";

            Runsql(sql);    //신규 테이블 생성 완료

            // insert into [TableName] values (
            // [col_val_1], [col_val_2], ***
            // )
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                sql = $"insert into {tableName} values (";
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    sql += $"'{dataGrid.Rows[i].Cells[j].Value}'";
                    if (j < dataGrid.Columns.Count - 1) sql += ",";
                }
                sql += ")";
                Runsql(sql);
            }
        }
    }
}
