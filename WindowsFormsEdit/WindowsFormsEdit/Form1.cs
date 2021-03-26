using myLibrary;
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

namespace WindowsFormsEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();   // C++ DoModal
            if (ret == DialogResult.OK)
            {
                string fName = openFileDialog1.FileName;      // Full path
                string fName1 = openFileDialog1.SafeFileName;      // Full path
                StreamReader sr = new StreamReader(fName);     // c:File*    c++:CFile
                string buf = sr.ReadToEnd();
                tbMemo.Text = buf;
                sr.Close();
                int n = myLib.count('\\', fName);                 //fName
                string fName2 = myLib.GetToken(n, '\\', fName);
                this.Text += $"          [{fName2}]";
            }
        }

        // Save as...
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();   // C++ DoModal
            if (ret == DialogResult.OK)
            {
                string fName = saveFileDialog1.FileName;       // Full path
                StreamWriter sw = new StreamWriter(fName);     // c:File*    c++:CFile
                string buf = tbMemo.Text;
                sw.Write(buf);
                sw.Close();
            }
        }

        // 1. file open 후 Memo 창에 표시한 경우 - 확인 (O) 수정 (x)
        // 2. New 메뉴 선택 후 문서 편집 - file 명 없음
        // 3. 기존 문서 중 일부 수정 - open file 명 있음

        int txtchanged = 0;
        private void tbMemo_TextChanged(object sender, EventArgs e)
        {
            if (true) txtchanged = 1;
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void SetFontinfo()
        {
            sbLabel1.Text = tbMemo.Font.Name;
            sbLabel2.Text = $"  {tbMemo.Font.Height}";
        }


        private void mnuViewFont_Click(object sender, EventArgs e)
        {
            DialogResult ret = fontDialog1.ShowDialog();
            if (ret == DialogResult.Cancel) return;

            Font fnt = fontDialog1.Font;
            tbMemo.Font = fnt;
            Form1_Load(sender, e);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFontinfo();
        }

        string strSearch;
        string strOrigin;
        string strDest;
        int pos = -1;

        private void Search_Scroll(string strSearch1)
        {
            pos = tbMemo.Text.IndexOf(strSearch1, pos + 1);        // tbMemo.Text : Target 문자열
            if (pos < 0)
            {
                MessageBox.Show("더 이상 해당 문자열을 찾을 수 없읍니다.");
                return;
            }
            tbMemo.SelectionStart = pos;
            tbMemo.SelectionLength = strSearch1.Length;
            tbMemo.ScrollToCaret();
        }

        private void mnuEditSearch_Click(object sender, EventArgs e)
        {
            FrmSearch dlg = new FrmSearch();
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)  // 착한 사용자인 경우
            {
                strSearch = dlg.sSearch;    // 찾을 문자열
                Search_Scroll(strSearch);
            }
        }

        private void mnuEditContinue_Click(object sender, EventArgs e)
        {
            Search_Scroll(strSearch);
        }

        private void mnuEditReplace_Click(object sender, EventArgs e)
        {
            FrmReplace dlg = new FrmReplace();
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)  // 착한 사용자인 경우
            {
                strOrigin = dlg.sOrigin;    // 찾을 문자열
                strDest = dlg.sDest;

                tbMemo.Text = tbMemo.Text.Replace(strOrigin, strDest);
                Search_Scroll(strDest);
                strSearch = strDest;
            }
        }
    }
}
