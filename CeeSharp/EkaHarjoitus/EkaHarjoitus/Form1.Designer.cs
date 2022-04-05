namespace EkaHarjoitus
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
            this.VaihdettavaLB = new System.Windows.Forms.Label();
            this.lukuTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VaihdettavaLB
            // 
            this.VaihdettavaLB.AutoSize = true;
            this.VaihdettavaLB.Location = new System.Drawing.Point(13, 10);
            this.VaihdettavaLB.Name = "VaihdettavaLB";
            this.VaihdettavaLB.Size = new System.Drawing.Size(260, 29);
            this.VaihdettavaLB.TabIndex = 0;
            this.VaihdettavaLB.Text = "Anna luku (-999 lopetus):";
            // 
            // lukuTB
            // 
            this.lukuTB.Location = new System.Drawing.Point(279, 7);
            this.lukuTB.Name = "lukuTB";
            this.lukuTB.Size = new System.Drawing.Size(249, 37);
            this.lukuTB.TabIndex = 1;
            this.lukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lukuTB_KeyPress);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(13, 61);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(0, 29);
            this.vastausLB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 99);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.lukuTB);
            this.Controls.Add(this.VaihdettavaLB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VaihdettavaLB;
        private System.Windows.Forms.TextBox lukuTB;
        private System.Windows.Forms.Label vastausLB;
    }
}

