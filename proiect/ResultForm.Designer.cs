
namespace proiect
{
    partial class ResultForm
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
            this.richTextBoxReview = new System.Windows.Forms.RichTextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxReview
            // 
            this.richTextBoxReview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxReview.Location = new System.Drawing.Point(49, 118);
            this.richTextBoxReview.Name = "richTextBoxReview";
            this.richTextBoxReview.Size = new System.Drawing.Size(681, 274);
            this.richTextBoxReview.TabIndex = 0;
            this.richTextBoxReview.Text = "";
            this.richTextBoxReview.Visible = false;
            this.richTextBoxReview.TextChanged += new System.EventHandler(this.richTextBoxReview_TextChanged);
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(299, 49);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 1;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReview
            // 
            this.buttonReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReview.Location = new System.Drawing.Point(279, 149);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(174, 27);
            this.buttonReview.TabIndex = 2;
            this.buttonReview.Text = "Afiseaza raspunsurile gresite";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 426);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.richTextBoxReview);
            this.Name = "ResultForm";
            this.Text = "Rezultate";
            this.Load += new System.EventHandler(this.resultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxReview;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonReview;
    }
}