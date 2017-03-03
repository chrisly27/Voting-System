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
    public partial class DisplayElectedCandidatesForm : Form
    {
        private ConstituencyList constituencyList;
        public DisplayElectedCandidatesForm(ConstituencyList constituencyList)
        {
            InitializeComponent();
            this.constituencyList = constituencyList;
        }
        private void DisplayElectedCandidatesForm_Load(object sender, EventArgs e)
        {
            foreach (var elec in constituencyList.constituencyList)
            {
                lstElectCandi.Items.Add(elec.candidateElected);
            }
        }
        private void lstElectCandi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Candidate candlist = (Candidate)lstElectCandi.SelectedItem;
            lblElectDet.Text = candlist.DisplayCandidatesDetails();
        }
        private void DisplayElectedCandidatesForm_Close(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
