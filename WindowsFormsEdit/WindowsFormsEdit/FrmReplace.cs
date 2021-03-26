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
    public partial class FrmReplace : Form
    {
        public FrmReplace()
        {
            InitializeComponent();
        }

        private void FrmReplace_Load(object sender, EventArgs e)
        {

        }

        public string sOrigin;
        public string sDest;

        private void btnRepalce_Click(object sender, EventArgs e)
        {
            sOrigin = tbOrigin.Text;
            sDest = tbDest.Text;
        }
    }
}
