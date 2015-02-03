﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Forms
{
    public partial class Form1 : Form
    {
        private List<string> lstPlayers = new List<string>();
        private List<BasketballPlayerGameStat> lstStats = new List<BasketballPlayerGameStat>();

        public Form1()
        {
            InitializeComponent();
            BuildRoster();
            ShowRoster();
        }

        private void BuildRoster()
        {
            lstPlayers.Add("Kobe Bryant");
            lstPlayers.Add("Michael Jordan");
            lstPlayers.Add("Larry Bird");
            lstPlayers.Add("Spud Webb");
            lstPlayers.Add("Danny Ainge");

            drpPlayers.DataSource = lstPlayers;
            drpPlayers.Refresh();
        }

        private void ShowRoster()
        {
            for(int i=0; i<lstPlayers.Count; i++)
            {
                Console.WriteLine(lstPlayers[i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtOpponent.Text);
            int nOurpoints = int.Parse(txtOurPoints.Text);
            int nOpppoints = int.Parse(txtOppPts.Text);

            if (nOurpoints > nOpppoints)
            {
                chkWin.Checked = true;
            }
        }

        private void drpPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lstPlayers[drpPlayers.SelectedIndex]);
        }

        private void btnSaveStats_Click(object sender, EventArgs e)
        {
            int playerindex = drpPlayers.SelectedIndex;
            
            BasketballPlayerGameStat _stats = new BasketballPlayerGameStat();
            _stats.PlayerName = drpPlayers.Text;
            _stats.FieldGoalsAttempted = int.Parse(txtFGAtt.Text);
            _stats.FieldGoalsMade = int.Parse(txtFGMade.Text);
            _stats.FreeThrowAttempts = int.Parse(txtFTAtt.Text);
            _stats.FreeThrowsMade = int.Parse(txtFTMade.Text);
            _stats.PersonalFouls = int.Parse(txtFoulPersonal.Text);
            _stats.TechnicalFouls = int.Parse(txtFoulTechnical.Text);

            lstStats.Add(_stats);

          
            // 2. clear the text boxes when done
            txtFGAtt.Text = "";
            txtFGMade.Text = "";
            txtFTAtt.Text = "";
            txtFTMade.Text = "";
            txtFoulPersonal.Text = "";
            txtFoulTechnical.Text = "";

            // 3.  Show the new stats in the table.
            UpdateStatsTable();
            
        }

        private void UpdateStatsTable()
        {

            dgStats.Rows.Clear();

            foreach (BasketballPlayerGameStat stat in lstStats)
            {
                int rowindex = dgStats.Rows.Add();
                dgStats.Rows[rowindex].Cells[0].Value = stat.PlayerName;
                dgStats.Rows[rowindex].Cells[1].Value = stat.FieldGoalsAttempted;
                dgStats.Rows[rowindex].Cells[2].Value = stat.FieldGoalsMade;
                dgStats.Rows[rowindex].Cells[3].Value = stat.FreeThrowAttempts;
                dgStats.Rows[rowindex].Cells[4].Value = stat.FreeThrowsMade;
                dgStats.Rows[rowindex].Cells[5].Value = stat.PersonalFouls;
                dgStats.Rows[rowindex].Cells[6].Value = stat.TechnicalFouls;

            }

        }





    }
}