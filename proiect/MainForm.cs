/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                             *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                     *
 *  Website:     https://github.com/phodea/Quiz                           *
 *  Description: Fereastra principala a aplicatiei, cea din care se poate *
 *  porni quiz-ul, se pot modifica setarile sau se poate alege            *
 *  dificultatea.                                                         *
 *                                                                        *
 **************************************************************************/
using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class MainForm : Form
    {
        private int difficulty = 1;
        private int width;
        private int height;
        public MainForm()
        {
            InitializeComponent();
            width = this.Width;
            height = this.Height;
            this.CenterToScreen();

            this.MinimumSize = new System.Drawing.Size(500, 500);
        }

        //Navigare spre fereastra QuizForm
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm(difficulty, width, height);
            quizForm.Show(this);
            this.Hide();
        }

        //Afisarea dialogului pentru selectarea dificultatii
        private void buttonDifficulty_Click(object sender, EventArgs e)
        {
            DifficultyForm difficultyForm = new DifficultyForm();
            difficultyForm.ShowDialog(this);
        }

        public void SetDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public void SetResolution(int width, int height)
        {
            this.width = width;
            this.Width = width;
            this.height = height;
            this.Height = height;
            this.CenterToScreen();
        }

        //Afisarea dialogului pentru selectarea setarilor
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
