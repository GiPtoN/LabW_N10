using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form01_08 : Form
    {
        public Form01_08()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                int sum = richTextBox1.Lines[i].Split(' ').Select(x => int.Parse(x)).Sum();
                richTextBox2.AppendText($"{sum}\n");
            }
        }
        private void Form01_08_Load(object sender, EventArgs e)
        { }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.StartPosition = FormStartPosition.Manual; 
            MainForm.Left = this.Left; 
            MainForm.Top = this.Top; 
            MainForm.Show();
            this.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}