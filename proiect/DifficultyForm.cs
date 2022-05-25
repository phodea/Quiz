/****************************************************************************
 *                                                                          *
 *  File:        DifficultyForm.cs                                          *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                               *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                       *
 *  Website:     https://github.com/phodea/Quiz                             *
 *  Description: Fereastra in care utilizatorul alege dificultatea quiz-ului*
 *                                                                          *
 ****************************************************************************/

using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class DifficultyForm : Form
    {
        public DifficultyForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void buttonIncepator_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            parent.SetDifficulty(0);
            this.Close();
        }

        private void buttonMediu_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            parent.SetDifficulty(1);
            this.Close();
        }

        private void buttonAvansat_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            parent.SetDifficulty(2);
            this.Close();
        }
    }
}
