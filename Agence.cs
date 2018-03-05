using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_deLocation_deVoiture
{
    public partial class Agence : Form
    {
    
        public Agence()
        {
            InitializeComponent();
        }
        int ligne;
        int mode = 0;

        public void Viderchamps()
        {
            Raison.Text = "";
            Libelle_a.Text = string.Empty;
            Patente.Clear();
            Pays.Text = "";
            Ville.Text = "";
            Adresse.Text = "";
            Code_postal.Text = "";
            Tel.Text = "";
        }
        public void Afficher()
        {
         
                
                clscnx.connecter();
                clscnx.msql("Select * from Agence", "Agence");
                id.Text = clscnx.dt.Rows[ligne]["id_agence"].ToString();
                Raison.Text = clscnx.dt.Rows[ligne]["Raison_sociale"].ToString();
                Libelle_a.Text = clscnx.dt.Rows[ligne]["Nom_agence"].ToString();
                Patente.Text = clscnx.dt.Rows[ligne]["Patente"].ToString();
                Pays.Text = clscnx.dt.Rows[ligne]["Pays"].ToString();
                Ville.Text = clscnx.dt.Rows[ligne]["Ville"].ToString();
                Adresse.Text = clscnx.dt.Rows[ligne]["Adresse"].ToString();
                Code_postal.Text = clscnx.dt.Rows[ligne]["Code_postal"].ToString();
                Tel.Text = clscnx.dt.Rows[ligne]["Tel"].ToString();
               
            }
         

        
        public void Menugeneral(bool x)
        {
            Nouveau.Enabled = x;
            Modifier.Enabled = x;
            Supprimer.Enabled = x;
            Valider.Enabled = !x;
            Anuller.Enabled = !x;
        }

        public void afficher2()
        {
            clscnx.connecter();
            clscnx.msql("Select * from Agence", "Agence");
            dataGridView1.DataSource = clscnx.dt;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agence_Load(object sender, EventArgs e)
        {
            Afficher();
            afficher2();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = 1;
            Viderchamps();
            Menugeneral(false);
            clscnx.connecter();
            clscnx.msql("select max(id_agence) as maxe from Agence", "Agence");
            id.Text = clscnx.dt.Rows[0]["maxe"].ToString();
            id.Text = (int.Parse(id.Text)+1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                try
                {

                    clscnx.connecter();
                    clscnx.msql("insert into Agence(Raison_sociale,Nom_agence,Patente,Pays,Ville,Adresse,Code_Postal,Tel) Values ('" + Raison.GetItemText(Raison.SelectedItem) + "','" + Libelle_a.Text + "','" + Patente.Text + "','" + Pays.GetItemText(Pays.SelectedItem) + "','" + Ville.Text + "','" + Adresse.Text + "','" + Code_postal.Text + "','" + Tel.Text + "')", "Agence");
                    afficher2();
                    Afficher();
                    Menugeneral(true);
                }
                catch (Exception E) { MessageBox.Show(E.Message); }

            }
            if (mode == 2)
            {
                try
                {
                    clscnx.connecter();
                    clscnx.msql("Update Agence set Raison_sociale = '" + Raison.GetItemText(Raison.SelectedItem) + "', Nom_agence ='" + Libelle_a.Text + "',Patente = '" + Patente.Text + "' , Pays = '" + Pays.GetItemText(Pays.SelectedItem) + "'  ,Ville = '" + Ville.Text + "',Adresse =  '" + Adresse.Text + "', Code_postal = '" + Code_postal.Text + "',Tel = '" + Tel.Text + "' where id_agence = '" + id.Text + "' ", "Agence");
                    afficher2();
                    Afficher();
                    Menugeneral(true);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }

            if (mode == 3)
            {
                try
                {
                    clscnx.connecter();
                    clscnx.msql(" Delete From Agence where id_agence  = " + id.Text + "", "Agence");
                    afficher2();
                    Afficher();
                    Menugeneral(true);
                }

                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }

            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                clscnx.connecter();
                ligne = 0;
                afficher2();
                Afficher();

            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                clscnx.connecter();
                ligne = clscnx.dt.Rows.Count - 1;
                afficher2();
                Afficher();

            }

            catch (Exception E) { MessageBox.Show(E.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (ligne > 0)
                {
                    clscnx.connecter();
                    ligne -= 1;
                    afficher2();
                    Afficher();
                }
            }
            catch (Exception E) { MessageBox.Show(E.Message); }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (ligne <= clscnx.dt.Rows.Count - 1 )
                {
                    clscnx.connecter();
                    ligne += 1;
                    afficher2();
                    Afficher();
                }
            }
            catch (Exception E) { MessageBox.Show(E.Message); }

        }

        private void Raison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Raison.Text = Raison.SelectedItem.ToString();
        }

        private void Pays_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pays.Text =Pays.SelectedItem.ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            mode = 2;
            Menugeneral(false);

        }

        private void Anuller_Click(object sender, EventArgs e)
        {
            Menugeneral(true);
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            mode = 3;
            Menugeneral(false);
        }
    }
}

        
        
       

