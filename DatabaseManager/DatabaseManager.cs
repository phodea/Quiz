/**************************************************************************
 *                                                                        *
 *  File:        DatabaseManager.cs                                       *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                             *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                     *
 *  Website:     https://github.com/phodea/Quiz                           *
 *  Description: Clasa DatabaseManager are rolul de a asigura conexiunea  *
 *  cu baza de date locala. Aceasta permite preluarea intrebarilor cu o   *
 *  anumita dificultate. Clasa este implementata dupa modelul Singleton,  *
 *  deoarece avem nevoie de o singura conexiune la baza de date.          *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace proiect
{
    public class DatabaseManager
    {
        private static readonly object _lock = new object();
        private static SqlConnection cnn;
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

        /// <summary>
        /// Metoda GetInstance apeleaza constructorul privat, si ne asigura ca putem avea o singura instanta din aceasta clasa
        /// </summary>
        /// <returns>Instanta curenta din DatabaseManager, marcata cu keyword-ul static</returns>
        public static DatabaseManager GetInstance()
        {
            lock (_lock)
                {
                    if (dbInstance == null)
                    {
                        dbInstance = new DatabaseManager();
                    }
                    return dbInstance;
                }
        }

        public static void ReleaseInstance()
        {
            dbInstance = null;
        }
        
        /// <summary>
        /// Metoda GetQuestions face un query in baza de date prin care returneaza lista de intrebari de o anumita dificultate
        /// </summary>
        /// <param name="difficulty"></param>
        /// <returns>Lista de intrebari</returns>
        public Question[] GetQuestions(int difficulty)
        {
            if (difficulty > 2 || difficulty < 0)
                throw new Exception("Nivel de dificultate invalid");

            List<Question> questions = new List<Question>();

            SqlCommand cmd = new SqlCommand("select intrebare, raspuns1, raspuns2, raspuns3, raspuns4, raspuns_corect from dbo.Intrebari where dificultate = '" + difficulty + "'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    questions.Add(new Question(reader["intrebare"].ToString(),
                        new[] { reader["raspuns1"].ToString(), reader["raspuns2"].ToString(),
                        reader["raspuns3"].ToString(), reader["raspuns4"].ToString() },
                        int.Parse(reader["raspuns_corect"].ToString())));
                }
            }
            finally
            {
                reader.Close();
            }
            return questions.ToArray();
        }
    }
}
