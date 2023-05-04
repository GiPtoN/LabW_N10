using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form03_6 : Form
    {
        PlayerPoint Players = new PlayerPoint();
        GameRulePoint GameSettings = new GameRulePoint();
        public Form03_6()
        {
            InitializeComponent();
        }

        private void Form03_6_Load(object sender, EventArgs e)
        {
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

        private void SetNumbersButton_Click(object sender, EventArgs e)
        {
            GameSettings.SetGameSettings
            (
                int.Parse(MinPointBox.Text),
                int.Parse(MaxPointBox.Text),
                int.Parse(TargetScoreBox.Text)
                );
        }

        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            GameSettings.StartNewGame(ref Players);
        }

        private void GetMoreButton_Click(object sender, EventArgs e)
        {
            GameSettings.GetMorePoint(ref Players);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            GameSettings.EndGame(ref Players);
        }

        public void SetPlScore(int number, int value)
        {
            switch (number)
            {
                case 1:
                    Pl1Score.Text = $"{value}";
                    break;
                case 2:
                    Pl2Score.Text = $"{value}";
                    break;
            }
        }
    }
    class PlayerPoint
    {
        public int FirstPoints;
        public int SecondPoints;
        public void SetZero()
        {
            FirstPoints = 0;
            SecondPoints = 0;
        }
    }
    
    class GameRulePoint : PlayerPoint
    {
        Form03_6 F = new Form03_6();
        private int TargetPoint;
        private Random RandomPoint = new Random();
        public void SetGameSettings(int Min, int Max, int Target)
        {
            FirstPoints = Min;
            SecondPoints = Max;   
            TargetPoint = Target;
        }
        public void PlayersPlusPoint(ref int Player)
        {
            Player += RandomPoint.Next(FirstPoints, SecondPoints);
            // First - Min, Second - Max
        }
        public void EndGame(ref PlayerPoint Player)
        {
            while (Player.FirstPoints<TargetPoint & Player.SecondPoints<TargetPoint)
            {
                PlayersPlusPoint(ref SecondPoints);
                F.SetPlScore(2,Player.SecondPoints);
            }
            if (Player.FirstPoints <= Player.SecondPoints & Player.SecondPoints<=TargetPoint) GameEnded(false, ref Player);
            else GameEnded(true, ref Player);
        }
        public void StartNewGame(ref PlayerPoint Players)
        {
            Players.SetZero();
            F.Pl1Score.Text= "0";
            F.Pl2Score.Text= "0";
        }
        public void GameEnded(bool status, ref PlayerPoint player)
        {
            string Text;
            if (status) Text = $"You Win !!!\n Score: \n You: {player.FirstPoints}, \n PC: {player.SecondPoints}";
            else Text = $"You Lose :(\n  Score:\n You: {player.FirstPoints}, \n PC: {player.SecondPoints}";
            MessageBox.Show(Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartNewGame(ref player);
        }
        public void GetMorePoint(ref PlayerPoint Player)
        {
            PlayersPlusPoint(ref Player.FirstPoints);
            F.SetPlScore(1, Player.FirstPoints);
            if (Player.FirstPoints > TargetPoint)
            {
                PlayersPlusPoint(ref Player.SecondPoints);
                F.SetPlScore(2, Player.SecondPoints);
                GameEnded(false, ref Player);
            }
        }
    }
}