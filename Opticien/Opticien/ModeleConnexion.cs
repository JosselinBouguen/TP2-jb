using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Opticien
{
    class ModeleConnexion
    {
        #region propriétés
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool chargement = false;
        // collection de DataTable récupérant les données correspond au DA associé
        private List<DataTable> dT = new List<DataTable>();

        #endregion

        #region accesseurs
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public List<DataTable> DT { get => dT; set => dT = value; }
        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }
        #endregion


        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=opticien_jb;Data Source=127.0.0.1;User Id=root; Password='';SslMode = none;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative 
            {
                myConnection.Open();
                connopen = true;
  
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }

        /// <summary>
        /// Méthode pour se déconnecter de la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            chargement = false;

            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Clear();
                DT.Load(reader);
                chargement = true;

                /*   while (reader.Read())

                   {

                       //   StringID = reader[0].ToString();

                   }*/

            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
    }
}
