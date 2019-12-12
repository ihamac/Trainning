using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace WINDOWS_FORM_PPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnexionMySql.Connexion("root", "siojjr", "rallyeLecture", "172.16.0.172"); // connection a la bdd
            MySqlConnection cnx = ConnexionMySql.GetConnexion;

            TableNiveau n = new TableNiveau();
            List<Niveau> niveau = n.GetAll(); // récupére les niveau des classes
            foreach (Niveau liste in niveau)
            {
                cmbNiveau.Items.Add(liste.NiveauScolaire); // ajoute les niveaux des classes dans la combobox
            }
            DirectoryInfo MyRoot = new DirectoryInfo(@"C:\");
            DirectoryInfo[] MyFiles = MyRoot.GetDirectories();
            foreach (DirectoryInfo F in MyFiles)
            {
                fichers.Items.Add(F.Name);
            }
            fichers.SelectedValueChanged += Fichers_SelectedValueChanged;

        }

        private void Fichers_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = cbListBox.Items.Count-1; cbListBox.Items.Count>0; i--)
            {
                cbListBox.Items.RemoveAt(i);
            }
            cbListBox.Items.AddRange(Directory.GetFiles(@"C:\" + fichers.SelectedItem));
                
        }

        private void construit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aleatoire_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            



            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
