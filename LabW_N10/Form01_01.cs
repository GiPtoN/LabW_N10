using System;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form01_01 : Form
    {
        public Form01_01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int a);
            int.TryParse(textBox2.Text, out int b);
            label1.Text = $"{a + b}";
        }
        private void Form01_01_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.StartPosition = FormStartPosition.Manual; 
            MainForm.Left = this.Left; 
            MainForm.Top = this.Top; 
            MainForm.Show();
            this.Close();
        }
    }
}