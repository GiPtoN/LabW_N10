using System.ComponentModel;

namespace LabW_N10
{
    partial class Form02_01
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
            this.button1 = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(279, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(20, 23);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.X.Click += new System.EventHandler(this.label1_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(552, 272);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(20, 23);
            this.Y.TabIndex = 2;
            this.Y.Text = "Y";
            this.Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form02_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.button1);
            this.Name = "Form02_01";
            this.Text = "Form02_01";
            this.Load += new System.EventHandler(this.Form02_01_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form02_01_Paint);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Y;

        private System.Windows.Forms.Label X;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}