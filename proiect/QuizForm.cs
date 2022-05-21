using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    /// <summary>
    /// Fereastra pentru sustinerea quiz-ului.
    /// </summary>
    public partial class QuizForm : Form
    {
        private QuizManager quizManager;
        private int currentQuestionIndex = 0;
        public QuizForm(int difficulty)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormClosing += QuizForm_FormClosing;
            quizManager = new QuizManager(difficulty);
            buttonFinish.Enabled = false;
        }

        //Metoda se apeleaza cand formularul se inchide,
        //inchizand si Form-ul parinte (MainForm) pentru a parasi aplicatia
        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                this.Owner.Close();
        }

        //Generarea intrebarilor pentru quiz
        private void Form2_Load(object sender, EventArgs e)
        {
            quizManager.GenerateQuiz();
            progressBarQuiz.Maximum = quizManager.questions.Length;
            DisplayQuestion(currentQuestionIndex);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        //Afisarea intrebarii precedente
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                DisplayQuestion(--currentQuestionIndex);
            }
            else
            {
            }
        }

        //Afisarea intrebarii urmatoare doar daca s-a furnizat un raspuns
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex + 1 < quizManager.questions.Length)
            {
                //verificare daca s-a furnizat un raspuns pentru intrebarea curenta
                if (quizManager.questions[currentQuestionIndex].selectedAnswer == -1)
                {
                    MessageBox.Show("Selectati cel putin un raspuns pentru a trece mai departe");
                }
                else
                {
                    progressBarQuiz.PerformStep();
                    DisplayQuestion(++currentQuestionIndex);
                }
            }
            else
            {
            }
        }

        //Afisarea intrebarii cu indexul questionIndex
        private void DisplayQuestion(int questionIndex)
        {
            Question question = quizManager.questions[questionIndex];
            labelIntrebare.Text = question.questionDescription;
            radioButtonOption1.Text = question.answers[0];
            radioButtonOption2.Text = question.answers[1];
            radioButtonOption3.Text = question.answers[2];
            radioButtonOption4.Text = question.answers[3];

            //in cazul in care utilizatorul a ales deja un raspuns pentru aceasta intrebare,
            //raspunsul ales anterior va fi cel bifat
            switch(question.selectedAnswer)
            {
                case 0:
                    radioButtonOption1.Checked = true;
                    break;
                case 1:
                    radioButtonOption2.Checked = true;
                    break;
                case 2:
                    radioButtonOption3.Checked = true;
                    break;
                case 3:
                    radioButtonOption4.Checked = true;
                    break;
                default:
                    radioButtonOption1.Checked = false;
                    radioButtonOption2.Checked = false;
                    radioButtonOption3.Checked = false;
                    radioButtonOption4.Checked = false;
                    break;
            }
        }
        
        private void radioButtonOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOption1.Checked)
            {
                if (currentQuestionIndex == quizManager.questions.Length - 1)
                {
                    progressBarQuiz.PerformStep();
                    buttonFinish.Enabled = true;
                }
                quizManager.setUserAnswer(currentQuestionIndex, 0);
            }
        }

        private void radioButtonOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOption2.Checked)
            {
                if (currentQuestionIndex == quizManager.questions.Length - 1)
                {
                    progressBarQuiz.PerformStep();
                    buttonFinish.Enabled = true;
                }
                quizManager.setUserAnswer(currentQuestionIndex, 1);
            }
        }

        private void radioButtonOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOption3.Checked)
            {
                if (currentQuestionIndex == quizManager.questions.Length - 1)
                {
                    progressBarQuiz.PerformStep();
                    buttonFinish.Enabled = true;
                }
                quizManager.setUserAnswer(currentQuestionIndex, 2);
            }
        }

        private void radioButtonOption4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOption4.Checked)
            {
                if (currentQuestionIndex == quizManager.questions.Length - 1)
                {
                    progressBarQuiz.PerformStep();
                    buttonFinish.Enabled = true;
                }
                quizManager.setUserAnswer(currentQuestionIndex, 3);
            }
        }

        //La terminarea Quiz-ului, se va trece la urmatoarea fereastra (ResultForm)
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;

            int numberOfQuestions = quizManager.questions.Length;
            Question[] wrongAnswers = quizManager.validateAnswers();

            ResultForm resultForm = new ResultForm(numberOfQuestions, wrongAnswers);

            resultForm.Show(this);
            this.Hide();
        }
    }
}
