namespace manav
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.txtMeyve = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSeçilenisil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(64, 74);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(220, 31);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(120, 134);
            this.lstListe.TabIndex = 1;
            // 
            // txtMeyve
            // 
            this.txtMeyve.Location = new System.Drawing.Point(64, 31);
            this.txtMeyve.Name = "txtMeyve";
            this.txtMeyve.Size = new System.Drawing.Size(135, 20);
            this.txtMeyve.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(64, 132);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sepeten Kaldır";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSeçilenisil
            // 
            this.btnSeçilenisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeçilenisil.Location = new System.Drawing.Point(64, 103);
            this.btnSeçilenisil.Name = "btnSeçilenisil";
            this.btnSeçilenisil.Size = new System.Drawing.Size(135, 23);
            this.btnSeçilenisil.TabIndex = 4;
            this.btnSeçilenisil.Text = "Seçileni Sil";
            this.btnSeçilenisil.UseVisualStyleBackColor = true;
            this.btnSeçilenisil.Click += new System.EventHandler(this.btnSeçilenisil_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(370, 193);
            this.Controls.Add(this.btnSeçilenisil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtMeyve);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Manav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.TextBox txtMeyve;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSeçilenisil;
    }
}

