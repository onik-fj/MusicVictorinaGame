namespace MusicVictorinaGame
{
    partial class fGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.btnNextTrack = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelMelodyCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lCountMusicDutarion = new System.Windows.Forms.Label();
            this.lShowAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextTrack
            // 
            this.btnNextTrack.Location = new System.Drawing.Point(22, 291);
            this.btnNextTrack.Name = "btnNextTrack";
            this.btnNextTrack.Size = new System.Drawing.Size(120, 40);
            this.btnNextTrack.TabIndex = 0;
            this.btnNextTrack.Text = "Следущая";
            this.btnNextTrack.UseVisualStyleBackColor = true;
            this.btnNextTrack.Click += new System.EventHandler(this.btnNextTrack_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(175, 291);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(120, 40);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(328, 291);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(120, 40);
            this.buttonContinue.TabIndex = 2;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(22, 355);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(214, 44);
            this.WMP.TabIndex = 3;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1.Location = new System.Drawing.Point(57, 67);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(73, 20);
            this.labelPlayer1.TabIndex = 4;
            this.labelPlayer1.Text = "Игрок 1";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum1.Location = new System.Drawing.Point(73, 134);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(19, 20);
            this.labelNum1.TabIndex = 5;
            this.labelNum1.Text = "0";
            this.labelNum1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelNum1_MouseClick);
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2.Location = new System.Drawing.Point(361, 67);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(73, 20);
            this.labelPlayer2.TabIndex = 6;
            this.labelPlayer2.Text = "Игрок 2";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum2.Location = new System.Drawing.Point(378, 134);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(19, 20);
            this.labelNum2.TabIndex = 7;
            this.labelNum2.Text = "0";
            this.labelNum2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelNum2_MouseClick);
            // 
            // labelMelodyCount
            // 
            this.labelMelodyCount.AutoSize = true;
            this.labelMelodyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMelodyCount.Location = new System.Drawing.Point(223, 134);
            this.labelMelodyCount.Name = "labelMelodyCount";
            this.labelMelodyCount.Size = new System.Drawing.Size(19, 20);
            this.labelMelodyCount.TabIndex = 8;
            this.labelMelodyCount.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lCountMusicDutarion
            // 
            this.lCountMusicDutarion.AutoSize = true;
            this.lCountMusicDutarion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountMusicDutarion.Location = new System.Drawing.Point(223, 67);
            this.lCountMusicDutarion.Name = "lCountMusicDutarion";
            this.lCountMusicDutarion.Size = new System.Drawing.Size(19, 20);
            this.lCountMusicDutarion.TabIndex = 10;
            this.lCountMusicDutarion.Text = "0";
            // 
            // lShowAnswer
            // 
            this.lShowAnswer.AutoSize = true;
            this.lShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lShowAnswer.Location = new System.Drawing.Point(19, 189);
            this.lShowAnswer.Name = "lShowAnswer";
            this.lShowAnswer.Size = new System.Drawing.Size(112, 16);
            this.lShowAnswer.TabIndex = 11;
            this.lShowAnswer.Text = "Показать ответ";
            this.lShowAnswer.Click += new System.EventHandler(this.lShowAnswer_Click);
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.lShowAnswer);
            this.Controls.Add(this.lCountMusicDutarion);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelMelodyCount);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.btnNextTrack);
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextTrack;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonContinue;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelMelodyCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lCountMusicDutarion;
        private System.Windows.Forms.Label lShowAnswer;
    }
}