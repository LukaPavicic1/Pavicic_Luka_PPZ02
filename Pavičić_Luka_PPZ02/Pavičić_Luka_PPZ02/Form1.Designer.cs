namespace Pavičić_Luka_PPZ02
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
            this.rbtnGazirana = new System.Windows.Forms.RadioButton();
            this.rbtNegazirana = new System.Windows.Forms.RadioButton();
            this.rbtAlkoholna = new System.Windows.Forms.RadioButton();
            this.gpbVrsta = new System.Windows.Forms.GroupBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.cmbPakiranje = new System.Windows.Forms.ComboBox();
            this.lblPakiranje = new System.Windows.Forms.Label();
            this.lblAlc = new System.Windows.Forms.Label();
            this.trckAlc = new System.Windows.Forms.TrackBar();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.gpbVrsta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckAlc)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnGazirana
            // 
            this.rbtnGazirana.AutoSize = true;
            this.rbtnGazirana.Location = new System.Drawing.Point(19, 19);
            this.rbtnGazirana.Name = "rbtnGazirana";
            this.rbtnGazirana.Size = new System.Drawing.Size(67, 17);
            this.rbtnGazirana.TabIndex = 0;
            this.rbtnGazirana.TabStop = true;
            this.rbtnGazirana.Text = "Gazirano";
            this.rbtnGazirana.UseVisualStyleBackColor = true;
            // 
            // rbtNegazirana
            // 
            this.rbtNegazirana.AutoSize = true;
            this.rbtNegazirana.Location = new System.Drawing.Point(19, 42);
            this.rbtNegazirana.Name = "rbtNegazirana";
            this.rbtNegazirana.Size = new System.Drawing.Size(79, 17);
            this.rbtNegazirana.TabIndex = 1;
            this.rbtNegazirana.TabStop = true;
            this.rbtNegazirana.Text = "Negazirano";
            this.rbtNegazirana.UseVisualStyleBackColor = true;
            // 
            // rbtAlkoholna
            // 
            this.rbtAlkoholna.AutoSize = true;
            this.rbtAlkoholna.Location = new System.Drawing.Point(19, 65);
            this.rbtAlkoholna.Name = "rbtAlkoholna";
            this.rbtAlkoholna.Size = new System.Drawing.Size(72, 17);
            this.rbtAlkoholna.TabIndex = 2;
            this.rbtAlkoholna.TabStop = true;
            this.rbtAlkoholna.Text = "Alkoholno";
            this.rbtAlkoholna.UseVisualStyleBackColor = true;
            // 
            // gpbVrsta
            // 
            this.gpbVrsta.Controls.Add(this.rbtnGazirana);
            this.gpbVrsta.Controls.Add(this.rbtAlkoholna);
            this.gpbVrsta.Controls.Add(this.rbtNegazirana);
            this.gpbVrsta.Location = new System.Drawing.Point(12, 22);
            this.gpbVrsta.Name = "gpbVrsta";
            this.gpbVrsta.Size = new System.Drawing.Size(200, 100);
            this.gpbVrsta.TabIndex = 3;
            this.gpbVrsta.TabStop = false;
            this.gpbVrsta.Text = "Vrsta pića";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(15, 165);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(155, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 139);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(60, 13);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "Naziv pića:";
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Items.AddRange(new object[] {
            "0.5 L",
            "1 L",
            "1.5 L",
            "2 L"});
            this.cmbKolicina.Location = new System.Drawing.Point(12, 225);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(158, 21);
            this.cmbKolicina.TabIndex = 6;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 199);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 7;
            this.lblKolicina.Text = "Količina:";
            // 
            // cmbPakiranje
            // 
            this.cmbPakiranje.FormattingEnabled = true;
            this.cmbPakiranje.Items.AddRange(new object[] {
            "Staklo",
            "PET",
            "Tetrapak"});
            this.cmbPakiranje.Location = new System.Drawing.Point(12, 283);
            this.cmbPakiranje.Name = "cmbPakiranje";
            this.cmbPakiranje.Size = new System.Drawing.Size(158, 21);
            this.cmbPakiranje.TabIndex = 8;
            // 
            // lblPakiranje
            // 
            this.lblPakiranje.AutoSize = true;
            this.lblPakiranje.Location = new System.Drawing.Point(15, 260);
            this.lblPakiranje.Name = "lblPakiranje";
            this.lblPakiranje.Size = new System.Drawing.Size(54, 13);
            this.lblPakiranje.TabIndex = 9;
            this.lblPakiranje.Text = "Pakiranje:";
            // 
            // lblAlc
            // 
            this.lblAlc.AutoSize = true;
            this.lblAlc.Location = new System.Drawing.Point(422, 396);
            this.lblAlc.Name = "lblAlc";
            this.lblAlc.Size = new System.Drawing.Size(30, 13);
            this.lblAlc.TabIndex = 10;
            this.lblAlc.Text = "Alc%";
            // 
            // trckAlc
            // 
            this.trckAlc.Location = new System.Drawing.Point(266, 422);
            this.trckAlc.Maximum = 50;
            this.trckAlc.Minimum = 1;
            this.trckAlc.Name = "trckAlc";
            this.trckAlc.Size = new System.Drawing.Size(346, 45);
            this.trckAlc.SmallChange = 5;
            this.trckAlc.TabIndex = 11;
            this.trckAlc.Value = 1;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(12, 317);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 12;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(12, 342);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(158, 20);
            this.txtCijena.TabIndex = 13;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(232, 22);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(430, 352);
            this.rtbIspis.TabIndex = 14;
            this.rtbIspis.Text = "";
            // 
            // btnUpis
            // 
            this.btnUpis.Location = new System.Drawing.Point(694, 41);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(184, 111);
            this.btnUpis.TabIndex = 15;
            this.btnUpis.Text = "Upis";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(694, 188);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(184, 116);
            this.btnIspis.TabIndex = 16;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 479);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUpis);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.trckAlc);
            this.Controls.Add(this.lblAlc);
            this.Controls.Add(this.lblPakiranje);
            this.Controls.Add(this.cmbPakiranje);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.gpbVrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbVrsta.ResumeLayout(false);
            this.gpbVrsta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckAlc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnGazirana;
        private System.Windows.Forms.RadioButton rbtNegazirana;
        private System.Windows.Forms.RadioButton rbtAlkoholna;
        private System.Windows.Forms.GroupBox gpbVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ComboBox cmbPakiranje;
        private System.Windows.Forms.Label lblPakiranje;
        private System.Windows.Forms.Label lblAlc;
        private System.Windows.Forms.TrackBar trckAlc;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Button btnIspis;
    }
}

