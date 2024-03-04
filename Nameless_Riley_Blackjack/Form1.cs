using System;
using System.Windows.Forms;

namespace Nameless_Riley_Blackjack
{
    internal class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblscore;
        private Label lblscore2;
        private Button btnhit;
        private HelpProvider helpProvider1;
        private Button btnstand;
        private Button NewGm;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox4;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.btnhit = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnstand = new System.Windows.Forms.Button();
            this.NewGm = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEALER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAYER";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Blue;
            this.lblscore.ForeColor = System.Drawing.Color.White;
            this.lblscore.Location = new System.Drawing.Point(582, 253);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(135, 38);
            this.lblscore.TabIndex = 6;
            this.lblscore.Text = "SCORE";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.BackColor = System.Drawing.Color.Blue;
            this.lblscore2.ForeColor = System.Drawing.Color.White;
            this.lblscore2.Location = new System.Drawing.Point(582, 355);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(135, 38);
            this.lblscore2.TabIndex = 7;
            this.lblscore2.Text = "SCORE";
            // 
            // btnhit
            // 
            this.btnhit.AutoSize = true;
            this.btnhit.BackColor = System.Drawing.Color.Lime;
            this.btnhit.Location = new System.Drawing.Point(501, 527);
            this.btnhit.Name = "btnhit";
            this.btnhit.Size = new System.Drawing.Size(112, 48);
            this.btnhit.TabIndex = 8;
            this.btnhit.Text = "HIT";
            this.btnhit.UseVisualStyleBackColor = false;
            // 
            // btnstand
            // 
            this.btnstand.AutoSize = true;
            this.btnstand.BackColor = System.Drawing.Color.Red;
            this.btnstand.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnstand.ForeColor = System.Drawing.Color.White;
            this.btnstand.Location = new System.Drawing.Point(640, 527);
            this.btnstand.Name = "btnstand";
            this.btnstand.Size = new System.Drawing.Size(139, 48);
            this.btnstand.TabIndex = 9;
            this.btnstand.Text = "STAND";
            this.btnstand.UseVisualStyleBackColor = false;
            // 
            // NewGm
            // 
            this.NewGm.AutoSize = true;
            this.NewGm.BackColor = System.Drawing.Color.Yellow;
            this.NewGm.Location = new System.Drawing.Point(553, 33);
            this.NewGm.Name = "NewGm";
            this.NewGm.Size = new System.Drawing.Size(210, 48);
            this.NewGm.TabIndex = 10;
            this.NewGm.Text = "NEW GAME";
            this.NewGm.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Nameless_Riley_Blackjack.Properties.Resources._3_of_clubs;
            this.pictureBox10.Location = new System.Drawing.Point(12, 150);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 141);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Nameless_Riley_Blackjack.Properties.Resources._5_of_clubs;
            this.pictureBox9.Location = new System.Drawing.Point(75, 132);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 141);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Nameless_Riley_Blackjack.Properties.Resources._4_of_spades;
            this.pictureBox8.Location = new System.Drawing.Point(52, 84);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 141);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Nameless_Riley_Blackjack.Properties.Resources._2_of_hearts;
            this.pictureBox7.Location = new System.Drawing.Point(36, 481);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 149);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Nameless_Riley_Blackjack.Properties.Resources._4_of_clubs;
            this.pictureBox6.Location = new System.Drawing.Point(52, 426);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 149);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Nameless_Riley_Blackjack.Properties.Resources._7_of_spades;
            this.pictureBox5.Location = new System.Drawing.Point(12, 443);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Nameless_Riley_Blackjack.Properties.Resources.ace_of_clubs;
            this.pictureBox4.Location = new System.Drawing.Point(338, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 141);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Nameless_Riley_Blackjack.Properties.Resources._2_of_clubs;
            this.pictureBox3.Location = new System.Drawing.Point(232, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nameless_Riley_Blackjack.Properties.Resources.king_of_hearts2;
            this.pictureBox2.Location = new System.Drawing.Point(338, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nameless_Riley_Blackjack.Properties.Resources._6_of_clubs;
            this.pictureBox1.Location = new System.Drawing.Point(225, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(803, 662);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.NewGm);
            this.Controls.Add(this.btnstand);
            this.Controls.Add(this.btnhit);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}