
namespace proiect
{
    partial class DifficultyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIncepator = new System.Windows.Forms.Button();
            this.buttonMediu = new System.Windows.Forms.Button();
            this.buttonAvansat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIncepator
            // 
            this.buttonIncepator.Location = new System.Drawing.Point(26, 22);
            this.buttonIncepator.Name = "buttonIncepator";
            this.buttonIncepator.Size = new System.Drawing.Size(120, 24);
            this.buttonIncepator.TabIndex = 0;
            this.buttonIncepator.Text = "Incepator";
            this.buttonIncepator.UseVisualStyleBackColor = true;
            this.buttonIncepator.Click += new System.EventHandler(this.buttonIncepator_Click);
            // 
            // buttonMediu
            // 
            this.buttonMediu.Location = new System.Drawing.Point(26, 65);
            this.buttonMediu.Name = "buttonMediu";
            this.buttonMediu.Size = new System.Drawing.Size(120, 24);
            this.buttonMediu.TabIndex = 1;
            this.buttonMediu.Text = "Mediu";
            this.buttonMediu.UseVisualStyleBackColor = true;
            this.buttonMediu.Click += new System.EventHandler(this.buttonMediu_Click);
            // 
            // buttonAvansat
            // 
            this.buttonAvansat.Location = new System.Drawing.Point(26, 104);
            this.buttonAvansat.Name = "buttonAvansat";
            this.buttonAvansat.Size = new System.Drawing.Size(120, 24);
            this.buttonAvansat.TabIndex = 2;
            this.buttonAvansat.Text = "Avansat";
            this.buttonAvansat.UseVisualStyleBackColor = true;
            this.buttonAvansat.Click += new System.EventHandler(this.buttonAvansat_Click);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 140);
            this.Controls.Add(this.buttonAvansat);
            this.Controls.Add(this.buttonMediu);
            this.Controls.Add(this.buttonIncepator);
            this.Name = "DifficultyForm";
            this.Text = "Dificultate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncepator;
        private System.Windows.Forms.Button buttonMediu;
        private System.Windows.Forms.Button buttonAvansat;
    }
}