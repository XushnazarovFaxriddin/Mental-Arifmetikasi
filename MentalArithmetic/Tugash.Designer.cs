﻿namespace MentalArithmetic
{
    partial class Tugash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hisobTxt = new System.Windows.Forms.Label();
            this.BoshSahifaBtn = new System.Windows.Forms.Button();
            this.qaytaOynashBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "O\'yin tugadi!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sizning hisobingiz:";
            // 
            // hisobTxt
            // 
            this.hisobTxt.AutoSize = true;
            this.hisobTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hisobTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hisobTxt.Location = new System.Drawing.Point(439, 87);
            this.hisobTxt.Name = "hisobTxt";
            this.hisobTxt.Size = new System.Drawing.Size(42, 48);
            this.hisobTxt.TabIndex = 2;
            this.hisobTxt.Text = "0";
            // 
            // BoshSahifaBtn
            // 
            this.BoshSahifaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoshSahifaBtn.Location = new System.Drawing.Point(59, 158);
            this.BoshSahifaBtn.Name = "BoshSahifaBtn";
            this.BoshSahifaBtn.Size = new System.Drawing.Size(240, 63);
            this.BoshSahifaBtn.TabIndex = 3;
            this.BoshSahifaBtn.Text = "Menyu";
            this.BoshSahifaBtn.UseVisualStyleBackColor = true;
            this.BoshSahifaBtn.Click += new System.EventHandler(this.BoshSahifaBtn_Click);
            // 
            // qaytaOynashBtn
            // 
            this.qaytaOynashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qaytaOynashBtn.Location = new System.Drawing.Point(305, 158);
            this.qaytaOynashBtn.Name = "qaytaOynashBtn";
            this.qaytaOynashBtn.Size = new System.Drawing.Size(240, 63);
            this.qaytaOynashBtn.TabIndex = 4;
            this.qaytaOynashBtn.Text = "Qayta o\'ynash";
            this.qaytaOynashBtn.UseVisualStyleBackColor = true;
            this.qaytaOynashBtn.Click += new System.EventHandler(this.qaytaOynashBtn_Click);
            // 
            // Tugash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(612, 252);
            this.Controls.Add(this.qaytaOynashBtn);
            this.Controls.Add(this.BoshSahifaBtn);
            this.Controls.Add(this.hisobTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tugash";
            this.Text = "Tugash";
            this.Load += new System.EventHandler(this.Tugash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hisobTxt;
        private System.Windows.Forms.Button BoshSahifaBtn;
        private System.Windows.Forms.Button qaytaOynashBtn;
    }
}