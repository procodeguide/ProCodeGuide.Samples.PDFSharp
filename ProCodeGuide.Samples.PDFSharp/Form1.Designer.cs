namespace ProCodeGuide.Samples.PDFSharp
{
    partial class Form1
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
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeneratePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePDF.Location = new System.Drawing.Point(192, 131);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(156, 53);
            this.btnGeneratePDF.TabIndex = 0;
            this.btnGeneratePDF.Text = "Generate PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = false;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 304);
            this.Controls.Add(this.btnGeneratePDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePDF;
    }
}

