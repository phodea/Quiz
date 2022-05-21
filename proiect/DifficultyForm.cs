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
    /// Fereastra folosita pentru selectarea dificultatii
    /// </summary>
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
            parent.setDifficulty(0);
            this.Close();
        }

        private void buttonMediu_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            parent.setDifficulty(1);
            this.Close();
        }

        private void buttonAvansat_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            parent.setDifficulty(2);
            this.Close();
        }
    }
}
