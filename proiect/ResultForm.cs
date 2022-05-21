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
{   /// <summary>
    /// Fereastra in care se face afisarea rezultatelor
    /// </summary>
    public partial class ResultForm : Form
    {
        Question[] wrongAnswers;
        int totalQuestions;
        public ResultForm(int totalQuestions, Question[] wrongAnswers)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.wrongAnswers = wrongAnswers;
            this.totalQuestions = totalQuestions;
            this.FormClosing += ResultForm_FormClosing;
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
                    else if (i == result.getCorrectAnswer())
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
