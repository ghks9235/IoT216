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

namespace DBManagerEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand sqlCom = new SqlCommand();
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            sbPanel1.Text = "DB File Name";
            sbPanel2.Text = "Table List";
            sbPanel2.DropDownItems.Clear();
            sbPanel3.Text = "Initialized";
            sqlcon.Close();
        }

        private void mnuFileMygration_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            string buf = sr.ReadLine();      // 첫번째 Line에 각 Colum의 HeadText
            string[] sArr = buf.Split(',');  // ','로 구분되어 있음
            for(int i=0; i<sArr.Length;i++)
            {
                dataGrid.Columns.Add(sArr[i], sArr[i]);
            }
            while(true)
            {
                buf = sr.ReadLine();
                if (buf == null) break;
                sArr = buf.Split(',');  //string array
                dataGrid.Rows.Add();    //Row.Add Method의 4번째 오버로드
            }
            sr.Close();
        }
    }
}

