namespace WindowsFormsApplication3
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
            this.labelMessst = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownMessstellenAnzahl = new System.Windows.Forms.NumericUpDown();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.numericUpDownNummerMessstellen = new System.Windows.Forms.NumericUpDown();
            this.labelMessstelleName = new System.Windows.Forms.Label();
            this.groupBoxMesspunkt = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.textBoxMenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNrMessstelle = new System.Windows.Forms.Label();
            this.listBoxMessstatioen = new System.Windows.Forms.ListBox();
            this.listBoxHauptstadt = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStatistik = new System.Windows.Forms.TextBox();
            this.pictureBoxDiagramm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessstellenAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNummerMessstellen)).BeginInit();
            this.groupBoxMesspunkt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagramm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMessst
            // 
            this.labelMessst.AutoSize = true;
            this.labelMessst.Location = new System.Drawing.Point(21, 21);
            this.labelMessst.Name = "labelMessst";
            this.labelMessst.Size = new System.Drawing.Size(97, 13);
            this.labelMessst.TabIndex = 0;
            this.labelMessst.Text = "Anzahl Messstellen";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(261, 15);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 24);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start/Restart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownMessstellenAnzahl
            // 
            this.numericUpDownMessstellenAnzahl.Location = new System.Drawing.Point(124, 19);
            this.numericUpDownMessstellenAnzahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMessstellenAnzahl.Name = "numericUpDownMessstellenAnzahl";
            this.numericUpDownMessstellenAnzahl.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMessstellenAnzahl.TabIndex = 2;
            this.numericUpDownMessstellenAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMessstellenAnzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(397, 13);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(123, 26);
            this.buttonEnd.TabIndex = 3;
            this.buttonEnd.Text = "Ende";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // numericUpDownNummerMessstellen
            // 
            this.numericUpDownNummerMessstellen.Location = new System.Drawing.Point(607, 18);
            this.numericUpDownNummerMessstellen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNummerMessstellen.Name = "numericUpDownNummerMessstellen";
            this.numericUpDownNummerMessstellen.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownNummerMessstellen.TabIndex = 4;
            this.numericUpDownNummerMessstellen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownNummerMessstellen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNummerMessstellen.ValueChanged += new System.EventHandler(this.numericUpDownNummerMessstellen_ValueChanged);
            // 
            // labelMessstelleName
            // 
            this.labelMessstelleName.AutoSize = true;
            this.labelMessstelleName.Location = new System.Drawing.Point(695, 21);
            this.labelMessstelleName.Name = "labelMessstelleName";
            this.labelMessstelleName.Size = new System.Drawing.Size(94, 13);
            this.labelMessstelleName.TabIndex = 5;
            this.labelMessstelleName.Text = "Messstation Name";
            // 
            // groupBoxMesspunkt
            // 
            this.groupBoxMesspunkt.Controls.Add(this.label3);
            this.groupBoxMesspunkt.Controls.Add(this.buttonHinzufügen);
            this.groupBoxMesspunkt.Controls.Add(this.textBoxMenge);
            this.groupBoxMesspunkt.Controls.Add(this.label2);
            this.groupBoxMesspunkt.Controls.Add(this.checkBox1);
            this.groupBoxMesspunkt.Controls.Add(this.textBoxOrt);
            this.groupBoxMesspunkt.Controls.Add(this.label1);
            this.groupBoxMesspunkt.Location = new System.Drawing.Point(24, 89);
            this.groupBoxMesspunkt.Name = "groupBoxMesspunkt";
            this.groupBoxMesspunkt.Size = new System.Drawing.Size(518, 160);
            this.groupBoxMesspunkt.TabIndex = 6;
            this.groupBoxMesspunkt.TabStop = false;
            this.groupBoxMesspunkt.Text = "1.Messpunkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "l/m²";
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(298, 30);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(171, 87);
            this.buttonHinzufügen.TabIndex = 5;
            this.buttonHinzufügen.Text = "Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // textBoxMenge
            // 
            this.textBoxMenge.Location = new System.Drawing.Point(45, 101);
            this.textBoxMenge.Name = "textBoxMenge";
            this.textBoxMenge.Size = new System.Drawing.Size(100, 20);
            this.textBoxMenge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menge";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(45, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Hauptstatt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(45, 30);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ort";
            // 
            // labelNrMessstelle
            // 
            this.labelNrMessstelle.AutoSize = true;
            this.labelNrMessstelle.Location = new System.Drawing.Point(528, 20);
            this.labelNrMessstelle.Name = "labelNrMessstelle";
            this.labelNrMessstelle.Size = new System.Drawing.Size(73, 13);
            this.labelNrMessstelle.TabIndex = 7;
            this.labelNrMessstelle.Text = "Nr. Messstelle";
            // 
            // listBoxMessstatioen
            // 
            this.listBoxMessstatioen.FormattingEnabled = true;
            this.listBoxMessstatioen.Location = new System.Drawing.Point(24, 288);
            this.listBoxMessstatioen.Name = "listBoxMessstatioen";
            this.listBoxMessstatioen.Size = new System.Drawing.Size(166, 134);
            this.listBoxMessstatioen.TabIndex = 7;
            this.listBoxMessstatioen.SelectedIndexChanged += new System.EventHandler(this.listBoxMessstatioen_SelectedIndexChanged);
            // 
            // listBoxHauptstadt
            // 
            this.listBoxHauptstadt.FormattingEnabled = true;
            this.listBoxHauptstadt.Location = new System.Drawing.Point(261, 288);
            this.listBoxHauptstadt.Name = "listBoxHauptstadt";
            this.listBoxHauptstadt.Size = new System.Drawing.Size(281, 134);
            this.listBoxHauptstadt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alle Messstationen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Messstationen in Hauptstädten";
            // 
            // textBoxStatistik
            // 
            this.textBoxStatistik.Location = new System.Drawing.Point(24, 442);
            this.textBoxStatistik.Multiline = true;
            this.textBoxStatistik.Name = "textBoxStatistik";
            this.textBoxStatistik.Size = new System.Drawing.Size(518, 106);
            this.textBoxStatistik.TabIndex = 11;
            // 
            // pictureBoxDiagramm
            // 
            this.pictureBoxDiagramm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxDiagramm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDiagramm.Location = new System.Drawing.Point(548, 89);
            this.pictureBoxDiagramm.Name = "pictureBoxDiagramm";
            this.pictureBoxDiagramm.Size = new System.Drawing.Size(372, 459);
            this.pictureBoxDiagramm.TabIndex = 7;
            this.pictureBoxDiagramm.TabStop = false;
            this.pictureBoxDiagramm.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDiagramm_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 594);
            this.Controls.Add(this.pictureBoxDiagramm);
            this.Controls.Add(this.textBoxStatistik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxHauptstadt);
            this.Controls.Add(this.listBoxMessstatioen);
            this.Controls.Add(this.labelNrMessstelle);
            this.Controls.Add(this.groupBoxMesspunkt);
            this.Controls.Add(this.labelMessstelleName);
            this.Controls.Add(this.numericUpDownNummerMessstellen);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.numericUpDownMessstellenAnzahl);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMessst);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessstellenAnzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNummerMessstellen)).EndInit();
            this.groupBoxMesspunkt.ResumeLayout(false);
            this.groupBoxMesspunkt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagramm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessst;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownMessstellenAnzahl;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownNummerMessstellen;
        private System.Windows.Forms.Label labelMessstelleName;
        private System.Windows.Forms.GroupBox groupBoxMesspunkt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.TextBox textBoxMenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.Label labelNrMessstelle;
        private System.Windows.Forms.ListBox listBoxMessstatioen;
        private System.Windows.Forms.ListBox listBoxHauptstadt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStatistik;
        private System.Windows.Forms.PictureBox pictureBoxDiagramm;
    }
}

