namespace proiect
{
    partial class QuizForm
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
            this.groupBoxIntrebare = new System.Windows.Forms.GroupBox();
            this.radioButtonOption4 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption1 = new System.Windows.Forms.RadioButton();
            this.labelIntrebare = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.progressBarQuiz = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.groupBoxIntrebare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIntrebare
            // 
            this.groupBoxIntrebare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIntrebare.Controls.Add(this.radioButtonOption4);
            this.groupBoxIntrebare.Controls.Add(this.radioButtonOption3);
            this.groupBoxIntrebare.Controls.Add(this.radioButtonOption2);
            this.groupBoxIntrebare.Controls.Add(this.radioButtonOption1);
            this.groupBoxIntrebare.Controls.Add(this.labelIntrebare);
            this.groupBoxIntrebare.Location = new System.Drawing.Point(23, 25);
            this.groupBoxIntrebare.Name = "groupBoxIntrebare";
            this.groupBoxIntrebare.Size = new System.Drawing.Size(698, 262);
            this.groupBoxIntrebare.TabIndex = 0;
            this.groupBoxIntrebare.TabStop = false;
            this.groupBoxIntrebare.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonOption4
            // 
            this.radioButtonOption4.AutoSize = true;
            this.radioButtonOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOption4.Location = new System.Drawing.Point(32, 208);
            this.radioButtonOption4.Name = "radioButtonOption4";
            this.radioButtonOption4.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOption4.TabIndex = 6;
            this.radioButtonOption4.TabStop = true;
            this.radioButtonOption4.UseVisualStyleBackColor = true;
            this.radioButtonOption4.CheckedChanged += new System.EventHandler(this.radioButtonOption4_CheckedChanged);
            // 
            // radioButtonOption3
            // 
            this.radioButtonOption3.AutoSize = true;
            this.radioButtonOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOption3.Location = new System.Drawing.Point(32, 173);
            this.radioButtonOption3.Name = "radioButtonOption3";
            this.radioButtonOption3.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOption3.TabIndex = 5;
            this.radioButtonOption3.TabStop = true;
            this.radioButtonOption3.UseVisualStyleBackColor = true;
            this.radioButtonOption3.CheckedChanged += new System.EventHandler(this.radioButtonOption3_CheckedChanged);
            // 
            // radioButtonOption2
            // 
            this.radioButtonOption2.AutoSize = true;
            this.radioButtonOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOption2.Location = new System.Drawing.Point(32, 141);
            this.radioButtonOption2.Name = "radioButtonOption2";
            this.radioButtonOption2.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOption2.TabIndex = 4;
            this.radioButtonOption2.TabStop = true;
            this.radioButtonOption2.UseVisualStyleBackColor = true;
            this.radioButtonOption2.CheckedChanged += new System.EventHandler(this.radioButtonOption2_CheckedChanged);
            // 
            // radioButtonOption1
            // 
            this.radioButtonOption1.AutoSize = true;
            this.radioButtonOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOption1.Location = new System.Drawing.Point(32, 106);
            this.radioButtonOption1.Name = "radioButtonOption1";
            this.radioButtonOption1.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOption1.TabIndex = 3;
            this.radioButtonOption1.TabStop = true;
            this.radioButtonOption1.UseVisualStyleBackColor = true;
            this.radioButtonOption1.CheckedChanged += new System.EventHandler(this.radioButtonOption1_CheckedChanged);
            // 
            // labelIntrebare
            // 
            this.labelIntrebare.AutoSize = true;
            this.labelIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIntrebare.Location = new System.Drawing.Point(28, 16);
            this.labelIntrebare.Name = "labelIntrebare";
            this.labelIntrebare.Size = new System.Drawing.Size(0, 22);
            this.labelIntrebare.TabIndex = 0;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPrevious.Location = new System.Drawing.Point(23, 338);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(199, 30);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "Intrebarea precedenta";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNext.Location = new System.Drawing.Point(522, 338);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(199, 30);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Intrebarea urmatoare";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // progressBarQuiz
            // 
            this.progressBarQuiz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarQuiz.Location = new System.Drawing.Point(219, 404);
            this.progressBarQuiz.Maximum = 10;
            this.progressBarQuiz.Name = "progressBarQuiz";
            this.progressBarQuiz.Size = new System.Drawing.Size(307, 23);
            this.progressBarQuiz.Step = 1;
            this.progressBarQuiz.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progres";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFinish.Location = new System.Drawing.Point(275, 338);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(199, 30);
            this.buttonFinish.TabIndex = 5;
            this.buttonFinish.Text = "Finalizeaza quiz";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarQuiz);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.groupBoxIntrebare);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxIntrebare.ResumeLayout(false);
            this.groupBoxIntrebare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIntrebare;
        private System.Windows.Forms.Label labelIntrebare;
        private System.Windows.Forms.RadioButton radioButtonOption4;
        private System.Windows.Forms.RadioButton radioButtonOption3;
        private System.Windows.Forms.RadioButton radioButtonOption2;
        private System.Windows.Forms.RadioButton radioButtonOption1;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ProgressBar progressBarQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFinish;
    }
}