namespace GuessAWord
{
    partial class FrmMain
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
            this.LblHiddenWord = new System.Windows.Forms.Label();
            this.LblGuessALetter = new System.Windows.Forms.Label();
            this.LblNumberOfTries = new System.Windows.Forms.Label();
            this.TxtLetterGuess = new System.Windows.Forms.TextBox();
            this.TxtNumTries = new System.Windows.Forms.TextBox();
            this.LblLettersUsed = new System.Windows.Forms.Label();
            this.LblUsedLetters = new System.Windows.Forms.Label();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.ChkSoundEffects = new System.Windows.Forms.CheckBox();
            this.LblDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblHiddenWord
            // 
            this.LblHiddenWord.AutoSize = true;
            this.LblHiddenWord.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHiddenWord.Location = new System.Drawing.Point(12, 54);
            this.LblHiddenWord.Name = "LblHiddenWord";
            this.LblHiddenWord.Size = new System.Drawing.Size(131, 21);
            this.LblHiddenWord.TabIndex = 0;
            this.LblHiddenWord.Text = "Hidden Word";
            // 
            // LblGuessALetter
            // 
            this.LblGuessALetter.AutoSize = true;
            this.LblGuessALetter.Location = new System.Drawing.Point(13, 96);
            this.LblGuessALetter.Name = "LblGuessALetter";
            this.LblGuessALetter.Size = new System.Drawing.Size(75, 13);
            this.LblGuessALetter.TabIndex = 1;
            this.LblGuessALetter.Text = "Guess a letter.";
            // 
            // LblNumberOfTries
            // 
            this.LblNumberOfTries.AutoSize = true;
            this.LblNumberOfTries.Location = new System.Drawing.Point(13, 128);
            this.LblNumberOfTries.Name = "LblNumberOfTries";
            this.LblNumberOfTries.Size = new System.Drawing.Size(81, 13);
            this.LblNumberOfTries.TabIndex = 2;
            this.LblNumberOfTries.Text = "Number of tries.";
            // 
            // TxtLetterGuess
            // 
            this.TxtLetterGuess.Location = new System.Drawing.Point(125, 93);
            this.TxtLetterGuess.Name = "TxtLetterGuess";
            this.TxtLetterGuess.Size = new System.Drawing.Size(52, 20);
            this.TxtLetterGuess.TabIndex = 3;
            this.TxtLetterGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNumTries
            // 
            this.TxtNumTries.Location = new System.Drawing.Point(125, 128);
            this.TxtNumTries.Name = "TxtNumTries";
            this.TxtNumTries.ReadOnly = true;
            this.TxtNumTries.Size = new System.Drawing.Size(52, 20);
            this.TxtNumTries.TabIndex = 4;
            this.TxtNumTries.TabStop = false;
            this.TxtNumTries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblLettersUsed
            // 
            this.LblLettersUsed.AutoSize = true;
            this.LblLettersUsed.Location = new System.Drawing.Point(13, 181);
            this.LblLettersUsed.Name = "LblLettersUsed";
            this.LblLettersUsed.Size = new System.Drawing.Size(68, 13);
            this.LblLettersUsed.TabIndex = 5;
            this.LblLettersUsed.Text = "Letters used:";
            // 
            // LblUsedLetters
            // 
            this.LblUsedLetters.AutoSize = true;
            this.LblUsedLetters.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsedLetters.Location = new System.Drawing.Point(121, 173);
            this.LblUsedLetters.Name = "LblUsedLetters";
            this.LblUsedLetters.Size = new System.Drawing.Size(131, 21);
            this.LblUsedLetters.TabIndex = 6;
            this.LblUsedLetters.Text = "abcdefghijk";
            // 
            // BtnGuess
            // 
            this.BtnGuess.Location = new System.Drawing.Point(211, 80);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(78, 33);
            this.BtnGuess.TabIndex = 7;
            this.BtnGuess.Text = "Guess";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.Location = new System.Drawing.Point(308, 80);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(78, 33);
            this.BtnPlayAgain.TabIndex = 8;
            this.BtnPlayAgain.Text = "Play Again";
            this.BtnPlayAgain.UseVisualStyleBackColor = true;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(208, 135);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(83, 13);
            this.LblStatus.TabIndex = 9;
            this.LblStatus.Text = "Status Message";
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Location = new System.Drawing.Point(13, 18);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.LblPlayerName.TabIndex = 10;
            this.LblPlayerName.Text = "Player Name";
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.Location = new System.Drawing.Point(87, 18);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.TxtPlayerName.TabIndex = 11;
            // 
            // ChkSoundEffects
            // 
            this.ChkSoundEffects.AutoSize = true;
            this.ChkSoundEffects.Location = new System.Drawing.Point(211, 21);
            this.ChkSoundEffects.Name = "ChkSoundEffects";
            this.ChkSoundEffects.Size = new System.Drawing.Size(93, 17);
            this.ChkSoundEffects.TabIndex = 12;
            this.ChkSoundEffects.Text = "Sound Effects";
            this.ChkSoundEffects.UseVisualStyleBackColor = true;
            // 
            // LblDefinition
            // 
            this.LblDefinition.AutoSize = true;
            this.LblDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefinition.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblDefinition.Location = new System.Drawing.Point(13, 231);
            this.LblDefinition.Name = "LblDefinition";
            this.LblDefinition.Size = new System.Drawing.Size(66, 16);
            this.LblDefinition.TabIndex = 13;
            this.LblDefinition.Text = "Definition:";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 329);
            this.Controls.Add(this.LblDefinition);
            this.Controls.Add(this.ChkSoundEffects);
            this.Controls.Add(this.TxtPlayerName);
            this.Controls.Add(this.LblPlayerName);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.LblUsedLetters);
            this.Controls.Add(this.LblLettersUsed);
            this.Controls.Add(this.TxtNumTries);
            this.Controls.Add(this.TxtLetterGuess);
            this.Controls.Add(this.LblNumberOfTries);
            this.Controls.Add(this.LblGuessALetter);
            this.Controls.Add(this.LblHiddenWord);
            this.Name = "FrmMain";
            this.Text = "Guess A Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHiddenWord;
        private System.Windows.Forms.Label LblGuessALetter;
        private System.Windows.Forms.Label LblNumberOfTries;
        private System.Windows.Forms.TextBox TxtLetterGuess;
        private System.Windows.Forms.TextBox TxtNumTries;
        private System.Windows.Forms.Label LblLettersUsed;
        private System.Windows.Forms.Label LblUsedLetters;
        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.Button BtnPlayAgain;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.CheckBox ChkSoundEffects;
        private System.Windows.Forms.Label LblDefinition;
    }
}

