namespace EkaFormini
{
    partial class EkaLomakeFm
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
            this.TekstiLB = new System.Windows.Forms.Label();
            this.PainikeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TekstiLB
            // 
            this.TekstiLB.AutoSize = true;
            this.TekstiLB.Location = new System.Drawing.Point(12, 9);
            this.TekstiLB.Name = "TekstiLB";
            this.TekstiLB.Size = new System.Drawing.Size(126, 29);
            this.TekstiLB.TabIndex = 0;
            this.TekstiLB.Text = "Joku teksti";
            this.TekstiLB.Visible = false;
            // 
            // PainikeBT
            // 
            this.PainikeBT.BackColor = System.Drawing.Color.DarkRed;
            this.PainikeBT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PainikeBT.ForeColor = System.Drawing.Color.Bisque;
            this.PainikeBT.Location = new System.Drawing.Point(12, 41);
            this.PainikeBT.Name = "PainikeBT";
            this.PainikeBT.Size = new System.Drawing.Size(143, 39);
            this.PainikeBT.TabIndex = 1;
            this.PainikeBT.Text = "Älä paina minua";
            this.PainikeBT.UseVisualStyleBackColor = false;
            this.PainikeBT.Click += new System.EventHandler(this.PainikeBT_Click);
            // 
            // EkaLomakeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 87);
            this.Controls.Add(this.PainikeBT);
            this.Controls.Add(this.TekstiLB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "EkaLomakeFm";
            this.Text = "Minun ihan eka lomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TekstiLB;
        private System.Windows.Forms.Button PainikeBT;
    }
}

