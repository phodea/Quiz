using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectQuestion
{
    [TestClass]
    public class UnitTestQuestion
    {
        /// <summary>
        /// Construirea unui obiect de tip Question, si testarea metodei de returnare a raspunsului corect
        /// </summary>
        [TestMethod]
        public void TestMethodGetCorrectAnswer()
        {
            proiect.Question question = new proiect.Question("Intrebare", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            Assert.AreEqual(question.GetCorrectAnswer(), 2);
        }

        /// <summary>
        /// Construirea unui obiect si testarea logicii de validare a unui raspuns corect
        /// </summary>
        [TestMethod]
        public void TestMethodGetValidateGoodAnswer()
        {
            proiect.Question question = new proiect.Question("Intrebare", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            question.selectedAnswer = 2;
            Assert.AreEqual(question.ValidateAnswer(), true);
        }

        /// <summary>
        /// Construirea unui obiect si testarea logicii de validare a unui raspuns corect
        /// </summary>
        [TestMethod]
        public void TestMethodGetCorrectValidateWrongAnswer()
        {
            proiect.Question question = new proiect.Question("Intrebare", new[] { "Raspuns1", "Raspuns2", "Raspuns3", "Raspuns4" }, 2);
            question.selectedAnswer = 1;
            Assert.AreEqual(question.ValidateAnswer(), false);
        }
    }
}
