using System;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form03_06 : Form
    {
        public Form03_06()
        {
            InitializeComponent();
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

        private void Form03_06_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}