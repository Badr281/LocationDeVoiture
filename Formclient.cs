using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gestion_deLocation_deVoiture
{
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
        }
        
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EJN41T2\SQLEXPRESS;Initial Catalog=LocationVoiture;Integrated Security=True");
        string b;
        int ligne;
        int Mode = 0;
        public void menugeneral(bool vf)
        {
            Ajouter.Enabled = vf;
            Modifier.Enabled = vf;
            Supprimer.Enabled = vf;
            Valider.Enabled = !vf;
            Annuler.Enabled = !vf;


        }
        public void ViderChamps()
        {
            CIN.Text = "";
            Prenom.Text = "";
            Nom.Text = "";
            Ville.Text = string.Empty;
            Code_postal.Text = "";
            Adresse.Text = "";
            Masculin.Checked = true;
            N_permis.Text = "";
            Réduction.Text = "";
            Tel.Text = "";
            Po.Text = "";
            Pa.Text = "";


        }
        public void date()
        {
            string dateString = this.DateFP.Text;
            DateTime Date = Convert.ToDateTime(dateString.ToString());
            dataGridView1.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
        }
        void MenuClient()
        {

        }
        public void Afficher()
        {
            clscnx.connecter();
            clscnx.msql("select * from Client", "Client");
            dataGridView1.DataSource = clscnx.dt;
        }
        
        public void afficher2()
        {
            clscnx.connecter();
            string dateString = this.DateFP.Text;
            DateTime Date = Convert.ToDateTime(dateString.ToString());
            clscnx.msql("Select * from Client", "Client");
            Idclt.Text = clscnx.dt.Rows[ligne]["idclt"].ToString();
            CIN.Text = clscnx.dt.Rows[ligne]["cin"].ToString();
            Prenom.Text = clscnx.dt.Rows[ligne]["Prenom"].ToString();
            Nom.Text = clscnx.dt.Rows[ligne]["Nom"].ToString();
            Ville.Text = clscnx.dt.Rows[ligne]["Ville"].ToString();
            Code_postal.Text = clscnx.dt.Rows[ligne]["Codepostal"].ToString();
            Adresse.Text = clscnx.dt.Rows[ligne]["Adresse"].ToString();
            if (Masculin.Checked)
            {
                Masculin.Text = clscnx.dt.Rows[ligne]["Sexe"].ToString();

            }
            else
            {
                Feminin.Text = clscnx.dt.Rows[ligne]["Sexe"].ToString();
            }

            N_permis.Text = clscnx.dt.Rows[ligne]["N_permis"].ToString();
            Réduction.Text = clscnx.dt.Rows[ligne]["reduction"].ToString();
            //DateFP.Text = clscnx.dt.Rows[ligne]["cin"].ToString();
            Tel.Text = clscnx.dt.Rows[ligne]["Tel"].ToString();

            Po.Text = clscnx.dt.Rows[ligne]["Pays_origine"].ToString();
            Pa.Text = clscnx.dt.Rows[ligne]["Pays_actuelle"].ToString();
           

            
        }
            





        private void Formclient_Load(object sender, EventArgs e)
        {
            clscnx.connecter();
            ligne = 0;
            menugeneral(true);
            Afficher();

            panelid.Visible = false;

              
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Po.Text = Po.SelectedItem.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            b = Feminin.Text;

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
        
                Mode = 1;
            ViderChamps();
            try
            {
                if (MessageBox.Show("vous vouler ajouter un client ?", " Important!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    clscnx.msql("select max(idclt) as max from Client", "Client");
                    Idclt.Text = clscnx.dt.Rows[0]["max"].ToString();
                    Idclt.Text = int.Parse(Idclt.Text).ToString();
                    menugeneral(false);
                    groupBox1.Enabled = true;
                }
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
            }


                        
          
            // labId client
            //clscnx.Sqlconnect("select max(Numclt) as Maxe  from Client");
            //Idclt.Text = dt.Rows[0]["maxe"].ToString();
            //Idclt.Text = (int.Parse(Idclt.Text) + 1).ToString();

            //dataGridView1.DataSource = dt;


   
         
            
       
        

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateFP_ValueChanged(object sender, EventArgs e)
        {


        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Masculin_CheckedChanged(object sender, EventArgs e)
        {
            b = Masculin.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {

            if (Mode == 1)
            {

                try
                {
                    clscnx.connecter();

                    date();

                    clscnx.msql("Insert into Client(cin,Prenom,Nom,Ville,Codepostal,Adresse,Sexe,N_permis,reduction,DateFP,Tel,Pays_origine,Pays_actuelle) values('" + CIN.Text + "','" + Prenom.Text + "','" + Nom.Text + "','" + Ville.Text + "','" + Code_postal.Text + "','" + Adresse.Text + "','" + b + "','" + N_permis.Text + "','" + Réduction.Text + "', '" + DateFP.Value.ToString("yyyy-MM-dd") + "','" + Tel.Text + "','" + Po.GetItemText(Po.SelectedItem) + "','" + Pa.GetItemText(Pa.SelectedItem) + "')", "Client");
                    Afficher();
                    afficher2();
                    menugeneral(true);

            }
                catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
        }
            if (Mode == 2)
            {
                try
                {
                    //date();
                    clscnx.connecter();
                    clscnx.msql(" Update Client set  cin = '" + CIN.Text + "' ,Prenom = '" + Prenom.Text + "',Nom = '" + Nom.Text + "',Ville = '" + Ville.Text + "',Codepostal ='" + Code_postal.Text + "',Adresse = '" + Adresse.Text + "',Sexe = '" + b + "',N_permis =' " + N_permis.Text + "',reduction ='" + Réduction.Text + "',Tel = '" + Tel.Text + "',Pays_origine = '" + Po.GetItemText(Po.SelectedItem) + "',Pays_actuelle = '" + Pa.GetItemText(Pa.SelectedItem) + "'   where idclt =   " + Idclt.Text + "     ", "Client");
                    afficher2();
                    Afficher();
                    menugeneral(true);
                    groupBox1.Enabled = false;
            }
                catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
            if (Mode == 3)
            {
                try
                {
                    clscnx.connecter();
                    panelid.Visible = false;
                    clscnx.msql("Delete   from Client where idclt = " + Id.Text + "   ", "Client");
                    Afficher();
                    afficher2();
                    menugeneral(true);
                    groupBox1.Enabled = false;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }



            else
            {
                textBox1.Text = null;
            }

         }
       



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            clscnx.connecter();
            clscnx.msql("select * from Client where Prenom like '" + textBox1.Text + "%'", "Client");
            dataGridView1.DataSource = clscnx.dt;
            clscnx.disconect();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                clscnx.connecter();
                ligne = 0;
                afficher2();
                Afficher();
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
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
            try {
                if (ligne >=1)
                {
                    clscnx.connecter();
                    ligne -= 1;
                    afficher2();
                    Afficher();
                }
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ligne < clscnx.dt.Rows.Count - 1)
                {
                    clscnx.connecter();
                    ligne += 1;
                    afficher2();
                    Afficher();
                }
            }

            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            clscnx.connecter();
            if (checkBox1.Checked)
            {
                clscnx.msql("select * from Client  order by Nom,Prenom asc", "Client");
                dataGridView1.DataSource = clscnx.dt;
                clscnx.disconect();


            }

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Mode = 2;
            menugeneral(false);
         

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Mode = 3;
                
            
            if (MessageBox.Show("vous vouler Supprimer un client ?", " Important!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                    menugeneral(false);
                    panelid.Visible = true;
                    groupBox1.Enabled = true;
             }



            }
            catch (Exception E) { MessageBox.Show(E.Message); }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Idclt_Click(object sender, EventArgs e)
        {
           
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            menugeneral(true);
        }

        private void Pa_SelectedIndexChanged(object sender, EventArgs e)
        {
           Pa.Text = Pa.GetItemText(Pa.SelectedItem).ToString(); 
        }
    }
}

