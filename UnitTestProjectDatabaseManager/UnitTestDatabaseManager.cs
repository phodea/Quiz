using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectDatabaseManager
{
    [TestClass]
    public class UnitTestDatabaseManager
    {
        [TestMethod]
        public void TestMethodGetQuestionsEasy()
        {
            Assert.AreEqual(proiect.DatabaseManager.getInstance().getQuestions(0).Length, 3);
        }

        [TestMethod]
        public void TestMethodGetQuestionsNormal()
        {
            Assert.AreEqual(proiect.DatabaseManager.getInstance().getQuestions(1).Length, 3);
        }

        [TestMethod]
        public void TestMethodGetQuestionsHard()
        {
            Assert.AreEqual(proiect.DatabaseManager.getInstance().getQuestions(2).Length, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodGetQuestionsException()
        {
            proiect.DatabaseManager.getInstance().getQuestions(30);
        }
    }
}
