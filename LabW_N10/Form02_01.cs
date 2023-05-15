using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form02_01 : Form
    {
        public Form02_01()
        {
            InitializeComponent();
        }
        private void Form02_01_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int GrfX = this.Width/2;
            int Grfy = this.Height/2;
            graphics.TranslateTransform(GrfX,Grfy);
            graphics.DrawEllipse(new Pen(Color.Red, 8f), 0,0,1,1);
            int x, y;
            graphics.DrawLine(new Pen(Color.Gray, 1f), -300,0,300,0);
            graphics.DrawLine(new Pen(Color.Gray, 1f), 0,-300,0,300);
            var Points = LabW_N10.SupportMethods.ReturnPoints(SupportMethods.NumberGraphicsForLevel2);
            
            foreach (var point in Points.Points)
            {
                graphics.DrawEllipse(new Pen(Color.Blue, 2f), ((float)point[0]*5), -((float)point[1]), 1, 1);
            }
            var MaxIndX = Points.Points.Select(x1 => x1[0]).ToList().Max();
            var MaxIndY = Points.Points.Select(x1 => x1[1]).ToList().Max();
            
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();

            graphics.DrawString($"{((int)(MaxIndY / Points.kf))}", drawFont, drawBrush, (float)5, -((float)MaxIndY), drawFormat);
            graphics.DrawString($"{((int)(MaxIndX / Points.kf))}", drawFont, drawBrush, (float)MaxIndX*5, 0, drawFormat);



        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.StartPosition = FormStartPosition.Manual; 
            MainForm.Left = this.Left;
            MainForm.Top = this.Top;
            MainForm.Show();
            this.Close();
        }
        private void Form02_01_Load_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e){}
    }
}