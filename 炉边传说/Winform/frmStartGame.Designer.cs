﻿namespace 炉边传说
{
    partial class frmStartGame
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
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.lstWaitGuest = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardPath = new System.Windows.Forms.TextBox();
            this.btnPickCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.btnCreateCard = new System.Windows.Forms.Button();
            this.btnCreateCardDeck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCardDeck = new System.Windows.Forms.ComboBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnTestCrystal = new System.Windows.Forms.Button();
            this.crystalCount = new System.Windows.Forms.NumericUpDown();
            this.btnTestHandCard = new System.Windows.Forms.Button();
            this.cmbHandCard = new System.Windows.Forms.ComboBox();
            this.btnSingleGameDefance = new System.Windows.Forms.Button();
            this.btnSingleGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crystalCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(18, 194);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(119, 23);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "新建一局游戏";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // lstWaitGuest
            // 
            this.lstWaitGuest.FormattingEnabled = true;
            this.lstWaitGuest.Location = new System.Drawing.Point(18, 223);
            this.lstWaitGuest.Name = "lstWaitGuest";
            this.lstWaitGuest.Size = new System.Drawing.Size(499, 95);
            this.lstWaitGuest.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(398, 194);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Location = new System.Drawing.Point(137, 194);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(119, 23);
            this.btnJoinGame.TabIndex = 3;
            this.btnJoinGame.Text = "加入一局游戏";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "卡牌文件夹：";
            // 
            // txtCardPath
            // 
            this.txtCardPath.Location = new System.Drawing.Point(102, 12);
            this.txtCardPath.Name = "txtCardPath";
            this.txtCardPath.Size = new System.Drawing.Size(286, 20);
            this.txtCardPath.TabIndex = 5;
            // 
            // btnPickCard
            // 
            this.btnPickCard.Location = new System.Drawing.Point(398, 10);
            this.btnPickCard.Name = "btnPickCard";
            this.btnPickCard.Size = new System.Drawing.Size(113, 23);
            this.btnPickCard.TabIndex = 6;
            this.btnPickCard.Text = "选择..";
            this.btnPickCard.UseVisualStyleBackColor = true;
            this.btnPickCard.Click += new System.EventHandler(this.btnPickCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "服务器IP地址";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(106, 134);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(282, 20);
            this.txtServerIP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "用户昵称";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(106, 165);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(282, 20);
            this.txtNickName.TabIndex = 10;
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Location = new System.Drawing.Point(398, 39);
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.Size = new System.Drawing.Size(113, 23);
            this.btnCreateCard.TabIndex = 11;
            this.btnCreateCard.Text = "卡牌资料生成";
            this.btnCreateCard.UseVisualStyleBackColor = true;
            this.btnCreateCard.Click += new System.EventHandler(this.btnCreateCard_Click);
            // 
            // btnCreateCardDeck
            // 
            this.btnCreateCardDeck.Location = new System.Drawing.Point(398, 68);
            this.btnCreateCardDeck.Name = "btnCreateCardDeck";
            this.btnCreateCardDeck.Size = new System.Drawing.Size(113, 23);
            this.btnCreateCardDeck.TabIndex = 12;
            this.btnCreateCardDeck.Text = "套牌构成";
            this.btnCreateCardDeck.UseVisualStyleBackColor = true;
            this.btnCreateCardDeck.Click += new System.EventHandler(this.btnCreateCardDeck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "我的套牌";
            // 
            // cmbCardDeck
            // 
            this.cmbCardDeck.FormattingEnabled = true;
            this.cmbCardDeck.Location = new System.Drawing.Point(101, 68);
            this.cmbCardDeck.Name = "cmbCardDeck";
            this.cmbCardDeck.Size = new System.Drawing.Size(282, 21);
            this.cmbCardDeck.TabIndex = 14;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(398, 132);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(113, 23);
            this.btnServer.TabIndex = 15;
            this.btnServer.Text = "服务器界面";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnTestCrystal
            // 
            this.btnTestCrystal.Location = new System.Drawing.Point(12, 325);
            this.btnTestCrystal.Name = "btnTestCrystal";
            this.btnTestCrystal.Size = new System.Drawing.Size(167, 23);
            this.btnTestCrystal.TabIndex = 16;
            this.btnTestCrystal.Text = "测试环境：起始状态水晶数";
            this.btnTestCrystal.UseVisualStyleBackColor = true;
            this.btnTestCrystal.Click += new System.EventHandler(this.btnTestCrystal_Click);
            // 
            // crystalCount
            // 
            this.crystalCount.Location = new System.Drawing.Point(206, 327);
            this.crystalCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.crystalCount.Name = "crystalCount";
            this.crystalCount.Size = new System.Drawing.Size(121, 20);
            this.crystalCount.TabIndex = 18;
            this.crystalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.crystalCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnTestHandCard
            // 
            this.btnTestHandCard.Location = new System.Drawing.Point(12, 354);
            this.btnTestHandCard.Name = "btnTestHandCard";
            this.btnTestHandCard.Size = new System.Drawing.Size(167, 23);
            this.btnTestHandCard.TabIndex = 19;
            this.btnTestHandCard.Text = "测试环境：增加手牌";
            this.btnTestHandCard.UseVisualStyleBackColor = true;
            this.btnTestHandCard.Click += new System.EventHandler(this.btnTestHandCard_Click);
            // 
            // cmbHandCard
            // 
            this.cmbHandCard.FormattingEnabled = true;
            this.cmbHandCard.Location = new System.Drawing.Point(206, 356);
            this.cmbHandCard.Name = "cmbHandCard";
            this.cmbHandCard.Size = new System.Drawing.Size(121, 21);
            this.cmbHandCard.TabIndex = 20;
            // 
            // btnSingleGameDefance
            // 
            this.btnSingleGameDefance.Location = new System.Drawing.Point(164, 39);
            this.btnSingleGameDefance.Name = "btnSingleGameDefance";
            this.btnSingleGameDefance.Size = new System.Drawing.Size(158, 23);
            this.btnSingleGameDefance.TabIndex = 21;
            this.btnSingleGameDefance.Text = "单机游戏【塔防模式】";
            this.btnSingleGameDefance.UseVisualStyleBackColor = true;
            this.btnSingleGameDefance.Click += new System.EventHandler(this.btnSingleGameDefance_Click);
            // 
            // btnSingleGame
            // 
            this.btnSingleGame.Location = new System.Drawing.Point(398, 97);
            this.btnSingleGame.Name = "btnSingleGame";
            this.btnSingleGame.Size = new System.Drawing.Size(113, 23);
            this.btnSingleGame.TabIndex = 22;
            this.btnSingleGame.Text = "单机游戏【标准】";
            this.btnSingleGame.UseVisualStyleBackColor = true;
            this.btnSingleGame.Click += new System.EventHandler(this.btnSingleGame_Click);
            // 
            // frmStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 387);
            this.Controls.Add(this.btnSingleGame);
            this.Controls.Add(this.btnSingleGameDefance);
            this.Controls.Add(this.cmbHandCard);
            this.Controls.Add(this.btnTestHandCard);
            this.Controls.Add(this.crystalCount);
            this.Controls.Add(this.btnTestCrystal);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.cmbCardDeck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreateCardDeck);
            this.Controls.Add(this.btnCreateCard);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPickCard);
            this.Controls.Add(this.txtCardPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJoinGame);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstWaitGuest);
            this.Controls.Add(this.btnCreateGame);
            this.Name = "frmStartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "开始游戏";
            this.Load += new System.EventHandler(this.frmStartGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crystalCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.ListBox lstWaitGuest;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardPath;
        private System.Windows.Forms.Button btnPickCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Button btnCreateCard;
        private System.Windows.Forms.Button btnCreateCardDeck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCardDeck;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnTestCrystal;
        private System.Windows.Forms.NumericUpDown crystalCount;
        private System.Windows.Forms.Button btnTestHandCard;
        private System.Windows.Forms.ComboBox cmbHandCard;
        private System.Windows.Forms.Button btnSingleGameDefance;
        private System.Windows.Forms.Button btnSingleGame;
    }
}