
namespace Paper_Stone_Sissors
{
    partial class Form1
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
            this.btnPcStone = new System.Windows.Forms.Button();
            this.btnPcPaper = new System.Windows.Forms.Button();
            this.btnPcScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWhoWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumbersOfRounds = new System.Windows.Forms.Label();
            this.lbOfPlyerWins = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbComputerWins = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRoundNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPlyerChoice = new System.Windows.Forms.Label();
            this.lbComputerChoice = new System.Windows.Forms.Label();
            this.btnPlyerClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPcStone
            // 
            this.btnPcStone.Image = global::Paper_Stone_Sissors.Properties.Resources.clipart_stone_a144;
            this.btnPcStone.Location = new System.Drawing.Point(805, 75);
            this.btnPcStone.Name = "btnPcStone";
            this.btnPcStone.Size = new System.Drawing.Size(271, 146);
            this.btnPcStone.TabIndex = 1;
            this.btnPcStone.Tag = "1";
            this.btnPcStone.Text = "btnPcStone";
            this.btnPcStone.UseVisualStyleBackColor = true;
            // 
            // btnPcPaper
            // 
            this.btnPcPaper.Image = global::Paper_Stone_Sissors.Properties.Resources.clipart_loose_leaf_paper_163a;
            this.btnPcPaper.Location = new System.Drawing.Point(805, 249);
            this.btnPcPaper.Name = "btnPcPaper";
            this.btnPcPaper.Size = new System.Drawing.Size(271, 147);
            this.btnPcPaper.TabIndex = 2;
            this.btnPcPaper.Tag = "2";
            this.btnPcPaper.Text = "button2";
            this.btnPcPaper.UseVisualStyleBackColor = true;
            // 
            // btnPcScissors
            // 
            this.btnPcScissors.Image = global::Paper_Stone_Sissors.Properties.Resources.تنزيل__2_;
            this.btnPcScissors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPcScissors.Location = new System.Drawing.Point(805, 424);
            this.btnPcScissors.Name = "btnPcScissors";
            this.btnPcScissors.Size = new System.Drawing.Size(271, 171);
            this.btnPcScissors.TabIndex = 3;
            this.btnPcScissors.Tag = "3";
            this.btnPcScissors.Text = "button3";
            this.btnPcScissors.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pc Choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plyer Choice";
            // 
            // btnScissors
            // 
            this.btnScissors.Image = global::Paper_Stone_Sissors.Properties.Resources.تنزيل__2_;
            this.btnScissors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScissors.Location = new System.Drawing.Point(39, 441);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(276, 146);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Tag = "3";
            this.btnScissors.Text = "btnScissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnPlyerClick_Click);
            this.btnScissors.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnStone
            // 
            this.btnStone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStone.Image = global::Paper_Stone_Sissors.Properties.Resources.clipart_stone_a144;
            this.btnStone.Location = new System.Drawing.Point(39, 75);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(276, 146);
            this.btnStone.TabIndex = 5;
            this.btnStone.Tag = "1";
            this.btnStone.Text = "button5";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnPlyerClick_Click);
            this.btnStone.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnPaper
            // 
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.Image = global::Paper_Stone_Sissors.Properties.Resources.clipart_loose_leaf_paper_163a;
            this.btnPaper.Location = new System.Drawing.Point(39, 258);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(276, 146);
            this.btnPaper.TabIndex = 4;
            this.btnPaper.Tag = "2";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPlyerClick_Click);
            this.btnPaper.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Paper_Stone_Sissors.Properties.Resources._360_F_136867817_J5Iszl5GdNlZpdaj9cJjS6CK883InG9x;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Winner  Name";
            // 
            // lbWhoWinner
            // 
            this.lbWhoWinner.AutoSize = true;
            this.lbWhoWinner.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhoWinner.Location = new System.Drawing.Point(575, 75);
            this.lbWhoWinner.Name = "lbWhoWinner";
            this.lbWhoWinner.Size = new System.Drawing.Size(31, 34);
            this.lbWhoWinner.TabIndex = 11;
            this.lbWhoWinner.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "NumsOfRounds: ";
            // 
            // lbNumbersOfRounds
            // 
            this.lbNumbersOfRounds.AutoSize = true;
            this.lbNumbersOfRounds.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbersOfRounds.Location = new System.Drawing.Point(592, 222);
            this.lbNumbersOfRounds.Name = "lbNumbersOfRounds";
            this.lbNumbersOfRounds.Size = new System.Drawing.Size(33, 34);
            this.lbNumbersOfRounds.TabIndex = 13;
            this.lbNumbersOfRounds.Text = "0";
            // 
            // lbOfPlyerWins
            // 
            this.lbOfPlyerWins.AutoSize = true;
            this.lbOfPlyerWins.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOfPlyerWins.Location = new System.Drawing.Point(592, 300);
            this.lbOfPlyerWins.Name = "lbOfPlyerWins";
            this.lbOfPlyerWins.Size = new System.Drawing.Size(33, 34);
            this.lbOfPlyerWins.TabIndex = 15;
            this.lbOfPlyerWins.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "Plyer Wins : ";
            // 
            // lbComputerWins
            // 
            this.lbComputerWins.AutoSize = true;
            this.lbComputerWins.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerWins.Location = new System.Drawing.Point(592, 370);
            this.lbComputerWins.Name = "lbComputerWins";
            this.lbComputerWins.Size = new System.Drawing.Size(33, 34);
            this.lbComputerWins.TabIndex = 17;
            this.lbComputerWins.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Computer Wins : ";
            // 
            // lbRoundNumber
            // 
            this.lbRoundNumber.AutoSize = true;
            this.lbRoundNumber.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoundNumber.Location = new System.Drawing.Point(623, 126);
            this.lbRoundNumber.Name = "lbRoundNumber";
            this.lbRoundNumber.Size = new System.Drawing.Size(33, 34);
            this.lbRoundNumber.TabIndex = 19;
            this.lbRoundNumber.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "Round  : ";
            // 
            // lbPlyerChoice
            // 
            this.lbPlyerChoice.AutoSize = true;
            this.lbPlyerChoice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlyerChoice.Location = new System.Drawing.Point(245, 32);
            this.lbPlyerChoice.Name = "lbPlyerChoice";
            this.lbPlyerChoice.Size = new System.Drawing.Size(24, 29);
            this.lbPlyerChoice.TabIndex = 20;
            this.lbPlyerChoice.Text = "?";
            // 
            // lbComputerChoice
            // 
            this.lbComputerChoice.AutoSize = true;
            this.lbComputerChoice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerChoice.Location = new System.Drawing.Point(982, 32);
            this.lbComputerChoice.Name = "lbComputerChoice";
            this.lbComputerChoice.Size = new System.Drawing.Size(24, 29);
            this.lbComputerChoice.TabIndex = 21;
            this.lbComputerChoice.Text = "?";
            // 
            // btnPlyerClick
            // 
            this.btnPlyerClick.Location = new System.Drawing.Point(1207, 39);
            this.btnPlyerClick.Name = "btnPlyerClick";
            this.btnPlyerClick.Size = new System.Drawing.Size(10, 23);
            this.btnPlyerClick.TabIndex = 22;
            this.btnPlyerClick.UseVisualStyleBackColor = true;
            this.btnPlyerClick.Click += new System.EventHandler(this.btnPlyerClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 668);
            this.Controls.Add(this.btnPlyerClick);
            this.Controls.Add(this.lbComputerChoice);
            this.Controls.Add(this.lbPlyerChoice);
            this.Controls.Add(this.lbRoundNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbComputerWins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOfPlyerWins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbNumbersOfRounds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbWhoWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnPcScissors);
            this.Controls.Add(this.btnPcPaper);
            this.Controls.Add(this.btnPcStone);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPcStone;
        private System.Windows.Forms.Button btnPcPaper;
        private System.Windows.Forms.Button btnPcScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWhoWinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumbersOfRounds;
        private System.Windows.Forms.Label lbOfPlyerWins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbComputerWins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbRoundNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPlyerChoice;
        private System.Windows.Forms.Label lbComputerChoice;
        private System.Windows.Forms.Button btnPlyerClick;
    }
}

