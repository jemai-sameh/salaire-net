using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salaire_net
{
    public partial class FormSalaireNet : Form
    {
        int m= 0,c=0,r=0;
        public FormSalaireNet()
        {
            InitializeComponent();
        }

        private void comboAssurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            m = comboAssurance.SelectedIndex;
        }

        private void comboCotisation_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = comboCotisation.SelectedIndex;
        }

        private void comboRetraite_SelectedIndexChanged(object sender, EventArgs e)
        {
            r = comboRetraite.SelectedIndex;
        }

        private void FormSalaireNet_Load(object sender, EventArgs e)
        {
            comboCotisation.Items.Clear();
            comboAssurance.Items.Clear();
            comboRetraite.Items.Clear();
            for (int i = 1; i < 100; i++)
            {
                comboAssurance.Items.Add("    " + i);
                comboCotisation.Items.Add("    "+i);
                comboRetraite.Items.Add("    " + i);
            }
        }
            private void buttonCalcule_Click(object sender, EventArgs e)
        {
            float Net;
            int Brut = int.Parse(textSalaireBrut.Text);

            Net = Brut-Brut*(m+c+r);
            labelResultatSalaireNet.Text = "" + Net;

        }
    }
}
