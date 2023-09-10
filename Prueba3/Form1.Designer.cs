namespace Prueba3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBidi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncalctri = new System.Windows.Forms.Button();
            this.lblareatri = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtradioTri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotridi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(6, 137);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculadora de Areas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblarea);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtradio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtaltura);
            this.groupBox1.Controls.Add(this.txtbase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboBidi);
            this.groupBox1.Controls.Add(this.btncalc);
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figuras Bidimensionales";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(317, 137);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(28, 13);
            this.lblarea.TabIndex = 14;
            this.lblarea.Text = "00.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "El area es:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Radio:";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(206, 111);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(27, 20);
            this.txtradio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altura:";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(206, 74);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(27, 20);
            this.txtaltura.TabIndex = 9;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(206, 35);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(27, 20);
            this.txtbase.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Base:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione:";
            // 
            // cboBidi
            // 
            this.cboBidi.FormattingEnabled = true;
            this.cboBidi.Items.AddRange(new object[] {
            "Círculo",
            "Cuadrado",
            "Triángulo"});
            this.cboBidi.Location = new System.Drawing.Point(6, 42);
            this.cboBidi.Name = "cboBidi";
            this.cboBidi.Size = new System.Drawing.Size(121, 21);
            this.cboBidi.TabIndex = 4;
            this.cboBidi.Text = "Seleccione";
            this.cboBidi.SelectedIndexChanged += new System.EventHandler(this.cboBidi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncalctri);
            this.groupBox2.Controls.Add(this.lblareatri);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtlado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtradioTri);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbotridi);
            this.groupBox2.Location = new System.Drawing.Point(24, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 150);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figuras Tridimensionales";
            // 
            // btncalctri
            // 
            this.btncalctri.Location = new System.Drawing.Point(9, 121);
            this.btncalctri.Name = "btncalctri";
            this.btncalctri.Size = new System.Drawing.Size(75, 23);
            this.btncalctri.TabIndex = 15;
            this.btncalctri.Text = "Calcular";
            this.btncalctri.UseVisualStyleBackColor = true;
            this.btncalctri.Click += new System.EventHandler(this.btncalctri_Click);
            // 
            // lblareatri
            // 
            this.lblareatri.AutoSize = true;
            this.lblareatri.Location = new System.Drawing.Point(317, 121);
            this.lblareatri.Name = "lblareatri";
            this.lblareatri.Size = new System.Drawing.Size(28, 13);
            this.lblareatri.TabIndex = 16;
            this.lblareatri.Text = "00.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "El area es:";
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(210, 92);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(27, 20);
            this.txtlado.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lado:";
            // 
            // txtradioTri
            // 
            this.txtradioTri.Location = new System.Drawing.Point(210, 61);
            this.txtradioTri.Name = "txtradioTri";
            this.txtradioTri.Size = new System.Drawing.Size(27, 20);
            this.txtradioTri.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Radio:";
            // 
            // cbotridi
            // 
            this.cbotridi.FormattingEnabled = true;
            this.cbotridi.Items.AddRange(new object[] {
            "Esfera",
            "Cubo",
            "Tetraedro"});
            this.cbotridi.Location = new System.Drawing.Point(6, 45);
            this.cbotridi.Name = "cbotridi";
            this.cbotridi.Size = new System.Drawing.Size(121, 21);
            this.cbotridi.TabIndex = 5;
            this.cbotridi.Text = "Seleccione";
            this.cbotridi.SelectedIndexChanged += new System.EventHandler(this.cbotridi_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "metros.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "metros.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "FrmFiguras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBidi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbotridi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtradioTri;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblareatri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btncalctri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

