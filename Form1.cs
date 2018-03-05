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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SqlConnection cn;
        public static SqlCommand cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
       

        public   void  connecter()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-EJN41T2\SQLEXPRESS;Initial Catalog=LocationVoiture;Integrated Security=True");
            cn.Open();  
        }
        public static void disconect()
        {
            cn.Close();
        }
        public void Sqlconnect(string req)
        {
            cm = new SqlCommand(req, cn);
            cm.CommandText = req;
            //SqlDataAdapter da = new SqlDataAdapter(cm);
            //DataSet ds = new DataSet();
            //da.Fill(ds,"Client");
            dr = cm.ExecuteReader();

        }

        
        
        private void label2_Click(object sender, EventArgs e)
        {
           
        }


        //SqlCommand cm = new SqlCommand((" exec authentifie '" + username.Text + "','" + password.Text + "'"), cn);
        //cm.CommandType = CommandType.StoredProcedure;
        //        cm.CommandText = "authentifie";

 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Transparent text label 
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;
            Form2 u = new Form2();
            u.Hide();

            




        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            
                connecter();

                try
                {
                    SqlCommand cm = new SqlCommand((" select * from Utilisateur where Username= '" + username.Text + "' and Password = '" + password.Text + "'  "), cn);
                    string req = cm.CommandText;
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 1)

                    {
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        label3.Visible = true;
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);

                }
            


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            try {
                if (checkBox1.Checked)

                    password.UseSystemPasswordChar = false;

                else

                    password.UseSystemPasswordChar = true;
            }
            catch(Exception E) { MessageBox.Show(E.Message); }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
           

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                username.ResetText();
                password.ResetText();
                //Total t = new Total();
                //t.Show();
                //this.Hide();


            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }

        }

        private void Testmenu_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
