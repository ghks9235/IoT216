using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEdit
{
    public partial class FrmSearch : Form
    {
        public string sSearch;
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sSearch = tbSearch.Text;
            //Num = int.Parse(tbSearch.Text);
            //dNum = double.Parse(tbSearch.Text);
        }
    }
}
