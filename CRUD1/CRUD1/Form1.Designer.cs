namespace CRUD1
{
    partial class CRUDFM
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
            this.TervetuloLB = new System.Windows.Forms.Label();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.UusiKTBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.TervetuloPL = new System.Windows.Forms.Panel();
            this.KirjauduPL = new System.Windows.Forms.Panel();
            this.VirheLB = new System.Windows.Forms.Label();
            this.KirjauduSisaanBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttäjatunnusLB = new System.Windows.Forms.Label();
            this.UusiKayttajaPL = new System.Windows.Forms.Panel();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PostitoimipaikkaTB = new System.Windows.Forms.TextBox();
            this.PostinumeroTB = new System.Windows.Forms.TextBox();
            this.LahiosoiteTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.LahiosoiteLB = new System.Windows.Forms.Label();
            this.SukunimiLB = new System.Windows.Forms.Label();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.TervetuloPL.SuspendLayout();
            this.KirjauduPL.SuspendLayout();
            this.UusiKayttajaPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TervetuloLB
            // 
            this.TervetuloLB.AutoSize = true;
            this.TervetuloLB.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TervetuloLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TervetuloLB.Location = new System.Drawing.Point(139, 52);
            this.TervetuloLB.Name = "TervetuloLB";
            this.TervetuloLB.Size = new System.Drawing.Size(499, 57);
            this.TervetuloLB.TabIndex = 0;
            this.TervetuloLB.Text = "Tervetuloa! Mitä haluat tehdä?";
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.BackColor = System.Drawing.Color.PaleGreen;
            this.KirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.Location = new System.Drawing.Point(319, 144);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(138, 49);
            this.KirjauduBT.TabIndex = 1;
            this.KirjauduBT.Text = "Kirjautua";
            this.KirjauduBT.UseVisualStyleBackColor = false;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // UusiKTBT
            // 
            this.UusiKTBT.BackColor = System.Drawing.Color.Aqua;
            this.UusiKTBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiKTBT.Location = new System.Drawing.Point(172, 233);
            this.UusiKTBT.Name = "UusiKTBT";
            this.UusiKTBT.Size = new System.Drawing.Size(433, 49);
            this.UusiKTBT.TabIndex = 2;
            this.UusiKTBT.Text = "Luoda uuden käyttäjätunnuksen";
            this.UusiKTBT.UseVisualStyleBackColor = false;
            // 
            // LopetaBT
            // 
            this.LopetaBT.BackColor = System.Drawing.Color.Crimson;
            this.LopetaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopetaBT.Location = new System.Drawing.Point(261, 331);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(255, 49);
            this.LopetaBT.TabIndex = 3;
            this.LopetaBT.Text = "Lopettaa ohjelman";
            this.LopetaBT.UseVisualStyleBackColor = false;
            // 
            // TervetuloPL
            // 
            this.TervetuloPL.Controls.Add(this.TervetuloLB);
            this.TervetuloPL.Controls.Add(this.LopetaBT);
            this.TervetuloPL.Controls.Add(this.KirjauduBT);
            this.TervetuloPL.Controls.Add(this.UusiKTBT);
            this.TervetuloPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TervetuloPL.Location = new System.Drawing.Point(0, 0);
            this.TervetuloPL.Name = "TervetuloPL";
            this.TervetuloPL.Size = new System.Drawing.Size(800, 450);
            this.TervetuloPL.TabIndex = 4;
            // 
            // KirjauduPL
            // 
            this.KirjauduPL.BackColor = System.Drawing.Color.SkyBlue;
            this.KirjauduPL.Controls.Add(this.VirheLB);
            this.KirjauduPL.Controls.Add(this.KirjauduSisaanBT);
            this.KirjauduPL.Controls.Add(this.SalasanaTB);
            this.KirjauduPL.Controls.Add(this.KayttajatunnusTB);
            this.KirjauduPL.Controls.Add(this.SalasanaLB);
            this.KirjauduPL.Controls.Add(this.KayttäjatunnusLB);
            this.KirjauduPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KirjauduPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduPL.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KirjauduPL.Location = new System.Drawing.Point(0, 0);
            this.KirjauduPL.Name = "KirjauduPL";
            this.KirjauduPL.Size = new System.Drawing.Size(800, 450);
            this.KirjauduPL.TabIndex = 4;
            // 
            // VirheLB
            // 
            this.VirheLB.AutoSize = true;
            this.VirheLB.Location = new System.Drawing.Point(113, 347);
            this.VirheLB.Name = "VirheLB";
            this.VirheLB.Size = new System.Drawing.Size(70, 25);
            this.VirheLB.TabIndex = 5;
            this.VirheLB.Text = "label1";
            this.VirheLB.Visible = false;
            // 
            // KirjauduSisaanBT
            // 
            this.KirjauduSisaanBT.BackColor = System.Drawing.Color.DodgerBlue;
            this.KirjauduSisaanBT.Location = new System.Drawing.Point(297, 220);
            this.KirjauduSisaanBT.Name = "KirjauduSisaanBT";
            this.KirjauduSisaanBT.Size = new System.Drawing.Size(317, 47);
            this.KirjauduSisaanBT.TabIndex = 4;
            this.KirjauduSisaanBT.Text = "Kirjaudu";
            this.KirjauduSisaanBT.UseVisualStyleBackColor = false;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(297, 157);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(317, 31);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.Location = new System.Drawing.Point(297, 78);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.Size = new System.Drawing.Size(317, 31);
            this.KayttajatunnusTB.TabIndex = 2;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SalasanaLB.Location = new System.Drawing.Point(108, 160);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(108, 25);
            this.SalasanaLB.TabIndex = 1;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KayttäjatunnusLB
            // 
            this.KayttäjatunnusLB.AutoSize = true;
            this.KayttäjatunnusLB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KayttäjatunnusLB.Location = new System.Drawing.Point(108, 81);
            this.KayttäjatunnusLB.Name = "KayttäjatunnusLB";
            this.KayttäjatunnusLB.Size = new System.Drawing.Size(167, 25);
            this.KayttäjatunnusLB.TabIndex = 0;
            this.KayttäjatunnusLB.Text = "Käyttäjätunnus: ";
            // 
            // UusiKayttajaPL
            // 
            this.UusiKayttajaPL.BackColor = System.Drawing.Color.LightSteelBlue;
            this.UusiKayttajaPL.Controls.Add(this.PuhelinTB);
            this.UusiKayttajaPL.Controls.Add(this.EmailTB);
            this.UusiKayttajaPL.Controls.Add(this.PostitoimipaikkaTB);
            this.UusiKayttajaPL.Controls.Add(this.PostinumeroTB);
            this.UusiKayttajaPL.Controls.Add(this.LahiosoiteTB);
            this.UusiKayttajaPL.Controls.Add(this.SukunimiTB);
            this.UusiKayttajaPL.Controls.Add(this.EtunimiTB);
            this.UusiKayttajaPL.Controls.Add(this.PuhelinLB);
            this.UusiKayttajaPL.Controls.Add(this.EmailLB);
            this.UusiKayttajaPL.Controls.Add(this.PostitoimipaikkaLB);
            this.UusiKayttajaPL.Controls.Add(this.PostinumeroLB);
            this.UusiKayttajaPL.Controls.Add(this.LahiosoiteLB);
            this.UusiKayttajaPL.Controls.Add(this.SukunimiLB);
            this.UusiKayttajaPL.Controls.Add(this.EtunimiLB);
            this.UusiKayttajaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UusiKayttajaPL.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiKayttajaPL.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UusiKayttajaPL.Location = new System.Drawing.Point(0, 0);
            this.UusiKayttajaPL.Name = "UusiKayttajaPL";
            this.UusiKayttajaPL.Size = new System.Drawing.Size(800, 450);
            this.UusiKayttajaPL.TabIndex = 4;
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Location = new System.Drawing.Point(260, 394);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(187, 36);
            this.PuhelinTB.TabIndex = 13;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(260, 352);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(187, 36);
            this.EmailTB.TabIndex = 12;
            // 
            // PostitoimipaikkaTB
            // 
            this.PostitoimipaikkaTB.Location = new System.Drawing.Point(260, 310);
            this.PostitoimipaikkaTB.Name = "PostitoimipaikkaTB";
            this.PostitoimipaikkaTB.Size = new System.Drawing.Size(187, 36);
            this.PostitoimipaikkaTB.TabIndex = 11;
            // 
            // PostinumeroTB
            // 
            this.PostinumeroTB.Location = new System.Drawing.Point(260, 268);
            this.PostinumeroTB.Name = "PostinumeroTB";
            this.PostinumeroTB.Size = new System.Drawing.Size(187, 36);
            this.PostinumeroTB.TabIndex = 10;
            // 
            // LahiosoiteTB
            // 
            this.LahiosoiteTB.Location = new System.Drawing.Point(260, 226);
            this.LahiosoiteTB.Name = "LahiosoiteTB";
            this.LahiosoiteTB.Size = new System.Drawing.Size(187, 36);
            this.LahiosoiteTB.TabIndex = 9;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Location = new System.Drawing.Point(260, 184);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(187, 36);
            this.SukunimiTB.TabIndex = 8;
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Location = new System.Drawing.Point(260, 142);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(187, 36);
            this.EtunimiTB.TabIndex = 7;
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(12, 403);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(112, 27);
            this.PuhelinLB.TabIndex = 6;
            this.PuhelinLB.Text = "Puhelin:";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(21, 363);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(90, 27);
            this.EmailLB.TabIndex = 5;
            this.EmailLB.Text = "Email:";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(12, 319);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(222, 27);
            this.PostitoimipaikkaLB.TabIndex = 4;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka:";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(12, 277);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(167, 27);
            this.PostinumeroLB.TabIndex = 3;
            this.PostinumeroLB.Text = "Postinumero:";
            // 
            // LahiosoiteLB
            // 
            this.LahiosoiteLB.AutoSize = true;
            this.LahiosoiteLB.Location = new System.Drawing.Point(12, 235);
            this.LahiosoiteLB.Name = "LahiosoiteLB";
            this.LahiosoiteLB.Size = new System.Drawing.Size(141, 27);
            this.LahiosoiteLB.TabIndex = 2;
            this.LahiosoiteLB.Text = "Lähiosoite:";
            // 
            // SukunimiLB
            // 
            this.SukunimiLB.AutoSize = true;
            this.SukunimiLB.Location = new System.Drawing.Point(12, 193);
            this.SukunimiLB.Name = "SukunimiLB";
            this.SukunimiLB.Size = new System.Drawing.Size(135, 27);
            this.SukunimiLB.TabIndex = 1;
            this.SukunimiLB.Text = "Sukunimi:";
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Location = new System.Drawing.Point(12, 151);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(115, 27);
            this.EtunimiLB.TabIndex = 0;
            this.EtunimiLB.Text = "Etunimi:";
            // 
            // CRUDFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UusiKayttajaPL);
            this.Controls.Add(this.KirjauduPL);
            this.Controls.Add(this.TervetuloPL);
            this.Name = "CRUDFM";
            this.Text = "CRUD";
            this.TervetuloPL.ResumeLayout(false);
            this.TervetuloPL.PerformLayout();
            this.KirjauduPL.ResumeLayout(false);
            this.KirjauduPL.PerformLayout();
            this.UusiKayttajaPL.ResumeLayout(false);
            this.UusiKayttajaPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TervetuloLB;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Button UusiKTBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Panel TervetuloPL;
        private System.Windows.Forms.Panel KirjauduPL;
        private System.Windows.Forms.Label VirheLB;
        private System.Windows.Forms.Button KirjauduSisaanBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajatunnusTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttäjatunnusLB;
        private System.Windows.Forms.Panel UusiKayttajaPL;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.Label LahiosoiteLB;
        private System.Windows.Forms.Label SukunimiLB;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PostitoimipaikkaTB;
        private System.Windows.Forms.TextBox PostinumeroTB;
        private System.Windows.Forms.TextBox LahiosoiteTB;
    }
}

