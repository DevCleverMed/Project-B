using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_ADO.NET
{
    public partial class Form1 : Form
    {

        private SqlConnection cn = new SqlConnection(@"Data Source=PC-OUARDI\SQLEXPRESS; initial catalog=adonet; integrated security=true");
        private DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Reservation", cn);

            da.Fill(ds, "Reservation");
         
            dataGridView1.DataSource = ds.Tables["Reservation"];
        }

       

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (txt_CIN.Text == "" || txt_Nb_Pers.Text == "") MessageBox.Show("Remplir tous les champs");
            else
            {
                if (dtp_Fin.Value <= dtp_Debut.Value) MessageBox.Show("Veillez choisir des date valises");
                else
                {
                    int indice = Existe(txt_CIN.Text);

                    if (indice == -1)
                    {

                        DataRow ligne;
                        ligne = ds.Tables["Reservation"].NewRow();
                        ligne[0] = txt_CIN.Text;
                        ligne[1] = dtp_Debut.Value.ToShortDateString();
                        ligne[2] = dtp_Fin.Value.ToShortDateString();
                        ligne[3] = txt_Nb_Pers.Text;
                        ds.Tables["Reservation"].Rows.Add(ligne);
                        Vider();
                        }
                    else MessageBox.Show("Ce CIN existe déja");
                }
            }



        }

        
        private void btn_Supprimer_Click(object sender, EventArgs e)
        {


            int indice = Existe(txt_CIN.Text);

            if (indice==-1) MessageBox.Show("Ce CIN n'existe pas!");
            else
            {

                ds.Tables["Reservation"].Rows[indice].Delete();
            }
            ds.AcceptChanges();

        }

        private int Existe(string cin)
        {
            int c = -1;

            for (int i = 0; i < ds.Tables["Reservation"].Rows.Count; i++)
            {
                if (cin == ds.Tables["Reservation"].Rows[i][0].ToString())
                {
                    c = i;
                    break;
                }

            }
            return c;

        }

        private void Vider()
        {
            txt_CIN.Text = "";
            txt_Nb_Pers.Text = "";
            dtp_Debut.Value = System.DateTime.Now; dtp_Fin.Value = System.DateTime.Now;

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            int indice = Existe(txt_CIN.Text);
            if (indice == -1) MessageBox.Show("Ce CIN n'existe pas !");
            else
            {

                ds.Tables["Reservation"].Rows[indice][1] = dtp_Debut.Value.ToShortDateString();
                ds.Tables["Reservation"].Rows[indice][2] = dtp_Fin.Value.ToShortDateString();
                ds.Tables["Reservation"].Rows[indice][3] = txt_Nb_Pers.Text;

            }
        }
    }
}
