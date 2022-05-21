using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public class QuizManager
    {
        public Question[] questions { get; set; }
        private int difficulty;

        public QuizManager(int difficulty)
        {
            this.difficulty = difficulty;
        }

        //Metoda preia toate intrebarile din baza de date si selecteaza 10 din ele in ordine aleatoare
        public void GenerateQuiz()
        {
            try
            {
                Question[] allQuestions = DatabaseManager.getInstance().getQuestions(this.difficulty);
                Random rand = new Random();
                allQuestions = allQuestions.OrderBy(x => rand.Next()).ToArray();
                this.questions = allQuestions.Take(10).ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show("Eroare preluare intrebari din baza de date: " + e.Message);
            }
        }

        public void setUserAnswer(int questionIndex, int responseIndex)
        {
            questions[questionIndex].selectedAnswer = responseIndex;
        }

        /// <summary>
        /// Functia compara raspunsurile date de utilizator cu raspunsurile corecte
        /// </summary>
        /// <returns>
        /// Functia va returna lista cu raspunsurile gresite
        /// </returns>
        public Question[] validateAnswers()
        {
            List<Question> wrongAnswers = new List<Question>();

            foreach (Question question in questions)
            {
                if (!question.ValidateAnswer())
                {
                    wrongAnswers.Add(question);
                }
            }

            return wrongAnswers.ToArray();
        }
    }
}
