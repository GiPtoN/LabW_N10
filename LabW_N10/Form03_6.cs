using System;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form03_6 : Form
    {
        public Form03_6()
        {
            InitializeComponent();
        }
        private void EndGame()
        {
            while (SupportMethodsForNumber03_6.PlayerOnePoints>SupportMethodsForNumber03_6.PlayerPcPoints & SupportMethodsForNumber03_6.PlayerPcPoints<SupportMethodsForNumber03_6.TargetCount)
            {
                SupportMethodsForNumber03_6.PlayerPcPoints += SupportMethodsForNumber03_6.RandomPoint.Next(SupportMethodsForNumber03_6.MinPoint,SupportMethodsForNumber03_6.MaxPoint);
                Pl2Score.Text = $"{SupportMethodsForNumber03_6.PlayerPcPoints}";
            }
            if (SupportMethodsForNumber03_6.PlayerOnePoints <= SupportMethodsForNumber03_6.PlayerPcPoints & SupportMethodsForNumber03_6.PlayerPcPoints<=SupportMethodsForNumber03_6.TargetCount) GameEnded(false);
            else GameEnded(true);
        }
        private void StartNewGame()
        {
            SupportMethodsForNumber03_6.PlayerOnePoints = 0;
            SupportMethodsForNumber03_6.PlayerPcPoints = 0;
            Pl1Score.Text= "0";
            Pl2Score.Text= "0";
        }
        private void GameEnded(bool Status)
        { 
            string Text; 
            if (Status) Text = $"You Win !!!\n Score: \n You: {Pl1Score.Text}, \n PC: {Pl2Score.Text}";
            else Text =  $"You Lose :(\n  Score:\n You: {Pl1Score.Text}, \n PC: {Pl2Score.Text}"; 
            MessageBox.Show(Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            StartNewGame();
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.StartPosition = FormStartPosition.Manual; 
            MainForm.Left = this.Left; 
            MainForm.Top = this.Top; 
            MainForm.Show();
            this.Close();        
        }

        private void Form03_6_Load(object sender, EventArgs e)
        {
            SupportMethodsForNumber03_6.PlayerOnePoints = 0;
            SupportMethodsForNumber03_6.PlayerOnePoints = 0;
        }
        private void SetNumbersButton_Click(object sender, EventArgs e)
        {
            SupportMethodsForNumber03_6.MinPoint = int.Parse(MinPointBox.Text);
            SupportMethodsForNumber03_6.MaxPoint = int.Parse(MaxPointBox.Text);
            SupportMethodsForNumber03_6.TargetCount = int.Parse(TargetScoreBox.Text);          
        }
        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
        
        private void GetMoreButton_Click(object sender, EventArgs e)
        {
            SupportMethodsForNumber03_6.PlusPoint(ref SupportMethodsForNumber03_6.PlayerOnePoints);
            Pl1Score.Text = $"{SupportMethodsForNumber03_6.PlayerOnePoints}";
            if (SupportMethodsForNumber03_6.PlayerOnePoints > SupportMethodsForNumber03_6.TargetCount)
            {
                SupportMethodsForNumber03_6.PlayerPcPoints += SupportMethodsForNumber03_6.RandomPoint.Next(SupportMethodsForNumber03_6.MinPoint,SupportMethodsForNumber03_6.MaxPoint);
                Pl2Score.Text = $"{SupportMethodsForNumber03_6.PlayerPcPoints}";
                GameEnded(false);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            EndGame();        
        }
    }
    
    public class SupportMethodsForNumber03_6
    {
        public static Random RandomPoint = new Random();
        public static int MinPoint; 
        public static int MaxPoint;
        public static int TargetCount; 
        
        public static int PlayerOnePoints;
        public static int PlayerPcPoints;

        static public void PlusPoint(ref int Player)
        {
            Player += RandomPoint.Next(MinPoint, MaxPoint);
        }
    } 
}