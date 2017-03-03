using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class DisplayWinner : Form
    {
        PartyList partyList;
        public DisplayWinner(PartyList partyList)
        {
            InitializeComponent();
            this.partyList = partyList;
        }
        private void DisplayWinner_Load(object sender, EventArgs e)
        {
            Party partyWinner = partyList.partyList.First();
            lblWiner.Text = "The Winner of the Election is " +
                            Environment.NewLine + partyWinner.partyName +
                            Environment.NewLine + " with " + partyWinner.votes +
                            " votes";
        }
        private void DisplayWinner_Close(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
