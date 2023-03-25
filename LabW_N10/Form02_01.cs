using System;
using System.Collections.Generic;
using System.Drawing;
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
            List<double[]> Points = new List<double[]>();
            graphics.TranslateTransform(GrfX,Grfy);
            graphics.DrawEllipse(new Pen(Color.Red, 8f), 0,0,1,1);
            int x, y;
            graphics.DrawLine(new Pen(Color.Gray, 1f), -300,0,300,0);
            graphics.DrawLine(new Pen(Color.Gray, 1f), 0,-300,0,300);
            Points = LabW_N10.SupportMethods.ReturnPoints(SupportMethods.NumberGraphicsForLevel2);
            foreach (var point in Points)
            {
                graphics.DrawEllipse(new Pen(Color.Blue, 2f), ((float)point[0]*5), -((float)point[1]), 1, 1);
            }
            
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
    }
}