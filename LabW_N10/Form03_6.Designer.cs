using System.ComponentModel;

namespace LabW_N10
{
    partial class Form03_6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingGroupBox = new System.Windows.Forms.GroupBox();
            this.TargetScoreLable = new System.Windows.Forms.Label();
            this.MinPointBox = new System.Windows.Forms.TextBox();
            this.MaxPointLable = new System.Windows.Forms.Label();
            this.MaxPointBox = new System.Windows.Forms.TextBox();
            this.MinPointLable = new System.Windows.Forms.Label();
            this.TargetScoreBox = new System.Windows.Forms.TextBox();
            this.SetNumbersButton = new System.Windows.Forms.Button();
            this.GameGroupBox = new System.Windows.Forms.GroupBox();
            this.Pl2Score = new System.Windows.Forms.Label();
            this.Pl1Score = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Player2Lable = new System.Windows.Forms.Label();
            this.Player1Lable = new System.Windows.Forms.Label();
            this.StartNewGameButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.GetMoreButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SettingGroupBox.SuspendLayout();
            this.GameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingGroupBox
            // 
            this.SettingGroupBox.Controls.Add(this.TargetScoreLable);
            this.SettingGroupBox.Controls.Add(this.MinPointBox);
            this.SettingGroupBox.Controls.Add(this.MaxPointLable);
            this.SettingGroupBox.Controls.Add(this.MaxPointBox);
            this.SettingGroupBox.Controls.Add(this.MinPointLable);
            this.SettingGroupBox.Controls.Add(this.TargetScoreBox);
            this.SettingGroupBox.Controls.Add(this.SetNumbersButton);
            this.SettingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettingGroupBox.Name = "SettingGroupBox";
            this.SettingGroupBox.Size = new System.Drawing.Size(329, 93);
            this.SettingGroupBox.TabIndex = 18;
            this.SettingGroupBox.TabStop = false;
            this.SettingGroupBox.Text = "Settings";
            // 
            // TargetScoreLable
            // 
            this.TargetScoreLable.Location = new System.Drawing.Point(218, 18);
            this.TargetScoreLable.Name = "TargetScoreLable";
            this.TargetScoreLable.Size = new System.Drawing.Size(100, 17);
            this.TargetScoreLable.TabIndex = 14;
            this.TargetScoreLable.Text = "Target Score";
            this.TargetScoreLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinPointBox
            // 
            this.MinPointBox.Location = new System.Drawing.Point(6, 38);
            this.MinPointBox.Name = "MinPointBox";
            this.MinPointBox.Size = new System.Drawing.Size(100, 20);
            this.MinPointBox.TabIndex = 0;
            // 
            // MaxPointLable
            // 
            this.MaxPointLable.Location = new System.Drawing.Point(112, 18);
            this.MaxPointLable.Name = "MaxPointLable";
            this.MaxPointLable.Size = new System.Drawing.Size(100, 17);
            this.MaxPointLable.TabIndex = 13;
            this.MaxPointLable.Text = "Max Point";
            this.MaxPointLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxPointBox
            // 
            this.MaxPointBox.Location = new System.Drawing.Point(112, 38);
            this.MaxPointBox.Name = "MaxPointBox";
            this.MaxPointBox.Size = new System.Drawing.Size(100, 20);
            this.MaxPointBox.TabIndex = 1;
            // 
            // MinPointLable
            // 
            this.MinPointLable.Location = new System.Drawing.Point(6, 19);
            this.MinPointLable.Name = "MinPointLable";
            this.MinPointLable.Size = new System.Drawing.Size(100, 14);
            this.MinPointLable.TabIndex = 12;
            this.MinPointLable.Text = "Min Point";
            this.MinPointLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetScoreBox
            // 
            this.TargetScoreBox.Location = new System.Drawing.Point(218, 38);
            this.TargetScoreBox.Name = "TargetScoreBox";
            this.TargetScoreBox.Size = new System.Drawing.Size(100, 20);
            this.TargetScoreBox.TabIndex = 2;
            // 
            // SetNumbersButton
            // 
            this.SetNumbersButton.Location = new System.Drawing.Point(6, 64);
            this.SetNumbersButton.Name = "SetNumbersButton";
            this.SetNumbersButton.Size = new System.Drawing.Size(312, 23);
            this.SetNumbersButton.TabIndex = 8;
            this.SetNumbersButton.Text = "Set Numbers";
            this.SetNumbersButton.UseVisualStyleBackColor = true;
            this.SetNumbersButton.Click += new System.EventHandler(this.SetNumbersButton_Click);
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Controls.Add(this.Pl2Score);
            this.GameGroupBox.Controls.Add(this.Pl1Score);
            this.GameGroupBox.Controls.Add(this.ScoreLabel);
            this.GameGroupBox.Controls.Add(this.Player2Lable);
            this.GameGroupBox.Controls.Add(this.Player1Lable);
            this.GameGroupBox.Controls.Add(this.StartNewGameButton);
            this.GameGroupBox.Controls.Add(this.ReturnButton);
            this.GameGroupBox.Controls.Add(this.GetMoreButton);
            this.GameGroupBox.Controls.Add(this.StopButton);
            this.GameGroupBox.Location = new System.Drawing.Point(12, 111);
            this.GameGroupBox.Name = "GameGroupBox";
            this.GameGroupBox.Size = new System.Drawing.Size(329, 160);
            this.GameGroupBox.TabIndex = 19;
            this.GameGroupBox.TabStop = false;
            this.GameGroupBox.Text = "Game";
            // 
            // Pl2Score
            // 
            this.Pl2Score.Location = new System.Drawing.Point(185, 36);
            this.Pl2Score.Name = "Pl2Score";
            this.Pl2Score.Size = new System.Drawing.Size(77, 20);
            this.Pl2Score.TabIndex = 16;
            this.Pl2Score.Text = "0";
            this.Pl2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pl1Score
            // 
            this.Pl1Score.Location = new System.Drawing.Point(62, 36);
            this.Pl1Score.Name = "Pl1Score";
            this.Pl1Score.Size = new System.Drawing.Size(77, 20);
            this.Pl1Score.TabIndex = 15;
            this.Pl1Score.Text = "0";
            this.Pl1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Location = new System.Drawing.Point(6, 36);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(38, 19);
            this.ScoreLabel.TabIndex = 14;
            this.ScoreLabel.Text = "Score";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2Lable
            // 
            this.Player2Lable.Location = new System.Drawing.Point(167, 16);
            this.Player2Lable.Name = "Player2Lable";
            this.Player2Lable.Size = new System.Drawing.Size(118, 20);
            this.Player2Lable.TabIndex = 13;
            this.Player2Lable.Text = "Player 2";
            this.Player2Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1Lable
            // 
            this.Player1Lable.Location = new System.Drawing.Point(43, 16);
            this.Player1Lable.Name = "Player1Lable";
            this.Player1Lable.Size = new System.Drawing.Size(118, 20);
            this.Player1Lable.TabIndex = 12;
            this.Player1Lable.Text = "Player 1";
            this.Player1Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartNewGameButton
            // 
            this.StartNewGameButton.Location = new System.Drawing.Point(6, 68);
            this.StartNewGameButton.Name = "StartNewGameButton";
            this.StartNewGameButton.Size = new System.Drawing.Size(312, 23);
            this.StartNewGameButton.TabIndex = 4;
            this.StartNewGameButton.Text = " Start New Game";
            this.StartNewGameButton.UseVisualStyleBackColor = true;
            this.StartNewGameButton.Click += new System.EventHandler(this.StartNewGameButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(6, 126);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(312, 23);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Close";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // GetMoreButton
            // 
            this.GetMoreButton.Location = new System.Drawing.Point(6, 97);
            this.GetMoreButton.Name = "GetMoreButton";
            this.GetMoreButton.Size = new System.Drawing.Size(155, 23);
            this.GetMoreButton.TabIndex = 5;
            this.GetMoreButton.Text = "Get more";
            this.GetMoreButton.UseVisualStyleBackColor = true;
            this.GetMoreButton.Click += new System.EventHandler(this.GetMoreButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(167, 97);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(151, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form03_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 282);
            this.Controls.Add(this.GameGroupBox);
            this.Controls.Add(this.SettingGroupBox);
            this.Name = "Form03_6";
            this.Text = "Form03_6";
            this.Load += new System.EventHandler(this.Form03_6_Load);
            this.SettingGroupBox.ResumeLayout(false);
            this.SettingGroupBox.PerformLayout();
            this.GameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label MaxPointLable;
        private System.Windows.Forms.Label MinPointLable;

        private System.Windows.Forms.Label TargetScoreLable;

        private System.Windows.Forms.GroupBox GameGroupBox;
        public System.Windows.Forms.Label Pl2Score;
        public System.Windows.Forms.Label Pl1Score;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label Player2Lable;
        private System.Windows.Forms.Label Player1Lable;
        private System.Windows.Forms.Button StartNewGameButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button GetMoreButton;
        private System.Windows.Forms.Button StopButton;

        private System.Windows.Forms.GroupBox SettingGroupBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MinPointBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox MaxPointBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TargetScoreBox;
        private System.Windows.Forms.Button SetNumbersButton;

        #endregion
    }
}