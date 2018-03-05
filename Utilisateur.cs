using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_deLocation_deVoiture
{
    public partial class Utilisateur : Form
    {
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void btnAffic_T_Click(object sender, EventArgs e)
        {
            AfficheTous aff = new AfficheTous();
            aff.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
