using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    public partial class Form2 : Form
    {
        public Form2(string sTitle = "input")
        {
            STITLE = sTitle;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblInput.Text = STITLE;
        }

        public string sinput;
        string STITLE;

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbInput.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                    sinput = tbInput.Text;
                    Close();
                }
                else this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
