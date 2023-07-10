namespace Data_Structures_And_Algorithms
{
    partial class WorkSpace
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxMın = new System.Windows.Forms.TextBox();
            this.textboxMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnLower = new System.Windows.Forms.Button();
            this.lblMyGuess = new System.Windows.Forms.Label();
            this.BtnHigher = new System.Windows.Forms.Button();
            this.BtnCorrect = new System.Windows.Forms.Button();
            this.LblFac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxMın
            // 
            this.textboxMın.Location = new System.Drawing.Point(83, 39);
            this.textboxMın.Name = "textboxMın";
            this.textboxMın.Size = new System.Drawing.Size(100, 26);
            this.textboxMın.TabIndex = 0;
            // 
            // textboxMax
            // 
            this.textboxMax.Location = new System.Drawing.Point(83, 81);
            this.textboxMax.Name = "textboxMax";
            this.textboxMax.Size = new System.Drawing.Size(100, 26);
            this.textboxMax.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MIN:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPlay);
            this.groupBox1.Controls.Add(this.textboxMın);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxMax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervals";
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(96)))));
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPlay.Location = new System.Drawing.Point(208, 52);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(96, 43);
            this.BtnPlay.TabIndex = 8;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnLower
            // 
            this.BtnLower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(19)))), ((int)(((byte)(85)))));
            this.BtnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLower.Location = new System.Drawing.Point(198, 301);
            this.BtnLower.Name = "BtnLower";
            this.BtnLower.Size = new System.Drawing.Size(81, 44);
            this.BtnLower.TabIndex = 6;
            this.BtnLower.Text = "Lower";
            this.BtnLower.UseVisualStyleBackColor = false;
            this.BtnLower.Click += new System.EventHandler(this.BtnLower_Click);
            // 
            // lblMyGuess
            // 
            this.lblMyGuess.AutoSize = true;
            this.lblMyGuess.Location = new System.Drawing.Point(101, 187);
            this.lblMyGuess.Name = "lblMyGuess";
            this.lblMyGuess.Size = new System.Drawing.Size(88, 20);
            this.lblMyGuess.TabIndex = 4;
            this.lblMyGuess.Text = "My Guess";
            // 
            // BtnHigher
            // 
            this.BtnHigher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.BtnHigher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHigher.ForeColor = System.Drawing.Color.Black;
            this.BtnHigher.Location = new System.Drawing.Point(87, 301);
            this.BtnHigher.Name = "BtnHigher";
            this.BtnHigher.Size = new System.Drawing.Size(81, 44);
            this.BtnHigher.TabIndex = 5;
            this.BtnHigher.Text = "Higher";
            this.BtnHigher.UseVisualStyleBackColor = false;
            this.BtnHigher.Click += new System.EventHandler(this.BtnHigher_Click);
            // 
            // BtnCorrect
            // 
            this.BtnCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(232)))), ((int)(((byte)(216)))));
            this.BtnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorrect.ForeColor = System.Drawing.Color.Black;
            this.BtnCorrect.Location = new System.Drawing.Point(87, 364);
            this.BtnCorrect.Name = "BtnCorrect";
            this.BtnCorrect.Size = new System.Drawing.Size(192, 44);
            this.BtnCorrect.TabIndex = 7;
            this.BtnCorrect.Text = "Correct!";
            this.BtnCorrect.UseVisualStyleBackColor = false;
            this.BtnCorrect.Click += new System.EventHandler(this.BtnCorrect_Click);
            // 
            // LblFac
            // 
            this.LblFac.AutoSize = true;
            this.LblFac.Location = new System.Drawing.Point(247, 252);
            this.LblFac.Name = "LblFac";
            this.LblFac.Size = new System.Drawing.Size(0, 20);
            this.LblFac.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Factorial of step:";
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(405, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblFac);
            this.Controls.Add(this.BtnCorrect);
            this.Controls.Add(this.lblMyGuess);
            this.Controls.Add(this.BtnLower);
            this.Controls.Add(this.BtnHigher);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WorkSpace";
            this.Text = "Guesser";
            this.Load += new System.EventHandler(this.WorkSpace_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxMın;
        private System.Windows.Forms.TextBox textboxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLower;
        private System.Windows.Forms.Label lblMyGuess;
        private System.Windows.Forms.Button BtnHigher;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnCorrect;
        private System.Windows.Forms.Label LblFac;
        private System.Windows.Forms.Label label3;
    }
}

