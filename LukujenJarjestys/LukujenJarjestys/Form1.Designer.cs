namespace LukujenJarjestys
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
            this.salasanaPL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // salasanaPL
            // 
            this.salasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPL.Location = new System.Drawing.Point(0, 0);
            this.salasanaPL.Name = "salasanaPL";
            this.salasanaPL.Size = new System.Drawing.Size(1132, 595);
            this.salasanaPL.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 595);
            this.Controls.Add(this.salasanaPL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel salasanaPL;
    }
}

