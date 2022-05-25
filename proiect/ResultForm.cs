/**************************************************************************
 *                                                                        *
 *  File:        ResultForm.cs                                            *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                             *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                     *
 *  Website:     https://github.com/phodea/Quiz                           *
 *  Description: Form-ul din care se pot vizualiza rezultatele obtinute de*
 *  uitlizator pentru quiz. Afisarea intrebarilor raspunse gresit se va   *
 *  face intr-un control de tip RichTextBox                               *
 *                                                                        *
 **************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{   /// <summary>
    /// Fereastra in care se face afisarea rezultatelor
    /// </summary>
    public partial class ResultForm : Form
    {
        Question[] wrongAnswers;
        int totalQuestions;
        public ResultForm(int totalQuestions, Question[] wrongAnswers, int width, int height)
        {
            InitializeComponent();
            this.MinimumSize = new Size(500, 500);

            this.wrongAnswers = wrongAnswers;
            this.totalQuestions = totalQuestions;
            this.FormClosing += ResultForm_FormClosing;

            this.Width = width;
            this.Height = height;

            this.CenterToScreen();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                this.Owner.Close();
        }

        //La incarcarea ferestrei, se afiseaza punctajul final
        private void resultForm_Load(object sender, EventArgs e)
        {
            labelResult.Text += "Punctaj final: " + (totalQuestions - wrongAnswers.Length).ToString() + " / " + totalQuestions.ToString();  
        }

        //Afisarea controlului de tip RichTextBox pentru a vedea intrebarile la care utilizatorul a raspuns gresit
        private void displayReview()
        {
            foreach (Question result in wrongAnswers)
            {
                richTextBoxReview.SelectionFont = new Font("Times New Roman", 13, FontStyle.Regular);
                richTextBoxReview.AppendText("\t" + result.questionDescription + "\r\n");

                for (int i = 0; i < result.answers.Length; i++)
                {
                    //selectarea culorii textului (cu rosu - raspunsul selectat de utilizator, cu verde - raspunsul corect)
                    if (i == result.selectedAnswer)
                    {
                        richTextBoxReview.SelectionFont = new Font("Times New Roman", 13, FontStyle.Regular);
                        richTextBoxReview.SelectionColor = Color.Red;
                    }
                    else if (i == result.GetCorrectAnswer())
                    {
                        richTextBoxReview.SelectionFont = new Font("Times New Roman", 13, FontStyle.Regular);
                        richTextBoxReview.SelectionColor = Color.Green;
                    }
                    else
                    {
                        richTextBoxReview.SelectionFont = new Font("Times New Roman", 13, FontStyle.Regular);
                        richTextBoxReview.SelectionColor = Color.Black;
                    }

                    richTextBoxReview.AppendText("\t\t" + result.answers[i] + "\r\n");
                }
                richTextBoxReview.AppendText("\r\n");
            }
        }

        private void richTextBoxReview_TextChanged(object sender, EventArgs e)
        {

        }

        //Daca utilizatorul apasa butonul Review se va activa controlul RichTextBox si se vor afisa pe el raspunsurile gresite
        private void buttonReview_Click(object sender, EventArgs e)
        {
            buttonReview.Enabled = false;
            buttonReview.Visible = false;

            richTextBoxReview.Visible = true;

            displayReview();
        }
    }
}
