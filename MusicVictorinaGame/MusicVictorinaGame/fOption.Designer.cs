namespace MusicVictorinaGame
{
    partial class fOption
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.listBoxTrack = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBoxPath = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxSettingGame = new System.Windows.Forms.GroupBox();
            this.comboBoxPlayer2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayer1 = new System.Windows.Forms.ComboBox();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.checkBoxRandomStart = new System.Windows.Forms.CheckBox();
            this.comboBoxtlCallback = new System.Windows.Forms.ComboBox();
            this.comboBoxLeightGame = new System.Windows.Forms.ComboBox();
            this.labeltlCallback = new System.Windows.Forms.Label();
            this.labelLeightGame = new System.Windows.Forms.Label();
            this.groupBoxSettingGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 217);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Выбрать папку";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listBoxTrack
            // 
            this.listBoxTrack.FormattingEnabled = true;
            this.listBoxTrack.Location = new System.Drawing.Point(12, 12);
            this.listBoxTrack.Name = "listBoxTrack";
            this.listBoxTrack.Size = new System.Drawing.Size(450, 199);
            this.listBoxTrack.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBoxPath
            // 
            this.checkBoxPath.AutoSize = true;
            this.checkBoxPath.Location = new System.Drawing.Point(344, 221);
            this.checkBoxPath.Name = "checkBoxPath";
            this.checkBoxPath.Size = new System.Drawing.Size(118, 17);
            this.checkBoxPath.TabIndex = 3;
            this.checkBoxPath.Text = "Вложенные папки";
            this.checkBoxPath.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(387, 329);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxSettingGame
            // 
            this.groupBoxSettingGame.Controls.Add(this.comboBoxPlayer2);
            this.groupBoxSettingGame.Controls.Add(this.comboBoxPlayer1);
            this.groupBoxSettingGame.Controls.Add(this.lPlayer2);
            this.groupBoxSettingGame.Controls.Add(this.lPlayer1);
            this.groupBoxSettingGame.Controls.Add(this.checkBoxRandomStart);
            this.groupBoxSettingGame.Controls.Add(this.comboBoxtlCallback);
            this.groupBoxSettingGame.Controls.Add(this.comboBoxLeightGame);
            this.groupBoxSettingGame.Controls.Add(this.labeltlCallback);
            this.groupBoxSettingGame.Controls.Add(this.labelLeightGame);
            this.groupBoxSettingGame.Location = new System.Drawing.Point(12, 259);
            this.groupBoxSettingGame.Name = "groupBoxSettingGame";
            this.groupBoxSettingGame.Size = new System.Drawing.Size(369, 127);
            this.groupBoxSettingGame.TabIndex = 6;
            this.groupBoxSettingGame.TabStop = false;
            this.groupBoxSettingGame.Text = "Настройки игры";
            // 
            // comboBoxPlayer2
            // 
            this.comboBoxPlayer2.FormattingEnabled = true;
            this.comboBoxPlayer2.Location = new System.Drawing.Point(277, 70);
            this.comboBoxPlayer2.Name = "comboBoxPlayer2";
            this.comboBoxPlayer2.Size = new System.Drawing.Size(40, 21);
            this.comboBoxPlayer2.TabIndex = 8;
            this.comboBoxPlayer2.Text = "P";
            // 
            // comboBoxPlayer1
            // 
            this.comboBoxPlayer1.FormattingEnabled = true;
            this.comboBoxPlayer1.Location = new System.Drawing.Point(276, 40);
            this.comboBoxPlayer1.Name = "comboBoxPlayer1";
            this.comboBoxPlayer1.Size = new System.Drawing.Size(41, 21);
            this.comboBoxPlayer1.TabIndex = 7;
            this.comboBoxPlayer1.Text = "A";
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Location = new System.Drawing.Point(226, 73);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(44, 13);
            this.lPlayer2.TabIndex = 6;
            this.lPlayer2.Text = "Игрок2";
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Location = new System.Drawing.Point(226, 43);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(44, 13);
            this.lPlayer1.TabIndex = 5;
            this.lPlayer1.Text = "Игрок1";
            // 
            // checkBoxRandomStart
            // 
            this.checkBoxRandomStart.AutoSize = true;
            this.checkBoxRandomStart.Location = new System.Drawing.Point(6, 104);
            this.checkBoxRandomStart.Name = "checkBoxRandomStart";
            this.checkBoxRandomStart.Size = new System.Drawing.Size(133, 17);
            this.checkBoxRandomStart.TabIndex = 4;
            this.checkBoxRandomStart.Text = "Со случайного места";
            this.checkBoxRandomStart.UseVisualStyleBackColor = true;
            // 
            // comboBoxtlCallback
            // 
            this.comboBoxtlCallback.FormattingEnabled = true;
            this.comboBoxtlCallback.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.comboBoxtlCallback.Location = new System.Drawing.Point(168, 70);
            this.comboBoxtlCallback.Name = "comboBoxtlCallback";
            this.comboBoxtlCallback.Size = new System.Drawing.Size(41, 21);
            this.comboBoxtlCallback.TabIndex = 3;
            this.comboBoxtlCallback.Text = "20";
            // 
            // comboBoxLeightGame
            // 
            this.comboBoxLeightGame.FormattingEnabled = true;
            this.comboBoxLeightGame.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120"});
            this.comboBoxLeightGame.Location = new System.Drawing.Point(168, 40);
            this.comboBoxLeightGame.Name = "comboBoxLeightGame";
            this.comboBoxLeightGame.Size = new System.Drawing.Size(41, 21);
            this.comboBoxLeightGame.TabIndex = 2;
            this.comboBoxLeightGame.Text = "60";
            // 
            // labeltlCallback
            // 
            this.labeltlCallback.AutoSize = true;
            this.labeltlCallback.Location = new System.Drawing.Point(7, 73);
            this.labeltlCallback.Name = "labeltlCallback";
            this.labeltlCallback.Size = new System.Drawing.Size(86, 13);
            this.labeltlCallback.TabIndex = 1;
            this.labeltlCallback.Text = "Время на ответ";
            // 
            // labelLeightGame
            // 
            this.labelLeightGame.AutoSize = true;
            this.labelLeightGame.Location = new System.Drawing.Point(7, 43);
            this.labelLeightGame.Name = "labelLeightGame";
            this.labelLeightGame.Size = new System.Drawing.Size(139, 13);
            this.labelLeightGame.TabIndex = 0;
            this.labelLeightGame.Text = "Продолжительность игры";
            // 
            // fOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.groupBoxSettingGame);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkBoxPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxTrack);
            this.Controls.Add(this.btnLoad);
            this.Name = "fOption";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fOption_Load);
            this.groupBoxSettingGame.ResumeLayout(false);
            this.groupBoxSettingGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox listBoxTrack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBoxPath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxSettingGame;
        private System.Windows.Forms.CheckBox checkBoxRandomStart;
        private System.Windows.Forms.ComboBox comboBoxtlCallback;
        private System.Windows.Forms.ComboBox comboBoxLeightGame;
        private System.Windows.Forms.Label labeltlCallback;
        private System.Windows.Forms.Label labelLeightGame;
        private System.Windows.Forms.ComboBox comboBoxPlayer2;
        private System.Windows.Forms.ComboBox comboBoxPlayer1;
        private System.Windows.Forms.Label lPlayer2;
        private System.Windows.Forms.Label lPlayer1;
    }
}