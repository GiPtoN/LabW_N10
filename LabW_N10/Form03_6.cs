using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LabW_N10
{
    public partial class Form03_6 : Form
    {
        public Form03_6()
        {
            InitializeComponent();
        }

        PlayerPoint Players = new PlayerPoint();
        GameRulePoint GameSettings = new GameRulePoint();
        
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
            GameSettings.StartNewGame(ref Players, this);
        }

        private void GetMoreButton_Click(object sender, EventArgs e)
        {
            GameSettings.GetMorePoint(ref Players, this);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            GameSettings.EndGame(ref Players, this);
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
            Player += RandomPoint.Next(this.FirstPoints, this.SecondPoints);
            // First - Min, Second - Max
        }
        public void EndGame(ref PlayerPoint Player, Form03_6 form)
        {
            while (Player.FirstPoints>Player.SecondPoints & Player.SecondPoints<TargetPoint)
            {
                PlayersPlusPoint(ref Player.SecondPoints);
                form.SetPlScore(2,Player.SecondPoints);
            }
            if (Player.FirstPoints <= Player.SecondPoints & Player.SecondPoints<=TargetPoint) GameEnded(false, ref Player, form);
            else GameEnded(true, ref Player, form);
        }
        public void StartNewGame(ref PlayerPoint Players, Form03_6 form)
        {
            Players.SetZero();
            form.Pl1Score.Text= "0";
            form.Pl2Score.Text= "0";
        }
        public void GameEnded(bool status, ref PlayerPoint player, Form03_6 form)
        {
            string Text;
            if (status) Text = $"You Win !!!\n Score: \n You: {player.FirstPoints}, \n PC: {player.SecondPoints}";
            else Text = $"You Lose :(\n  Score:\n You: {player.FirstPoints}, \n PC: {player.SecondPoints}";
            MessageBox.Show(Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartNewGame(ref player, form);
        }
        public void GetMorePoint(ref PlayerPoint Player, Form03_6 form)
        {
            PlayersPlusPoint(ref Player.FirstPoints);
            form.SetPlScore(1, Player.FirstPoints);
            if (Player.FirstPoints > TargetPoint)
            {
                PlayersPlusPoint(ref Player.SecondPoints);
                form.SetPlScore(2, Player.SecondPoints);
                GameEnded(false, ref Player, form);
            }
        }
    }
}