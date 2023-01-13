using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectT100.Model;

namespace ProjectT100.Controller
{
    public class StudController
    {
        public List<StudModel> ReadAll()
        {
            // voert de CLASS data uit
            return data();
        }
        private string connectionstring = ConfigurationManager.ConnectionStrings["connectionStringstud"].ConnectionString;

        public List<StudModel> data()
        {
            // connectie oproepen met connectiestring
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                // maakt de connectie open van database.
                con.Open();
                // voert de sql command uit. 
                SqlCommand command = new SqlCommand("SELECT * FROM studlijsten", con);

                // het exucuteerd de command.
                SqlDataReader reader = command.ExecuteReader();

                List<StudModel> opgegevendata = new List<StudModel>();
                // StudModel de gegevens vanuit een database af. 
                while (reader.Read())
                {
                    // maakt een nieuwe class aan en leest alles af vanuit het tblDoctor tabel. 
                    StudModel patient = new StudModel();
                    patient.Studentnummer = reader["Studentnummer"].Equals(DBNull.Value) ? new int() : (int)reader["Studentnummer"];
                    // het is een true of false, de ? = true en de : = false. 
                    //Als de ? wordt gebruikt en er is iets geselecteerd in Lvthema2 dan wordt het in die listview verwijdert. 
                    //Anders als het false is dus dat is de : dan gaat het naar de andere lisview toe.
                    patient.voornaam = (string)reader["voornaam"];


                    // tabel gegeven worden toegevoegds.
                    opgegevendata.Add(patient);
                }
                // de waardes van het model DoctorModel.
                return opgegevendata;

            }

        }


        public int CreatePatient(StudModel createdoc)
        {

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                // sql code ADD is toegepast 
                string sqlquerry = "INSERT INTO studlijsten (Studentnummer, voornaam)  VALUES (@StudentnummerValue, @voornaamValue)";

                using (SqlCommand command = new SqlCommand(sqlquerry, con))
                {
                    // voeg de items met de waardes mee in het form
                    command.Parameters.AddWithValue("StudentnummerValue", createdoc.Studentnummer);
                    command.Parameters.AddWithValue("voornaamValue", createdoc.voornaam);

                    // de connectie openen 
                    con.Open();

                    // een int maken voor de controle of het gelukt is 
                    int affectedRows = command.ExecuteNonQuery();
                    // rijen worden toegevoegdndat de informatie is toegevoegd
                    return affectedRows;
                }
            }

        }

    }
}
