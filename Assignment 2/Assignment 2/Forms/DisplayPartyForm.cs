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
    public partial class DisplayPartyForm : Form
    {
        PartyList partyList;
        public DisplayPartyForm(PartyList partyList)
        {
            InitializeComponent();
            this.partyList = partyList;
        }
        private void DisplayPartyForm_Load(object sender, EventArgs e)
        {
            foreach (var p in partyList.partyList)
            {
                lblParties.Text += p.ToString() + Environment.NewLine;
            }
        }
        private void DisplayPartyForm_Close(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
