using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opticien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controleur.initConnexion();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
    private void chargerCbModele()
    {
        cbModele.Items.Clear();
        if (Controleur.VmodeleC.DT[3].Rows.Count == 0)
        {
            cbModele.Items.Add("Pas de compétences enregistrées");
            lbCompetences.Visible = false;
        }
        else
        {
            for (int i = 0; i < Controleur.VmodeleC.DT[3].Rows.Count; i++)
            {
                cbCompetences.Items.Add(Controleur.VmodeleC.DT[3].Rows[i]["LIBELLECOMPETENCE"].ToString());
            }
            lbCompetences.Visible = true;
            lbCompetences.Items.Clear();
        }
    }
}
