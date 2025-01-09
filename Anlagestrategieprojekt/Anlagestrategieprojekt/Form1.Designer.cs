namespace Anlagestrategieprojekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_anfangskapital = new TextBox();
            tb_vermoegensziel = new TextBox();
            l_ausgabe = new Label();
            btn_berechnen = new Button();
            dtp_zieldatum = new DateTimePicker();
            gb_1 = new GroupBox();
            l_gb_1 = new Label();
            l_k_1 = new Label();
            l_v_1 = new Label();
            l_jR_1 = new Label();
            l_dV_1 = new Label();
            l_kW_1 = new Label();
            l_vK_1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            l_gb_2 = new Label();
            l_k_2 = new Label();
            l_v_2 = new Label();
            l_jR_2 = new Label();
            l_dV_2 = new Label();
            l_kW_2 = new Label();
            l_vK_2 = new Label();
            pictureBox2 = new PictureBox();
            tb_ObligationsZins = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            l_gb_3 = new Label();
            l_k_3 = new Label();
            l_v_3 = new Label();
            l_jR_3 = new Label();
            l_dV_3 = new Label();
            l_kW_3 = new Label();
            l_vK_3 = new Label();
            pictureBox3 = new PictureBox();
            l_sS_1 = new Label();
            l_sS_2 = new Label();
            l_sS_3 = new Label();
            gb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tb_anfangskapital
            // 
            tb_anfangskapital.Location = new Point(27, 54);
            tb_anfangskapital.Name = "tb_anfangskapital";
            tb_anfangskapital.Size = new Size(100, 23);
            tb_anfangskapital.TabIndex = 0;
            // 
            // tb_vermoegensziel
            // 
            tb_vermoegensziel.Location = new Point(191, 54);
            tb_vermoegensziel.Name = "tb_vermoegensziel";
            tb_vermoegensziel.Size = new Size(100, 23);
            tb_vermoegensziel.TabIndex = 1;
            // 
            // l_ausgabe
            // 
            l_ausgabe.AutoSize = true;
            l_ausgabe.Font = new Font("Segoe UI", 12F);
            l_ausgabe.ForeColor = Color.Red;
            l_ausgabe.Location = new Point(28, 220);
            l_ausgabe.Name = "l_ausgabe";
            l_ausgabe.Size = new Size(0, 21);
            l_ausgabe.TabIndex = 3;
            // 
            // btn_berechnen
            // 
            btn_berechnen.Location = new Point(27, 194);
            btn_berechnen.Name = "btn_berechnen";
            btn_berechnen.Size = new Size(75, 23);
            btn_berechnen.TabIndex = 4;
            btn_berechnen.Text = "Berechnen";
            btn_berechnen.UseVisualStyleBackColor = true;
            btn_berechnen.Click += b_berechnen_Click;
            // 
            // dtp_zieldatum
            // 
            dtp_zieldatum.Location = new Point(357, 54);
            dtp_zieldatum.Name = "dtp_zieldatum";
            dtp_zieldatum.Size = new Size(200, 23);
            dtp_zieldatum.TabIndex = 5;
            // 
            // gb_1
            // 
            gb_1.Controls.Add(l_gb_1);
            gb_1.Controls.Add(l_k_1);
            gb_1.Controls.Add(l_v_1);
            gb_1.Controls.Add(l_jR_1);
            gb_1.Controls.Add(l_dV_1);
            gb_1.Controls.Add(l_kW_1);
            gb_1.Controls.Add(l_vK_1);
            gb_1.Controls.Add(pictureBox1);
            gb_1.Font = new Font("Segoe UI", 15F);
            gb_1.Location = new Point(28, 301);
            gb_1.Name = "gb_1";
            gb_1.Size = new Size(520, 346);
            gb_1.TabIndex = 6;
            gb_1.TabStop = false;
            gb_1.Text = "Strategie: Hohes Risiko";
            // 
            // l_gb_1
            // 
            l_gb_1.AutoSize = true;
            l_gb_1.Font = new Font("Segoe UI", 15F);
            l_gb_1.Location = new Point(15, 284);
            l_gb_1.Name = "l_gb_1";
            l_gb_1.Size = new Size(172, 28);
            l_gb_1.TabIndex = 7;
            l_gb_1.Text = "Gesamtbewertung";
            // 
            // l_k_1
            // 
            l_k_1.AutoSize = true;
            l_k_1.Font = new Font("Segoe UI", 15F);
            l_k_1.Location = new Point(16, 243);
            l_k_1.Name = "l_k_1";
            l_k_1.Size = new Size(221, 28);
            l_k_1.TabIndex = 6;
            l_k_1.Text = "Korrelation der Anlagen";
            // 
            // l_v_1
            // 
            l_v_1.AutoSize = true;
            l_v_1.Font = new Font("Segoe UI", 15F);
            l_v_1.Location = new Point(16, 203);
            l_v_1.Name = "l_v_1";
            l_v_1.Size = new Size(75, 28);
            l_v_1.TabIndex = 5;
            l_v_1.Text = "Varianz";
            // 
            // l_jR_1
            // 
            l_jR_1.AutoSize = true;
            l_jR_1.Font = new Font("Segoe UI", 15F);
            l_jR_1.Location = new Point(16, 161);
            l_jR_1.Name = "l_jR_1";
            l_jR_1.Size = new Size(247, 28);
            l_jR_1.TabIndex = 4;
            l_jR_1.Text = "Erwartete jährliche Rendite:";
            // 
            // l_dV_1
            // 
            l_dV_1.AutoSize = true;
            l_dV_1.Font = new Font("Segoe UI", 15F);
            l_dV_1.Location = new Point(16, 120);
            l_dV_1.Name = "l_dV_1";
            l_dV_1.Size = new Size(367, 28);
            l_dV_1.TabIndex = 3;
            l_dV_1.Text = "Datum bei Erreichen des Vermögensziels:";
            // 
            // l_kW_1
            // 
            l_kW_1.AutoSize = true;
            l_kW_1.Font = new Font("Segoe UI", 15F);
            l_kW_1.Location = new Point(16, 79);
            l_kW_1.Name = "l_kW_1";
            l_kW_1.Size = new Size(335, 28);
            l_kW_1.TabIndex = 2;
            l_kW_1.Text = "Erwartetes Kapital bei Wunschdatum:";
            // 
            // l_vK_1
            // 
            l_vK_1.AutoSize = true;
            l_vK_1.Font = new Font("Segoe UI", 15F);
            l_vK_1.Location = new Point(16, 35);
            l_vK_1.Name = "l_vK_1";
            l_vK_1.Size = new Size(171, 28);
            l_vK_1.TabIndex = 1;
            l_vK_1.Text = "Verteilung Kapital:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 313);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(l_gb_2);
            groupBox1.Controls.Add(l_k_2);
            groupBox1.Controls.Add(l_v_2);
            groupBox1.Controls.Add(l_jR_2);
            groupBox1.Controls.Add(l_dV_2);
            groupBox1.Controls.Add(l_kW_2);
            groupBox1.Controls.Add(l_vK_2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(582, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 343);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Strategie: Moderates Risiko";
            // 
            // l_gb_2
            // 
            l_gb_2.AutoSize = true;
            l_gb_2.Font = new Font("Segoe UI", 15F);
            l_gb_2.Location = new Point(15, 281);
            l_gb_2.Name = "l_gb_2";
            l_gb_2.Size = new Size(172, 28);
            l_gb_2.TabIndex = 8;
            l_gb_2.Text = "Gesamtbewertung";
            // 
            // l_k_2
            // 
            l_k_2.AutoSize = true;
            l_k_2.Font = new Font("Segoe UI", 15F);
            l_k_2.Location = new Point(16, 243);
            l_k_2.Name = "l_k_2";
            l_k_2.Size = new Size(221, 28);
            l_k_2.TabIndex = 6;
            l_k_2.Text = "Korrelation der Anlagen";
            // 
            // l_v_2
            // 
            l_v_2.AutoSize = true;
            l_v_2.Font = new Font("Segoe UI", 15F);
            l_v_2.Location = new Point(16, 203);
            l_v_2.Name = "l_v_2";
            l_v_2.Size = new Size(75, 28);
            l_v_2.TabIndex = 5;
            l_v_2.Text = "Varianz";
            // 
            // l_jR_2
            // 
            l_jR_2.AutoSize = true;
            l_jR_2.Font = new Font("Segoe UI", 15F);
            l_jR_2.Location = new Point(16, 161);
            l_jR_2.Name = "l_jR_2";
            l_jR_2.Size = new Size(247, 28);
            l_jR_2.TabIndex = 4;
            l_jR_2.Text = "Erwartete jährliche Rendite:";
            // 
            // l_dV_2
            // 
            l_dV_2.AutoSize = true;
            l_dV_2.Font = new Font("Segoe UI", 15F);
            l_dV_2.Location = new Point(16, 120);
            l_dV_2.Name = "l_dV_2";
            l_dV_2.Size = new Size(367, 28);
            l_dV_2.TabIndex = 3;
            l_dV_2.Text = "Datum bei Erreichen des Vermögensziels:";
            // 
            // l_kW_2
            // 
            l_kW_2.AutoSize = true;
            l_kW_2.Font = new Font("Segoe UI", 15F);
            l_kW_2.Location = new Point(16, 79);
            l_kW_2.Name = "l_kW_2";
            l_kW_2.Size = new Size(335, 28);
            l_kW_2.TabIndex = 2;
            l_kW_2.Text = "Erwartetes Kapital bei Wunschdatum:";
            // 
            // l_vK_2
            // 
            l_vK_2.AutoSize = true;
            l_vK_2.Font = new Font("Segoe UI", 15F);
            l_vK_2.Location = new Point(16, 35);
            l_vK_2.Name = "l_vK_2";
            l_vK_2.Size = new Size(171, 28);
            l_vK_2.TabIndex = 1;
            l_vK_2.Text = "Verteilung Kapital:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Wheat;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(510, 310);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tb_ObligationsZins
            // 
            tb_ObligationsZins.Location = new Point(27, 131);
            tb_ObligationsZins.Name = "tb_ObligationsZins";
            tb_ObligationsZins.Size = new Size(100, 23);
            tb_ObligationsZins.TabIndex = 8;
            tb_ObligationsZins.Text = "1.25";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 9;
            label1.Text = "Anfangskapital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 28);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 10;
            label2.Text = "Vermögensziel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 28);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Zeitpunkt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 113);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 12;
            label4.Text = "Obligationszins";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(l_gb_3);
            groupBox2.Controls.Add(l_k_3);
            groupBox2.Controls.Add(l_v_3);
            groupBox2.Controls.Add(l_jR_3);
            groupBox2.Controls.Add(l_dV_3);
            groupBox2.Controls.Add(l_kW_3);
            groupBox2.Controls.Add(l_vK_3);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(1133, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 340);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Strategie: Niedriges Risiko";
            // 
            // l_gb_3
            // 
            l_gb_3.AutoSize = true;
            l_gb_3.Font = new Font("Segoe UI", 15F);
            l_gb_3.Location = new Point(16, 281);
            l_gb_3.Name = "l_gb_3";
            l_gb_3.Size = new Size(172, 28);
            l_gb_3.TabIndex = 9;
            l_gb_3.Text = "Gesamtbewertung";
            // 
            // l_k_3
            // 
            l_k_3.AutoSize = true;
            l_k_3.Font = new Font("Segoe UI", 15F);
            l_k_3.Location = new Point(16, 243);
            l_k_3.Name = "l_k_3";
            l_k_3.Size = new Size(221, 28);
            l_k_3.TabIndex = 6;
            l_k_3.Text = "Korrelation der Anlagen";
            // 
            // l_v_3
            // 
            l_v_3.AutoSize = true;
            l_v_3.Font = new Font("Segoe UI", 15F);
            l_v_3.Location = new Point(16, 203);
            l_v_3.Name = "l_v_3";
            l_v_3.Size = new Size(75, 28);
            l_v_3.TabIndex = 5;
            l_v_3.Text = "Varianz";
            // 
            // l_jR_3
            // 
            l_jR_3.AutoSize = true;
            l_jR_3.Font = new Font("Segoe UI", 15F);
            l_jR_3.Location = new Point(16, 161);
            l_jR_3.Name = "l_jR_3";
            l_jR_3.Size = new Size(247, 28);
            l_jR_3.TabIndex = 4;
            l_jR_3.Text = "Erwartete jährliche Rendite:";
            // 
            // l_dV_3
            // 
            l_dV_3.AutoSize = true;
            l_dV_3.Font = new Font("Segoe UI", 15F);
            l_dV_3.Location = new Point(16, 120);
            l_dV_3.Name = "l_dV_3";
            l_dV_3.Size = new Size(367, 28);
            l_dV_3.TabIndex = 3;
            l_dV_3.Text = "Datum bei Erreichen des Vermögensziels:";
            // 
            // l_kW_3
            // 
            l_kW_3.AutoSize = true;
            l_kW_3.Font = new Font("Segoe UI", 15F);
            l_kW_3.Location = new Point(16, 79);
            l_kW_3.Name = "l_kW_3";
            l_kW_3.Size = new Size(335, 28);
            l_kW_3.TabIndex = 2;
            l_kW_3.Text = "Erwartetes Kapital bei Wunschdatum:";
            // 
            // l_vK_3
            // 
            l_vK_3.AutoSize = true;
            l_vK_3.Font = new Font("Segoe UI", 15F);
            l_vK_3.Location = new Point(16, 35);
            l_vK_3.Name = "l_vK_3";
            l_vK_3.Size = new Size(171, 28);
            l_vK_3.TabIndex = 1;
            l_vK_3.Text = "Verteilung Kapital:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkSeaGreen;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(3, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(510, 307);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // l_sS_1
            // 
            l_sS_1.AutoSize = true;
            l_sS_1.Font = new Font("Segoe UI", 20F);
            l_sS_1.ForeColor = SystemColors.Highlight;
            l_sS_1.Location = new Point(145, 248);
            l_sS_1.Name = "l_sS_1";
            l_sS_1.Size = new Size(234, 37);
            l_sS_1.TabIndex = 14;
            l_sS_1.Text = "Sicherste Strategie";
            // 
            // l_sS_2
            // 
            l_sS_2.AutoSize = true;
            l_sS_2.Font = new Font("Segoe UI", 20F);
            l_sS_2.ForeColor = SystemColors.Highlight;
            l_sS_2.Location = new Point(699, 248);
            l_sS_2.Name = "l_sS_2";
            l_sS_2.Size = new Size(234, 37);
            l_sS_2.TabIndex = 15;
            l_sS_2.Text = "Sicherste Strategie";
            // 
            // l_sS_3
            // 
            l_sS_3.AutoSize = true;
            l_sS_3.Font = new Font("Segoe UI", 20F);
            l_sS_3.ForeColor = SystemColors.Highlight;
            l_sS_3.Location = new Point(1282, 248);
            l_sS_3.Name = "l_sS_3";
            l_sS_3.Size = new Size(234, 37);
            l_sS_3.TabIndex = 16;
            l_sS_3.Text = "Sicherste Strategie";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1772, 761);
            Controls.Add(l_sS_3);
            Controls.Add(l_sS_2);
            Controls.Add(l_sS_1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_ObligationsZins);
            Controls.Add(groupBox1);
            Controls.Add(gb_1);
            Controls.Add(dtp_zieldatum);
            Controls.Add(btn_berechnen);
            Controls.Add(l_ausgabe);
            Controls.Add(tb_vermoegensziel);
            Controls.Add(tb_anfangskapital);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            gb_1.ResumeLayout(false);
            gb_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_anfangskapital;
        private TextBox tb_vermoegensziel;
        private Label l_ausgabe;
        private Button btn_berechnen;
        private DateTimePicker dtp_zieldatum;
        private GroupBox gb_1;
        private PictureBox pictureBox1;
        private Label l_k_1;
        private Label l_v_1;
        private Label l_jR_1;
        private Label l_dV_1;
        private Label l_kW_1;
        private Label l_vK_1;
        private GroupBox groupBox1;
        private Label l_k_2;
        private Label l_v_2;
        private Label l_jR_2;
        private Label l_dV_2;
        private Label l_kW_2;
        private Label l_vK_2;
        private PictureBox pictureBox2;
        private TextBox tb_ObligationsZins;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Label l_k_3;
        private Label l_v_3;
        private Label l_jR_3;
        private Label l_dV_3;
        private Label l_kW_3;
        private Label l_vK_3;
        private PictureBox pictureBox3;
        private Label l_gb_1;
        private Label l_gb_2;
        private Label l_gb_3;
        private Label l_sS_1;
        private Label l_sS_2;
        private Label l_sS_3;
    }
}
