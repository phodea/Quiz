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
    /// Fereastra principala, unde se pot alege dificultatea, setarile, sau porni Quiz-ul
    /// </summary>
    public partial class MainForm : Form
    {
        private int difficulty = 1;
        private int width;
        private int height;
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            width = this.Width;
            height = this.Height;
        }

        //Navigare spre fereastra QuizForm
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm(difficulty);
            quizForm.Show(this);
            this.Hide();
        }

        //Afisarea dialogului pentru selectarea dificultatii
        private void buttonDifficulty_Click(object sender, EventArgs e)
        {
            DifficultyForm difficultyForm = new DifficultyForm();
            difficultyForm.ShowDialog(this);
        }

        public void setDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public void setResolution(int width, int height)
        {
            this.width = width;
            this.Width = width;
            this.height = height;
            this.Height = height;
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
