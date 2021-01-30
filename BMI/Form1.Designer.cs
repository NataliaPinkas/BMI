namespace BMI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Waga = new System.Windows.Forms.TextBox();
            this.Wzrost = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.Kilogramy = new System.Windows.Forms.RadioButton();
            this.Funty = new System.Windows.Forms.RadioButton();
            this.Oblicz = new System.Windows.Forms.Button();
            this.Wyczysc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Wyjdz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Waga
            // 
            this.Waga.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Waga.Location = new System.Drawing.Point(131, 120);
            this.Waga.Name = "Waga";
            this.Waga.Size = new System.Drawing.Size(110, 28);
            this.Waga.TabIndex = 3;
            // 
            // Wzrost
            // 
            this.Wzrost.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.Wzrost.Location = new System.Drawing.Point(131, 162);
            this.Wzrost.Name = "Wzrost";
            this.Wzrost.Size = new System.Drawing.Size(110, 28);
            this.Wzrost.TabIndex = 4;
            // 
            // Wynik
            // 
            this.Wynik.BackColor = System.Drawing.Color.White;
            this.Wynik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Wynik.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.Wynik.ForeColor = System.Drawing.Color.Black;
            this.Wynik.Location = new System.Drawing.Point(39, 430);
            this.Wynik.Multiline = true;
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(433, 95);
            this.Wynik.TabIndex = 5;
            // 
            // Kilogramy
            // 
            this.Kilogramy.AutoSize = true;
            this.Kilogramy.BackColor = System.Drawing.Color.White;
            this.Kilogramy.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.Kilogramy.Location = new System.Drawing.Point(268, 127);
            this.Kilogramy.Name = "Kilogramy";
            this.Kilogramy.Size = new System.Drawing.Size(14, 13);
            this.Kilogramy.TabIndex = 6;
            this.Kilogramy.TabStop = true;
            this.Kilogramy.UseVisualStyleBackColor = false;
            this.Kilogramy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Funty
            // 
            this.Funty.AutoSize = true;
            this.Funty.BackColor = System.Drawing.Color.White;
            this.Funty.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.Funty.Location = new System.Drawing.Point(379, 127);
            this.Funty.Name = "Funty";
            this.Funty.Size = new System.Drawing.Size(14, 13);
            this.Funty.TabIndex = 7;
            this.Funty.TabStop = true;
            this.Funty.UseVisualStyleBackColor = false;
            // 
            // Oblicz
            // 
            this.Oblicz.BackColor = System.Drawing.Color.White;
            this.Oblicz.FlatAppearance.BorderSize = 0;
            this.Oblicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Oblicz.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.Oblicz.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Oblicz.Location = new System.Drawing.Point(39, 547);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(134, 30);
            this.Oblicz.TabIndex = 8;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = false;
            this.Oblicz.Click += new System.EventHandler(this.Oblicz_Click);
            // 
            // Wyczysc
            // 
            this.Wyczysc.BackColor = System.Drawing.Color.White;
            this.Wyczysc.FlatAppearance.BorderSize = 0;
            this.Wyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wyczysc.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.Wyczysc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Wyczysc.Location = new System.Drawing.Point(189, 547);
            this.Wyczysc.Name = "Wyczysc";
            this.Wyczysc.Size = new System.Drawing.Size(134, 30);
            this.Wyczysc.TabIndex = 9;
            this.Wyczysc.Text = "Wyczyść";
            this.Wyczysc.UseVisualStyleBackColor = false;
            this.Wyczysc.Click += new System.EventHandler(this.Wyczysc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(267, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(267, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 13;
            // 
            // Wyjdz
            // 
            this.Wyjdz.BackColor = System.Drawing.Color.White;
            this.Wyjdz.FlatAppearance.BorderSize = 0;
            this.Wyjdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wyjdz.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.Wyjdz.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Wyjdz.Location = new System.Drawing.Point(338, 547);
            this.Wyjdz.Name = "Wyjdz";
            this.Wyjdz.Size = new System.Drawing.Size(134, 30);
            this.Wyjdz.TabIndex = 14;
            this.Wyjdz.Text = "Wyjdź";
            this.Wyjdz.UseVisualStyleBackColor = false;
            this.Wyjdz.Click += new System.EventHandler(this.Wyjdz_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "opisy źródło: http://oblicz-bmi.pl/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Natalia Pinkas, Przemysław Lambarski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wyjdz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wyczysc);
            this.Controls.Add(this.Oblicz);
            this.Controls.Add(this.Funty);
            this.Controls.Add(this.Kilogramy);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Wzrost);
            this.Controls.Add(this.Waga);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Waga;
        private System.Windows.Forms.TextBox Wzrost;
        private System.Windows.Forms.TextBox Wynik;
        private System.Windows.Forms.RadioButton Kilogramy;
        private System.Windows.Forms.RadioButton Funty;
        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.Button Wyczysc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Wyjdz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

