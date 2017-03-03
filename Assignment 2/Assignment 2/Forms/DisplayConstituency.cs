using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assignment_2
{
    public partial class DisplayConstituency : Form
    {
        public IConstituencyFileReader IOhandler { get; set; }
        private ConstituencyList constituencyList;
        public DisplayConstituency(IConstituencyFileReader IOhandler, ConstituencyList constituencyList)
        {
            InitializeComponent();
            this.IOhandler = IOhandler;
            this.constituencyList = constituencyList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCandi.Items.Clear();
            Constituency constituency = (Constituency)comboBox1.SelectedItem;
            foreach(Candidate candi in constituency.candidateList.candidateDetails)
            {
                lstCandi.Items.Add(candi);
            }
        }

        private void DisplayConstituencyForm_Load(object sender, EventArgs e)
        {
            lstCandi.Items.Clear();
            foreach(var constituency in constituencyList.constituencyList)
            {
                comboBox1.Items.Add(constituency);
            }
        }

        private void lstCandi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Candidate candiLis = (Candidate)lstCandi.SelectedItem;
            string det = candiLis.DisplayCandidatesDetails();
            lstCandiDatails.Text = det;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.DialogResult = DialogResult.OK;
        }

        private void DisplayConstituencyForm_Close(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
