using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class Form1 : Form
    {
        Graphics GDC;
        public Form1()
        {
            InitializeComponent();

            GDC = CanvasDrew.CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Pen pp = new Pen(Color.Red, 3);
            GDC.DrawEllipse(pp, e.X, e.Y, 200, 200);
        }

        bool Mstatus = false;    // false : 그리기상태 아님. true: 그리기 상태
        int DrawMode = -1;       // -1: none  0:pen  1: circle 2: ark 3. Line
        Point p1;
        Color Col = Color.Red;
        private void CanvasDrew_MouseDown(object sender, MouseEventArgs e)
        {
            if(DrawMode == 0)
            {
                p1 = new Point(e.X, e.Y);
                Mstatus = true;
            }
            else if(DrawMode == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Pen pp = new Pen(Col, Thickness);
                    GDC.DrawEllipse(pp, e.X - cirX / 2, e.Y - cirY / 2, cirX, cirY);
                }
            }
        }

        private void CanvasDrew_Resize(object sender, EventArgs e)
        {
            GDC = CanvasDrew.CreateGraphics();
        }

        private void mnuErase_Click(object sender, EventArgs e)
        {
            GDC.Clear(DefaultBackColor);
        }

        int cirX = 10;
        int cirY = 10;
        int Thickness = 2;

        private void mnuOpction_Click(object sender, EventArgs e)
        {
            FormOpction dlg = new FormOpction(cirX, cirY, Thickness);
            //dlg.X=cirX; dlg.Y=cirY; dlg.Thick = Thickness;
            DialogResult ret = dlg.ShowDialog();
            if(ret == DialogResult.OK)
            {
                int cirX = dlg.X;
                int cirY = dlg.Y;
                int Thickness = dlg.Thick;
                Col = dlg.Col1;
                sbPanal3.Text = $"{dlg.ColorName},{Thickness}";
            }
        }

        private void CanvasDrew_MouseMove(object sender, MouseEventArgs e)
        {
            //int x = e.X;
            //int y = e.Y;
            //string sx = $"{x}";
            //string sy = $"{y}";
            if (DrawMode == 0)
            {
                if (Mstatus)
                {
                    Pen pp = new Pen(Col, Thickness);
                    Point p2 = new Point(e.X, e.Y);
                    GDC.DrawLine(pp, p1, p2);
                    p1 = p2;
                }
            }
            sbPanal1.Text = $"{e.X}, {e.Y}";
        }

        private void CanvasDrew_MouseUp(object sender, MouseEventArgs e)
        {
            Mstatus = false;
        }

        private void mnuDrawPen_Click(object sender, EventArgs e)
        {
            DrawMode = 0;
            sbPanal2.Text = "펜 그리기";
            sbPanal3.Text = $"{Col.ToString()},{Thickness}";
        }

        private void mnuDrawCircle_Click(object sender, EventArgs e)
        {
            DrawMode = 1;
            sbPanal2.Text = "원 그리기";
        }

        private void mnuDrawArc_Click(object sender, EventArgs e)
        {
            DrawMode = 2;
            sbPanal2.Text = "호 그리기";
        }

        private void mnuDrawLine_Click(object sender, EventArgs e)
        {
            DrawMode = 3;
            sbPanal2.Text = "라인 그리기";
        }

        private void mnuDrawStop_Click(object sender, EventArgs e)
        {
            DrawMode = -1;
            sbPanal2.Text = "그리기 모드";

        }
    }
}
