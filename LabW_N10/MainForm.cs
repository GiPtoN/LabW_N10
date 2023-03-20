using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            Form form0101 = new Form01_01();
            form0101.StartPosition = FormStartPosition.Manual; 
            form0101.Left = this.Left; 
            form0101.Top = this.Top; 
            form0101.Show(); 
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form0108 = new Form01_08();
            form0108.StartPosition = FormStartPosition.Manual; 
            form0108.Left = this.Left; 
            form0108.Top = this.Top; 
            form0108.Show(); 
            this.Hide();         }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form0201 = new Form02_01(); 
            form0201.StartPosition = FormStartPosition.Manual; 
            form0201.Left = this.Left; 
            form0201.Top = this.Top; 
            form0201.Show(); 
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Number = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form0306 = new Form03_06(); 
            form0306.StartPosition = FormStartPosition.Manual; 
            form0306.Left = this.Left; 
            form0306.Top = this.Top; 
            form0306.Show(); 
            this.Hide();        
        }
    }
}