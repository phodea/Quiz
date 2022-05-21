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
    /// Fereastra folosita pentru selectarea setarilor de catre utilizator
    /// </summary>
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

                parent.setResolution(width, height);
                this.Close();
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati o optiune");
            }
        }
    }
}
