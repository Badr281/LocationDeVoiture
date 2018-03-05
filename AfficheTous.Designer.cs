namespace Gestion_deLocation_deVoiture
{
    partial class AfficheTous
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDern = new System.Windows.Forms.Button();
            this.buttonSuiv = new System.Windows.Forms.Button();
            this.buttonPrec = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDern);
            this.groupBox1.Controls.Add(this.buttonSuiv);
            this.groupBox1.Controls.Add(this.buttonPrec);
            this.groupBox1.Controls.Add(this.buttonP);
            this.groupBox1.Location = new System.Drawing.Point(84, 965);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(2062, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // buttonDern
            // 
            this.buttonDern.Location = new System.Drawing.Point(1305, 36);
            this.buttonDern.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDern.Name = "buttonDern";
            this.buttonDern.Size = new System.Drawing.Size(196, 62);
            this.buttonDern.TabIndex = 4;
            this.buttonDern.Text = ">>";
            this.buttonDern.UseVisualStyleBackColor = true;
            // 
            // buttonSuiv
            // 
            this.buttonSuiv.Location = new System.Drawing.Point(1056, 36);
            this.buttonSuiv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSuiv.Name = "buttonSuiv";
            this.buttonSuiv.Size = new System.Drawing.Size(196, 62);
            this.buttonSuiv.TabIndex = 3;
            this.buttonSuiv.Text = ">";
            this.buttonSuiv.UseVisualStyleBackColor = true;
            // 
            // buttonPrec
            // 
            this.buttonPrec.Location = new System.Drawing.Point(712, 36);
            this.buttonPrec.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrec.Name = "buttonPrec";
            this.buttonPrec.Size = new System.Drawing.Size(196, 62);
            this.buttonPrec.TabIndex = 2;
            this.buttonPrec.Text = "<";
            this.buttonPrec.UseVisualStyleBackColor = true;
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(476, 36);
            this.buttonP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(196, 62);
            this.buttonP.TabIndex = 1;
            this.buttonP.Text = "<<";
            this.buttonP.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(84, 52);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(2062, 907);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Liste d\'utilisateurs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2056, 862);
            this.dataGridView1.TabIndex = 0;
            // 
            // AfficheTous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(2231, 1133);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Name = "AfficheTous";
            this.Text = "AfficheTous";
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDern;
        private System.Windows.Forms.Button buttonSuiv;
        private System.Windows.Forms.Button buttonPrec;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}