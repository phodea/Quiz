using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectQuizManager
{
    [TestClass]
    public class UnitTestQuizManager
    {
        [TestMethod]
        public void TestMethodGenerateQuiz()
        {
            //arrange
            proiect.QuizManager quizManager = new proiect.QuizManager(1);

            //act
            quizManager.GenerateQuiz();

            //assert de schimbat cu 10
            Assert.AreEqual(quizManager.questions.Length, 3);
        }

        [TestMethod]
        public void TestMethodGenerateQuizNull()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(1);

            Assert.AreEqual(quizManager.questions, null);
        }

        [TestMethod]
        public void TestMethodGenerateQuizInvalidDifficulty()
        {
            proiect.QuizManager quizManager = new proiect.QuizManager(16);

            quizManager.GenerateQuiz();

            Assert.AreEqual(quizManager.questions, null);
        }
    }
}
