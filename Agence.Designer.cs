namespace Gestion_deLocation_deVoiture
{
    partial class Agence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agence));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Patente = new System.Windows.Forms.TextBox();
            this.Libelle_a = new System.Windows.Forms.TextBox();
            this.Raison = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pays = new System.Windows.Forms.ComboBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Code_postal = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Anuller = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 234);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Patente);
            this.panel2.Controls.Add(this.Libelle_a);
            this.panel2.Controls.Add(this.Raison);
            this.panel2.Controls.Add(this.id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 199);
            this.panel2.TabIndex = 9;
            // 
            // Patente
            // 
            this.Patente.Location = new System.Drawing.Point(151, 141);
            this.Patente.Name = "Patente";
            this.Patente.Size = new System.Drawing.Size(121, 20);
            this.Patente.TabIndex = 7;
            // 
            // Libelle_a
            // 
            this.Libelle_a.Location = new System.Drawing.Point(151, 104);
            this.Libelle_a.Name = "Libelle_a";
            this.Libelle_a.Size = new System.Drawing.Size(121, 20);
            this.Libelle_a.TabIndex = 6;
            // 
            // Raison
            // 
            this.Raison.FormattingEnabled = true;
            this.Raison.Items.AddRange(new object[] {
            "Louer ",
            "Renseingnement ",
            "Vente"});
            this.Raison.Location = new System.Drawing.Point(151, 69);
            this.Raison.Name = "Raison";
            this.Raison.Size = new System.Drawing.Size(121, 21);
            this.Raison.TabIndex = 5;
            this.Raison.SelectedIndexChanged += new System.EventHandler(this.Raison_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(135, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(32, 24);
            this.id.TabIndex = 4;
            this.id.Text = "xx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom agence : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raison sociale : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Pays);
            this.panel3.Controls.Add(this.Tel);
            this.panel3.Controls.Add(this.Code_postal);
            this.panel3.Controls.Add(this.Adresse);
            this.panel3.Controls.Add(this.Ville);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(323, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 199);
            this.panel3.TabIndex = 0;
            // 
            // Pays
            // 
            this.Pays.FormattingEnabled = true;
            this.Pays.Items.AddRange(new object[] {
            "Afrique du Sud\t",
            "Afghanistan\t",
            "Albanie\t",
            "Algérie\t",
            "Allemagne\t",
            "Andorre\t",
            "Angola\t",
            "Antigua-et-Barbuda\t",
            "Arabie Saoudite\t",
            "Argentine\tBuenos Aires",
            "Arménie\t",
            "Australie\t",
            "Autriche\t",
            "Azerbaïdjan\t",
            "Bahamas\t",
            "Bahreïn\t",
            "Bangladesh\t",
            "Barbade\t",
            "Belgique\t",
            "Belize\t",
            "Bénin\t",
            "Bhoutan\t",
            "Biélorussie\t",
            "Birmanie\t",
            "Bolivie\t",
            "Bosnie-Herzégovine\t",
            "Botswana\t",
            "Brésil\t",
            "Brunei\t",
            "Bulgarie\t",
            "Burkina Faso\t",
            "Burundi\t",
            "Cambodge\t",
            "Cameroun\t",
            "Canada\t",
            "Cap-Vert\t",
            "Chili\t",
            "Chine\t",
            "Chypre\t",
            "Colombie\t",
            "Comores\t",
            "Corée du Nord\t",
            "Corée du Sud\t",
            "Costa Rica\t",
            "Côte d’Ivoire\t",
            "Croatie\t",
            "Cuba\t",
            "Danemark\t",
            "Djibouti\t",
            "Dominique\t",
            "Égypte\t",
            "Émirats arabes unis\t",
            "Équateur\t",
            "Érythrée\t",
            "Espagne\t",
            "Estonie\t",
            "États-Unis\t",
            "Éthiopie\t",
            "Fidji\t",
            "Finlande\t",
            "France\t",
            "Gabon\t",
            "Gambie\t",
            "Géorgie\t",
            "Ghana\t",
            "Grèce\t",
            "Grenade\t",
            "Guatemala\t",
            "Guinée\t",
            "Guinée équatoriale\t",
            "Guinée-Bissau\t",
            "Guyana\t",
            "Haïti\t",
            "Honduras\t",
            "Hongrie\t",
            "Îles Cook\t",
            "Îles ",
            "Inde\t",
            "Indonésie\t",
            "Irak\t",
            "Iran\t",
            "Irlande\t",
            "Islande\t",
            "Israël\t",
            "Italie\t",
            "Jamaïque\t",
            "Japon\t",
            "Jordanie\t",
            "Kazakhstan\t",
            "Kenya\t",
            "Kirghizistan\t",
            "Kiribati\t",
            "Koweït\t",
            "Laos\t",
            "Lesotho\t",
            "Lettonie\t",
            "Liban\t",
            "Liberia\t",
            "Libye\t",
            "Liechtenstein\t",
            "Lituanie\t",
            "Luxembourg\t",
            "Macédoine\t",
            "Madagascar\t",
            "Malaisie\t",
            "Malawi\t",
            "Maldives\t",
            "Mali\t",
            "Malte\t",
            "Maroc\t",
            "Maurice\t",
            "Mauritanie\t",
            "Mexique\t",
            "Micronésie\t",
            "Moldavie\t",
            "Monaco\t",
            "Mongolie\t",
            "Monténégro\t",
            "Mozambique\t",
            "Namibie\t",
            "Nauru\t",
            "Népal\t",
            "Nicaragua\t",
            "Niger\t",
            "Nigeria\t",
            "Niue\t",
            "Norvège\t",
            "Nouvelle-Zélande\t",
            "Oman\t",
            "Ouganda\t",
            "Ouzbékistan\t",
            "Pakistan\t",
            "Palaos\t",
            "Palestine\t",
            "Panama\t",
            "Papouasie-Nouvelle-Guinée\t",
            "Paraguay\t",
            "Pays-Bas\t",
            "Pérou\t",
            "Philippines\t",
            "Pologne\t",
            "Portugal\t",
            "Qatar\t",
            "République centrafricaine\t",
            "République démocratique du Congo\t",
            "République Dominicaine\t",
            "République du Congo\t",
            "République tchèque\t",
            "Roumanie\tBucarest",
            "Royaume-Uni\t",
            "Russie\t",
            "Rwanda\t",
            "Saint-Kitts-et-Nevis\t",
            "Saint-Vincent-et-les-Grenadines\t",
            "Sainte-Lucie\t",
            "Saint-Marin\t",
            "Salomon\t",
            "Salvador\tSan ",
            "Samoa\t",
            "São Tomé-et-Principe\t",
            "Sénégal\t",
            "Serbie\t",
            "Seychelles\tVictoria",
            "Sierra Leone\t",
            "Singapour\t",
            "Slovaquie\t",
            "Slovénie\t",
            "Somalie\t",
            "Soudan\t",
            "Soudan du Sud\t",
            "Sri Lanka\t",
            "Suède\t",
            "Suisse\t",
            "Suriname\t",
            "Swaziland\t",
            "Syrie\t",
            "Tadjikistan\t",
            "Tanzanie\t",
            "Tchad\t",
            "Thaïlande\t",
            "Timor Dili",
            "Togo\t",
            "Tonga\t",
            "Trinité-et-Tobago\t",
            "Tunisie\t",
            "Turkménistan\t",
            "Turquie\t",
            "Tuvalu\t",
            "Ukraine\t",
            "Uruguay\t",
            "Vanuatu\t",
            "Vatican\t",
            "Venezuela\t",
            "Viêt Nam\t",
            "Yémen\t",
            "Zambie\t",
            "Zimbabwe\t"});
            this.Pays.Location = new System.Drawing.Point(135, 18);
            this.Pays.Name = "Pays";
            this.Pays.Size = new System.Drawing.Size(105, 21);
            this.Pays.TabIndex = 8;
            this.Pays.SelectedIndexChanged += new System.EventHandler(this.Pays_SelectedIndexChanged);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(135, 166);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(105, 20);
            this.Tel.TabIndex = 14;
            // 
            // Code_postal
            // 
            this.Code_postal.Location = new System.Drawing.Point(135, 127);
            this.Code_postal.Name = "Code_postal";
            this.Code_postal.Size = new System.Drawing.Size(105, 20);
            this.Code_postal.TabIndex = 13;
            this.Code_postal.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(135, 92);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(105, 20);
            this.Adresse.TabIndex = 12;
            // 
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(135, 57);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(105, 20);
            this.Ville.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Téléphone : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pays : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ville : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Code postal :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adresse :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 117);
            this.dataGridView1.TabIndex = 10;
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.Location = new System.Drawing.Point(86, 262);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(114, 39);
            this.Nouveau.TabIndex = 10;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(225, 262);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(114, 39);
            this.Modifier.TabIndex = 11;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(374, 262);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(114, 39);
            this.Supprimer.TabIndex = 12;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.Location = new System.Drawing.Point(526, 262);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(114, 39);
            this.Valider.TabIndex = 13;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.button4_Click);
            // 
            // Anuller
            // 
            this.Anuller.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anuller.Location = new System.Drawing.Point(667, 262);
            this.Anuller.Name = "Anuller";
            this.Anuller.Size = new System.Drawing.Size(114, 39);
            this.Anuller.TabIndex = 14;
            this.Anuller.Text = "Annuler";
            this.Anuller.UseVisualStyleBackColor = true;
            this.Anuller.Click += new System.EventHandler(this.Anuller_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(353, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(501, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(453, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 35);
            this.button4.TabIndex = 17;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(621, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 199);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Agence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(870, 487);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Anuller);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Agence";
            this.Text = "Agence";
            this.Load += new System.EventHandler(this.Agence_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Patente;
        private System.Windows.Forms.TextBox Libelle_a;
        private System.Windows.Forms.ComboBox Raison;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Code_postal;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Anuller;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Pays;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}