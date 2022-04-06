namespace Apinako
{
    partial class Apilomake
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
            this.tulostusalueDGV = new System.Windows.Forms.DataGridView();
            this.haeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tulostusalueDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tulostusalueDGV
            // 
            this.tulostusalueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tulostusalueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tulostusalueDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tulostusalueDGV.Location = new System.Drawing.Point(0, 232);
            this.tulostusalueDGV.Name = "tulostusalueDGV";
            this.tulostusalueDGV.RowHeadersWidth = 82;
            this.tulostusalueDGV.RowTemplate.Height = 33;
            this.tulostusalueDGV.Size = new System.Drawing.Size(1260, 390);
            this.tulostusalueDGV.TabIndex = 0;
            this.tulostusalueDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tulostusalueDGV_CellContentClick);
            // 
            // haeBT
            // 
            this.haeBT.Location = new System.Drawing.Point(180, 72);
            this.haeBT.Name = "haeBT";
            this.haeBT.Size = new System.Drawing.Size(921, 103);
            this.haeBT.TabIndex = 1;
            this.haeBT.Text = "Hae kaikki";
            this.haeBT.UseVisualStyleBackColor = true;
            this.haeBT.Click += new System.EventHandler(this.haeBT_Click);
            // 
            // Apilomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 622);
            this.Controls.Add(this.haeBT);
            this.Controls.Add(this.tulostusalueDGV);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Apilomake";
            this.Text = "Apilomake";
            this.Load += new System.EventHandler(this.Apilomake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tulostusalueDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tulostusalueDGV;
        private System.Windows.Forms.Button haeBT;
    }
}

