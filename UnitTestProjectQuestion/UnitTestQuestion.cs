using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectQuestion
{
    [TestClass]
    public class UnitTestQuestion
    {
        [TestMethod]
        public void TestMethodGetCorrectAnswer()
        {
            proiect.Question question = new proiect.Question("Intrebare", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            Assert.AreEqual(question.getCorrectAnswer(), 2);
        }

        [TestMethod]
        public void TestMethodGetValidateGoodAnswer()
        {
            proiect.Question question = new proiect.Question("Intrebare", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            question.selectedAnswer = 2;
            Assert.AreEqual(question.ValidateAnswer(), true);
        }

        [TestMethod]
        public void TestMethodGetCorrectValidateWrongAnswer()
        {
            proiect.Question question = new proiect.Question("Intrebare", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            question.selectedAnswer = 1;
            Assert.AreEqual(question.ValidateAnswer(), false);
        }
    }
}
