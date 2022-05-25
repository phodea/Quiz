using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectDatabaseManager
{
    [TestClass]
    public class UnitTestDatabaseManager
    {
        /// <summary>
        /// Testarea numarului intrebarilor de nivel "Usor" din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGetQuestionsEasy()
        {
            Assert.AreEqual(proiect.DatabaseManager.GetInstance().GetQuestions(0).Length, 15);
        }

        /// <summary>
        /// Testarea numarului intrebarilor de nivel "Mediu" din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGetQuestionsNormal()
        {
            Assert.AreEqual(proiect.DatabaseManager.GetInstance().GetQuestions(1).Length, 15);
        }

        /// <summary>
        /// Testarea numarului intrebarilor de nivel "Greu" din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGetQuestionsHard()
        {
            Assert.AreEqual(proiect.DatabaseManager.GetInstance().GetQuestions(2).Length, 15);
        }

        /// <summary>
        /// Testarea preluarii intrebarilor de nivel de dificultate invalid
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodGetQuestionsException1()
        {
            proiect.DatabaseManager.GetInstance().GetQuestions(-1);
        }

        /// <summary>
        /// Testarea preluarii intrebarilor de nivel de dificultate invalid
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodGetQuestionsException2()
        {
            proiect.DatabaseManager.GetInstance().GetQuestions(30);
        }

        /// <summary>
        /// Testarea continutului primei intrebari de nivel "Usor" din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGetFirstEasyQuestion()
        {
            proiect.Question [] questions = proiect.DatabaseManager.GetInstance().GetQuestions(0);
            Assert.AreEqual(questions[0].questionDescription, "Care este sursa principala de hrana a ursului panda?");
            Assert.AreEqual(questions[0].answers[0], "Banane");
            Assert.AreEqual(questions[0].answers[1], "Bambus");
            Assert.AreEqual(questions[0].answers[2], "Carne");
            Assert.AreEqual(questions[0].answers[3], "Iarba");
            Assert.AreEqual(questions[0].GetCorrectAnswer(), 1);
        }

        /// <summary>
        /// Testarea continutului primei intrebari de nivel "Mediu" din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGetFirstNormalQuestion()
        {
            proiect.Question[] questions = proiect.DatabaseManager.GetInstance().GetQuestions(1);
            Assert.AreEqual(questions[0].questionDescription, "Care sunt grupele principale de sange?");
            Assert.AreEqual(questions[0].answers[0], "A,B,C & D");
            Assert.AreEqual(questions[0].answers[1], "A,AB,CD & O");
            Assert.AreEqual(questions[0].answers[2], "A,B,AB, & O");
            Assert.AreEqual(questions[0].answers[3], "B,C,D & O");
            Assert.AreEqual(questions[0].GetCorrectAnswer(), 2);
        }

        /// <summary>
        /// Testarea continutului primei intrebari de nivel "Avansat" din baza de date
        /// </summary>
        [TestMethod]
        public void TestMethodGetFirstHardQuestion()
        {
            proiect.Question[] questions = proiect.DatabaseManager.GetInstance().GetQuestions(2);
            Assert.AreEqual(questions[0].questionDescription, "Care este cel mai nou organ uman descoperit de catre oamenii de stiinta in 2020?");
            Assert.AreEqual(questions[0].answers[0], "Bursa Copulatrix");
            Assert.AreEqual(questions[0].answers[1], "Organul lui Bidder");
            Assert.AreEqual(questions[0].answers[2], "Glandele Salivare");
            Assert.AreEqual(questions[0].answers[3], "Osul Palmei");
            Assert.AreEqual(questions[0].GetCorrectAnswer(), 2);
        }

        /// <summary>
        /// Testarea metodei GetInstance
        /// </summary>
        [TestMethod]
        public void TestMethodGetInstance()
        {
            proiect.DatabaseManager instance1 = proiect.DatabaseManager.GetInstance();
            proiect.DatabaseManager instance2 = proiect.DatabaseManager.GetInstance();
            Assert.AreEqual(instance1, instance2);
        }

        /// <summary>
        /// Testarea metodei ReleaseInstance
        /// </summary>
        [TestMethod]
        public void TestMethodReleaseInstance()
        {
            proiect.DatabaseManager instance1 = proiect.DatabaseManager.GetInstance();
            proiect.DatabaseManager.ReleaseInstance();
            proiect.DatabaseManager instance2 = proiect.DatabaseManager.GetInstance();
            Assert.IsFalse(instance1 == instance2);
        }

        [TestMethod]
        public void TestMethodGetIncorrectQuestion()
        {
            proiect.Question[] questions = proiect.DatabaseManager.GetInstance().GetQuestions(2);
            Assert.IsFalse(questions[0].questionDescription == "Care este cea mai mare padure tropicala de pe glob?");
        }
    }
}
