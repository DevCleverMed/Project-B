namespace Ex6_ADO.NET
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CIN = new System.Windows.Forms.TextBox();
            this.txt_Nb_Pers = new System.Windows.Forms.TextBox();
            this.dtp_Debut = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date_Debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date_Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Personnes";
            // 
            // txt_CIN
            // 
            this.txt_CIN.Location = new System.Drawing.Point(184, 37);
            this.txt_CIN.Name = "txt_CIN";
            this.txt_CIN.Size = new System.Drawing.Size(100, 20);
            this.txt_CIN.TabIndex = 4;
            // 
            // txt_Nb_Pers
            // 
            this.txt_Nb_Pers.Location = new System.Drawing.Point(184, 171);
            this.txt_Nb_Pers.Name = "txt_Nb_Pers";
            this.txt_Nb_Pers.Size = new System.Drawing.Size(100, 20);
            this.txt_Nb_Pers.TabIndex = 5;
            // 
            // dtp_Debut
            // 
            this.dtp_Debut.Location = new System.Drawing.Point(184, 83);
            this.dtp_Debut.Name = "dtp_Debut";
            this.dtp_Debut.Size = new System.Drawing.Size(200, 20);
            this.dtp_Debut.TabIndex = 6;
            // 
            // dtp_Fin
            // 
            this.dtp_Fin.Location = new System.Drawing.Point(184, 126);
            this.dtp_Fin.Name = "dtp_Fin";
            this.dtp_Fin.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fin.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(550, 34);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 9;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(550, 83);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 10;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(550, 134);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Modifier.TabIndex = 11;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp_Fin);
            this.Controls.Add(this.dtp_Debut);
            this.Controls.Add(this.txt_Nb_Pers);
            this.Controls.Add(this.txt_CIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CIN;
        private System.Windows.Forms.TextBox txt_Nb_Pers;
        private System.Windows.Forms.DateTimePicker dtp_Debut;
        private System.Windows.Forms.DateTimePicker dtp_Fin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
    }
}

