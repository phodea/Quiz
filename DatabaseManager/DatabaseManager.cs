using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    /// <summary>
    /// Clasa DatabaseManager are rolul de a asigura conexiunea cu baza de date
    /// Este folosita pentru a prelua intrebari din baza de date locala
    /// </summary>
    public class DatabaseManager
    {
        SqlConnection cnn;
        private static DatabaseManager dbInstance;

        private DatabaseManager()
        {
            string dbFilePath = Path.GetFullPath("Database.mdf");
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + dbFilePath + ";Integrated Security=True";
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Eroare la conexiunea cu baza de date: " + e.Message);
            }
        }

        public static DatabaseManager getInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new DatabaseManager();
            }
            return dbInstance;
        }

        public static void releaseInstance()
        {
            dbInstance = null;
        }
        
        //preluarea intrebarilor din baza de date
        public Question[] getQuestions(int difficulty)
        {
            if (difficulty > 2 || difficulty < 0)
                throw new Exception("Nivel de dificultate invalid");

            Question[] ret = new Question[3];
            ret[0] = new Question("Intrebarea 1", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            ret[1] = new Question("Intrebarea 2", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            ret[2] = new Question("Intrebarea 3", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            return ret;
        }
    }
}
