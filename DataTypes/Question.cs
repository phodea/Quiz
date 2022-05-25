using System;
using System.Collections.Generic;
using System.Linq;
/**************************************************************************
 *                                                                        *
 *  File:        Question.cs                                              *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                             *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                     *
 *  Website:     https://github.com/phodea/Quiz                           *
 *  Description: Clasa care stocheaza toate informatiile referitoare la o *
 *  intrebare din quiz. Clasa contine si o metoda de validare a           *
 *  raspunsului corect.                                                   *
 *                                                                        *
 **************************************************************************/

namespace proiect
{
    /// <summary>
    /// Clasa Question contine informatiile corespunzatoare pentru o intrebare din quiz
    /// </summary>
    public class Question
    {
        public string questionDescription;
        public string[] answers;
        private int correctAnswer;
        public int selectedAnswer = -1;

        public Question(string questionDescription, string[] answers, int correctAnswer)
        {
            this.questionDescription = questionDescription;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
        }

        public int GetCorrectAnswer()
        {
            return correctAnswer;
        }

        /// <summary>
        /// Functie folosita pentru a valida un raspuns dat de utilizator
        /// </summary>
        /// <returns>True daca raspunsul este corect, False daca este gresit</returns>
        public bool ValidateAnswer()
        {
            return (correctAnswer == selectedAnswer);
        }
    }
}
