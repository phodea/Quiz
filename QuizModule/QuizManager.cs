/**************************************************************************
 *                                                                        *
 *  File:        QuizManager.cs                                           *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                             *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                     *
 *  Website:     https://github.com/phodea/Quiz                           *
 *  Description: Clasa QuizManager implementeaza logica de functionare a  *
 *  quiz-ului. Este responsabila de preluarea intrebarilor de la          *
 *  DatabaseManager, si sortarea lor in ordine aleatoare. De asemenea,    *
 *  clasa QuizManager permite validarea raspunsurilor oferite de          *
 *  utilizator si returnarea raspunsurilor gresite pentru a fi            *
 *  folosite in ResultForm                                                *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Metoda preia toate intrebarile din baza de date si selecteaza 10 dintre ele in ordine aleatoare
        /// </summary>
        public void GenerateQuiz()
        {
            try
            {
                Question[] allQuestions = DatabaseManager.GetInstance().GetQuestions(this.difficulty);
                Random rand = new Random();
                allQuestions = allQuestions.OrderBy(x => rand.Next()).ToArray();
                this.questions = allQuestions.Take(10).ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show("Eroare preluare intrebari din baza de date: " + e.Message);
            }
        }

        public void SetUserAnswer(int questionIndex, int responseIndex)
        {
            questions[questionIndex].selectedAnswer = responseIndex;
        }

        /// <summary>
        /// Functia compara raspunsurile date de utilizator cu raspunsurile corecte
        /// </summary>
        /// <returns>
        /// Functia va returna lista cu raspunsurile gresite
        /// </returns>
        public Question[] ValidateAnswers()
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
