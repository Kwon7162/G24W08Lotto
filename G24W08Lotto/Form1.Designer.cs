﻿namespace G24W08Lotto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Num1 = new Label();
            Num2 = new Label();
            Num3 = new Label();
            Num4 = new Label();
            Num5 = new Label();
            Num6 = new Label();
            btnGenreate = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.BackColor = SystemColors.Info;
            Num1.Font = new Font("맑은 고딕", 36F);
            Num1.Location = new Point(12, -1);
            Num1.Name = "Num1";
            Num1.Size = new Size(170, 212);
            Num1.TabIndex = 0;
            Num1.Text = "0";
            Num1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num2
            // 
            Num2.BackColor = SystemColors.Info;
            Num2.Font = new Font("맑은 고딕", 36F);
            Num2.Location = new Point(202, -1);
            Num2.Name = "Num2";
            Num2.Size = new Size(164, 212);
            Num2.TabIndex = 1;
            Num2.Text = "0";
            Num2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num3
            // 
            Num3.BackColor = SystemColors.Info;
            Num3.Font = new Font("맑은 고딕", 36F);
            Num3.Location = new Point(381, -1);
            Num3.Name = "Num3";
            Num3.Size = new Size(169, 212);
            Num3.TabIndex = 2;
            Num3.Text = "0";
            Num3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num4
            // 
            Num4.BackColor = SystemColors.Info;
            Num4.Font = new Font("맑은 고딕", 36F);
            Num4.Location = new Point(566, -1);
            Num4.Name = "Num4";
            Num4.Size = new Size(172, 212);
            Num4.TabIndex = 3;
            Num4.Text = "0";
            Num4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num5
            // 
            Num5.BackColor = SystemColors.Info;
            Num5.Font = new Font("맑은 고딕", 36F);
            Num5.Location = new Point(754, -1);
            Num5.Name = "Num5";
            Num5.Size = new Size(161, 212);
            Num5.TabIndex = 4;
            Num5.Text = "0";
            Num5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num6
            // 
            Num6.BackColor = SystemColors.Info;
            Num6.Font = new Font("맑은 고딕", 36F);
            Num6.Location = new Point(932, -1);
            Num6.Name = "Num6";
            Num6.Size = new Size(153, 212);
            Num6.TabIndex = 5;
            Num6.Text = "0";
            Num6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenreate
            // 
            btnGenreate.Location = new Point(347, 224);
            btnGenreate.Name = "btnGenreate";
            btnGenreate.Size = new Size(351, 77);
            btnGenreate.TabIndex = 6;
            btnGenreate.Text = "번호 생성";
            btnGenreate.UseVisualStyleBackColor = true;
            btnGenreate.Click += OnGenerate;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 321);
            Controls.Add(btnGenreate);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(Num3);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Form1";
            Text = "로또";
            ResumeLayout(false);
        }

        #endregion

        private Label Num1;
        private Label Num2;
        private Label Num3;
        private Label Num4;
        private Label Num5;
        private Label Num6;
        private Button btnGenreate;
    }
}
