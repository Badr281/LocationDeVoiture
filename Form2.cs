using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_deLocation_deVoiture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
 
            // formClient 

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
            
            Total c = new Total();
            c.Show();
            this.Hide();
        }

        private void Client_Click_1(object sender, EventArgs e)
        {
            Total c = new Total();
            c.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Total f = new Total(); // Form client
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agence a = new Agence(); 
            a.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Utilisateur ut = new Utilisateur();
            ut.Show();
            this.Hide();
        }
    }
}
