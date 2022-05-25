using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectQuizManager
{
    [TestClass]
    public class UnitTestQuizManager
    {
        /// <summary>
        /// Testarea ca metoda GenerateQuiz sa intoarca doar 10 din intrebarile din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGenerateQuiz()
        {
            //arrange
            proiect.QuizManager quizManager = new proiect.QuizManager(1);

            //act
            quizManager.GenerateQuiz();

            //assert
            Assert.AreEqual(quizManager.questions.Length, 10);
        }

        /// <summary>
        /// Testarea accesarii intrebarilor din quiz inainte ca acesta sa fie generat
        /// </summary>
        [TestMethod]
        public void TestMethodGenerateQuizNull()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(1);

            Assert.AreEqual(quizManager.questions, null);
        }

        /// <summary>
        /// Testarea introducerii unei dificultati neacceptate.
        /// </summary>
        [TestMethod]
        public void TestMethodGenerateQuizInvalidDifficulty()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(16);

            quizManager.GenerateQuiz();

            Assert.AreEqual(quizManager.questions, null);
        }

        /// <summary>
        /// Testarea generarii aleatoare a quiz-ului
        /// </summary>
        [TestMethod]
        public void TestMethodGenerateQuizShuffleQuestions()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(0);

            quizManager.GenerateQuiz();

            Assert.IsFalse(quizManager.questions[0].questionDescription == "Care este sursa principala de hrana a ursului panda?");
        }

        /// <summary>
        /// Testarea logicii de validare a raspunsului corect
        /// </summary>
        [TestMethod]
        public void TestMethodCheckCorectAnswers()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(0);

            quizManager.GenerateQuiz();

            //setarea raspunsului corect pentru primele doua intrebari
            quizManager.SetUserAnswer(0, quizManager.questions[0].GetCorrectAnswer());
            quizManager.SetUserAnswer(1, quizManager.questions[1].GetCorrectAnswer());

            //in urma validarii, trebuie sa avem 8 raspunsuri gresite
            Assert.AreEqual(quizManager.ValidateAnswers().Length, 8);
        }

        /// <summary>
        /// Testarea functionalitatii prin care se returneaza lista cu intrebarile gresite de utilizator
        /// </summary>
        [TestMethod]
        public void TestMethodCheckWrongAnswer()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(0);

            quizManager.GenerateQuiz();

            //setarea raspunsului corect pentru primele 5 intrebari
            quizManager.SetUserAnswer(0, quizManager.questions[0].GetCorrectAnswer());
            quizManager.SetUserAnswer(1, quizManager.questions[1].GetCorrectAnswer());
            quizManager.SetUserAnswer(2, quizManager.questions[2].GetCorrectAnswer());
            quizManager.SetUserAnswer(3, quizManager.questions[3].GetCorrectAnswer());
            quizManager.SetUserAnswer(4, quizManager.questions[4].GetCorrectAnswer());

            //in urma validarii, ar trebui sa avem 5 raspunsuri gresite
            proiect.Question[] wrongAnswers = quizManager.ValidateAnswers();

            Assert.AreEqual(wrongAnswers.Length, 5);
            Assert.AreEqual(quizManager.questions[5], wrongAnswers[0]);
            Assert.AreEqual(quizManager.questions[6], wrongAnswers[1]);
            Assert.AreEqual(quizManager.questions[7], wrongAnswers[2]);
            Assert.AreEqual(quizManager.questions[8], wrongAnswers[3]);
            Assert.AreEqual(quizManager.questions[9], wrongAnswers[4]);
        }
    }
}
