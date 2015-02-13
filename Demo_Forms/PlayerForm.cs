using System;
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
    public partial class PlayerForm : Form
    {
        private List<Player> lstPlayers = new List<Player>();
        public PlayerForm()
        {
            InitializeComponent();
        }

        public PlayerForm(List<Player> lst)
        {
            InitializeComponent();
            lstPlayers = lst;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Player p = new Player();
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            p.Gender = txtGender.Text;
            p.DateOfBirth = DateTime.Parse(txtDOB.Text);
            p.HomeTown = txtHomeTown.Text;
            p.HomeState = txtHomeState.Text;

            lstPlayers.Add(p);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtGender.Clear();
            txtDOB.Clear();
            txtHomeState.Clear();
            txtHomeTown.Clear();

            PlayerManager.SerializeList(lstPlayers);
            

        }
    }
}
