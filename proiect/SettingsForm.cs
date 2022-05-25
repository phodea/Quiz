/**************************************************************************
 *                                                                        *
 *  File:        DifficultyForm.cs                                        *
 *  Copyright:   (c) 2022, Hodea Paul-Emanuel                             *
 *  E-mail:      paul-emanuel.hodea@student.tuiasi.ro                     *
 *  Website:     https://github.com/phodea/Quiz                           *
 *  Description: Fereastra in care utilizatorul poate alege rezolutia care*
 *  va fi salvata pentru intreaga aplicatie.                              *
 *                                                                        *
 **************************************************************************/

using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.CenterToParent();
            comboBoxResolution.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonAplica_Click(object sender, EventArgs e)
        {
            string selectedResolutionString = comboBoxResolution.Text;
            if (selectedResolutionString != "")
            {
                MainForm parent = (MainForm)this.Owner;

                string[] res = selectedResolutionString.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);

                parent.SetResolution(width, height);
                this.Close();
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati o optiune");
            }
        }
    }
}
