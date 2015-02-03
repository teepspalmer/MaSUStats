namespace Demo_Forms
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
            this.txtOpponent = new System.Windows.Forms.TextBox();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUsScore = new System.Windows.Forms.Label();
            this.txtOurPoints = new System.Windows.Forms.TextBox();
            this.txtOppPts = new System.Windows.Forms.TextBox();
            this.lblOppPts = new System.Windows.Forms.Label();
            this.chkWin = new System.Windows.Forms.CheckBox();
            this.drpPlayers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFGAtt = new System.Windows.Forms.TextBox();
            this.txtFGMade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveStats = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFoulPersonal = new System.Windows.Forms.TextBox();
            this.txtFoulTechnical = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFTAtt = new System.Windows.Forms.TextBox();
            this.txtFTMade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgStats = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldGoalsAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldGoalsMade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeThrowsAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeThrowsMade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalFoul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnicalFouls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStats)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpponent
            // 
            this.txtOpponent.Location = new System.Drawing.Point(108, 12);
            this.txtOpponent.Name = "txtOpponent";
            this.txtOpponent.Size = new System.Drawing.Size(192, 20);
            this.txtOpponent.TabIndex = 0;
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(46, 15);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(57, 13);
            this.lblOpponent.TabIndex = 1;
            this.lblOpponent.Text = "Opponent:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUsScore
            // 
            this.lblUsScore.AutoSize = true;
            this.lblUsScore.Location = new System.Drawing.Point(46, 47);
            this.lblUsScore.Name = "lblUsScore";
            this.lblUsScore.Size = new System.Drawing.Size(45, 13);
            this.lblUsScore.TabIndex = 1;
            this.lblUsScore.Text = "Our Pts:";
            // 
            // txtOurPoints
            // 
            this.txtOurPoints.Location = new System.Drawing.Point(108, 44);
            this.txtOurPoints.Name = "txtOurPoints";
            this.txtOurPoints.Size = new System.Drawing.Size(32, 20);
            this.txtOurPoints.TabIndex = 0;
            // 
            // txtOppPts
            // 
            this.txtOppPts.Location = new System.Drawing.Point(236, 44);
            this.txtOppPts.Name = "txtOppPts";
            this.txtOppPts.Size = new System.Drawing.Size(32, 20);
            this.txtOppPts.TabIndex = 0;
            // 
            // lblOppPts
            // 
            this.lblOppPts.AutoSize = true;
            this.lblOppPts.Location = new System.Drawing.Point(174, 47);
            this.lblOppPts.Name = "lblOppPts";
            this.lblOppPts.Size = new System.Drawing.Size(48, 13);
            this.lblOppPts.TabIndex = 1;
            this.lblOppPts.Text = "Opp Pts:";
            // 
            // chkWin
            // 
            this.chkWin.AutoSize = true;
            this.chkWin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkWin.Location = new System.Drawing.Point(338, 47);
            this.chkWin.Name = "chkWin";
            this.chkWin.Size = new System.Drawing.Size(49, 17);
            this.chkWin.TabIndex = 3;
            this.chkWin.Text = "Won";
            this.chkWin.UseVisualStyleBackColor = true;
            // 
            // drpPlayers
            // 
            this.drpPlayers.FormattingEnabled = true;
            this.drpPlayers.Location = new System.Drawing.Point(53, 19);
            this.drpPlayers.Name = "drpPlayers";
            this.drpPlayers.Size = new System.Drawing.Size(121, 21);
            this.drpPlayers.TabIndex = 4;
            this.drpPlayers.SelectedIndexChanged += new System.EventHandler(this.drpPlayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Att";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Made";
            // 
            // txtFGAtt
            // 
            this.txtFGAtt.Location = new System.Drawing.Point(52, 13);
            this.txtFGAtt.Name = "txtFGAtt";
            this.txtFGAtt.Size = new System.Drawing.Size(32, 20);
            this.txtFGAtt.TabIndex = 5;
            // 
            // txtFGMade
            // 
            this.txtFGMade.Location = new System.Drawing.Point(52, 35);
            this.txtFGMade.Name = "txtFGMade";
            this.txtFGMade.Size = new System.Drawing.Size(32, 20);
            this.txtFGMade.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveStats);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.drpPlayers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Stats";
            // 
            // btnSaveStats
            // 
            this.btnSaveStats.Location = new System.Drawing.Point(586, 22);
            this.btnSaveStats.Name = "btnSaveStats";
            this.btnSaveStats.Size = new System.Drawing.Size(75, 57);
            this.btnSaveStats.TabIndex = 8;
            this.btnSaveStats.Text = "Save Stats";
            this.btnSaveStats.UseVisualStyleBackColor = true;
            this.btnSaveStats.Click += new System.EventHandler(this.btnSaveStats_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtFoulPersonal);
            this.groupBox4.Controls.Add(this.txtFoulTechnical);
            this.groupBox4.Location = new System.Drawing.Point(459, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 63);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fouls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Technical";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Personal";
            // 
            // txtFoulPersonal
            // 
            this.txtFoulPersonal.Location = new System.Drawing.Point(72, 13);
            this.txtFoulPersonal.Name = "txtFoulPersonal";
            this.txtFoulPersonal.Size = new System.Drawing.Size(32, 20);
            this.txtFoulPersonal.TabIndex = 9;
            // 
            // txtFoulTechnical
            // 
            this.txtFoulTechnical.Location = new System.Drawing.Point(72, 35);
            this.txtFoulTechnical.Name = "txtFoulTechnical";
            this.txtFoulTechnical.Size = new System.Drawing.Size(32, 20);
            this.txtFoulTechnical.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFTAtt);
            this.groupBox3.Controls.Add(this.txtFTMade);
            this.groupBox3.Location = new System.Drawing.Point(326, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 63);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Att";
            // 
            // txtFTAtt
            // 
            this.txtFTAtt.Location = new System.Drawing.Point(52, 13);
            this.txtFTAtt.Name = "txtFTAtt";
            this.txtFTAtt.Size = new System.Drawing.Size(32, 20);
            this.txtFTAtt.TabIndex = 7;
            // 
            // txtFTMade
            // 
            this.txtFTMade.Location = new System.Drawing.Point(52, 35);
            this.txtFTMade.Name = "txtFTMade";
            this.txtFTMade.Size = new System.Drawing.Size(32, 20);
            this.txtFTMade.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFGAtt);
            this.groupBox2.Controls.Add(this.txtFGMade);
            this.groupBox2.Location = new System.Drawing.Point(191, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FG";
            // 
            // dgStats
            // 
            this.dgStats.AllowUserToAddRows = false;
            this.dgStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.FieldGoalsAtt,
            this.FieldGoalsMade,
            this.FreeThrowsAtt,
            this.FreeThrowsMade,
            this.PersonalFoul,
            this.TechnicalFouls});
            this.dgStats.Location = new System.Drawing.Point(12, 183);
            this.dgStats.Name = "dgStats";
            this.dgStats.Size = new System.Drawing.Size(668, 193);
            this.dgStats.TabIndex = 6;
            this.dgStats.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStats_CellValueChanged);
            this.dgStats.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgStats_UserDeletingRow);
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.Width = 150;
            // 
            // FieldGoalsAtt
            // 
            this.FieldGoalsAtt.HeaderText = "FG Att";
            this.FieldGoalsAtt.Name = "FieldGoalsAtt";
            this.FieldGoalsAtt.Width = 75;
            // 
            // FieldGoalsMade
            // 
            this.FieldGoalsMade.HeaderText = "FG Made";
            this.FieldGoalsMade.Name = "FieldGoalsMade";
            this.FieldGoalsMade.Width = 80;
            // 
            // FreeThrowsAtt
            // 
            this.FreeThrowsAtt.HeaderText = "FT Att";
            this.FreeThrowsAtt.Name = "FreeThrowsAtt";
            this.FreeThrowsAtt.Width = 75;
            // 
            // FreeThrowsMade
            // 
            this.FreeThrowsMade.HeaderText = "FT Made";
            this.FreeThrowsMade.Name = "FreeThrowsMade";
            this.FreeThrowsMade.Width = 75;
            // 
            // PersonalFoul
            // 
            this.PersonalFoul.HeaderText = "PF";
            this.PersonalFoul.Name = "PersonalFoul";
            this.PersonalFoul.Width = 75;
            // 
            // TechnicalFouls
            // 
            this.TechnicalFouls.HeaderText = "TF";
            this.TechnicalFouls.Name = "TechnicalFouls";
            this.TechnicalFouls.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 421);
            this.Controls.Add(this.dgStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkWin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOppPts);
            this.Controls.Add(this.lblUsScore);
            this.Controls.Add(this.txtOppPts);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.txtOurPoints);
            this.Controls.Add(this.txtOpponent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpponent;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUsScore;
        private System.Windows.Forms.TextBox txtOurPoints;
        private System.Windows.Forms.TextBox txtOppPts;
        private System.Windows.Forms.Label lblOppPts;
        private System.Windows.Forms.CheckBox chkWin;
        private System.Windows.Forms.ComboBox drpPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFGAtt;
        private System.Windows.Forms.TextBox txtFGMade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFoulPersonal;
        private System.Windows.Forms.TextBox txtFoulTechnical;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFTAtt;
        private System.Windows.Forms.TextBox txtFTMade;
        private System.Windows.Forms.Button btnSaveStats;
        private System.Windows.Forms.DataGridView dgStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldGoalsAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldGoalsMade;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeThrowsAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeThrowsMade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalFoul;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnicalFouls;
    }
}

