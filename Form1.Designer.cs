namespace Comparendos
{
    partial class Comparendos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProm1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfra1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProm2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInfra2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotal3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProm3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInfra3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotal4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProm4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInfra4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgbMultas = new System.Windows.Forms.DataGridView();
            this.colplaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvelocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvelocidadlimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comparendos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtVelocidad);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar comparendo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Comparendo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(105, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "20000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Multa establecida";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(138, 75);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(105, 20);
            this.txtVelocidad.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Velocidad";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(137, 49);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(105, 20);
            this.txtPlaca.TabIndex = 3;
            this.txtPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Registro vehiculo";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cuadrante 1",
            "Cuadrante 2",
            "Cuadrante 3",
            "Cuadrante 4"});
            this.comboBox1.Location = new System.Drawing.Point(137, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuadrante";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.txtTotal1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProm1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtInfra1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(79, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadrante 1";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(124, 93);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.ReadOnly = true;
            this.txtTotal1.Size = new System.Drawing.Size(82, 20);
            this.txtTotal1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total multas";
            // 
            // txtProm1
            // 
            this.txtProm1.Location = new System.Drawing.Point(124, 56);
            this.txtProm1.Name = "txtProm1";
            this.txtProm1.ReadOnly = true;
            this.txtProm1.Size = new System.Drawing.Size(82, 20);
            this.txtProm1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Multa promedio";
            // 
            // txtInfra1
            // 
            this.txtInfra1.Location = new System.Drawing.Point(124, 22);
            this.txtInfra1.Name = "txtInfra1";
            this.txtInfra1.ReadOnly = true;
            this.txtInfra1.Size = new System.Drawing.Size(82, 20);
            this.txtInfra1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total infracciones";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox3.Controls.Add(this.txtTotal2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtProm2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtInfra2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(342, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 133);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuadrante 2";
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(124, 93);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.ReadOnly = true;
            this.txtTotal2.Size = new System.Drawing.Size(82, 20);
            this.txtTotal2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total multas";
            // 
            // txtProm2
            // 
            this.txtProm2.Location = new System.Drawing.Point(124, 56);
            this.txtProm2.Name = "txtProm2";
            this.txtProm2.ReadOnly = true;
            this.txtProm2.Size = new System.Drawing.Size(82, 20);
            this.txtProm2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Multa promedio";
            // 
            // txtInfra2
            // 
            this.txtInfra2.Location = new System.Drawing.Point(124, 22);
            this.txtInfra2.Name = "txtInfra2";
            this.txtInfra2.ReadOnly = true;
            this.txtInfra2.Size = new System.Drawing.Size(82, 20);
            this.txtInfra2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total infracciones";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox4.Controls.Add(this.txtTotal3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtProm3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtInfra3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(79, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 133);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuadrante 3";
            // 
            // txtTotal3
            // 
            this.txtTotal3.Location = new System.Drawing.Point(124, 93);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.ReadOnly = true;
            this.txtTotal3.Size = new System.Drawing.Size(82, 20);
            this.txtTotal3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total multas";
            // 
            // txtProm3
            // 
            this.txtProm3.Location = new System.Drawing.Point(124, 56);
            this.txtProm3.Name = "txtProm3";
            this.txtProm3.ReadOnly = true;
            this.txtProm3.Size = new System.Drawing.Size(82, 20);
            this.txtProm3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Multa promedio";
            // 
            // txtInfra3
            // 
            this.txtInfra3.Location = new System.Drawing.Point(124, 22);
            this.txtInfra3.Name = "txtInfra3";
            this.txtInfra3.ReadOnly = true;
            this.txtInfra3.Size = new System.Drawing.Size(82, 20);
            this.txtInfra3.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total infracciones";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox5.Controls.Add(this.txtTotal4);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtProm4);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtInfra4);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(342, 391);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 133);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cuadrante 4";
            // 
            // txtTotal4
            // 
            this.txtTotal4.Location = new System.Drawing.Point(124, 93);
            this.txtTotal4.Name = "txtTotal4";
            this.txtTotal4.ReadOnly = true;
            this.txtTotal4.Size = new System.Drawing.Size(82, 20);
            this.txtTotal4.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total multas";
            // 
            // txtProm4
            // 
            this.txtProm4.Location = new System.Drawing.Point(124, 56);
            this.txtProm4.Name = "txtProm4";
            this.txtProm4.ReadOnly = true;
            this.txtProm4.Size = new System.Drawing.Size(82, 20);
            this.txtProm4.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Multa promedio";
            // 
            // txtInfra4
            // 
            this.txtInfra4.Location = new System.Drawing.Point(124, 22);
            this.txtInfra4.Name = "txtInfra4";
            this.txtInfra4.ReadOnly = true;
            this.txtInfra4.Size = new System.Drawing.Size(82, 20);
            this.txtInfra4.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total infracciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgbMultas);
            this.groupBox6.Location = new System.Drawing.Point(306, 42);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 168);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ver multas";
            // 
            // dgbMultas
            // 
            this.dgbMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colplaca,
            this.colvelocidad,
            this.colvelocidadlimite,
            this.colmulta});
            this.dgbMultas.Location = new System.Drawing.Point(14, 16);
            this.dgbMultas.Name = "dgbMultas";
            this.dgbMultas.Size = new System.Drawing.Size(442, 148);
            this.dgbMultas.TabIndex = 0;
            this.dgbMultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colplaca
            // 
            this.colplaca.HeaderText = "Placa";
            this.colplaca.Name = "colplaca";
            // 
            // colvelocidad
            // 
            this.colvelocidad.HeaderText = "Velocidad";
            this.colvelocidad.Name = "colvelocidad";
            // 
            // colvelocidadlimite
            // 
            this.colvelocidadlimite.HeaderText = "Velocidad limite";
            this.colvelocidadlimite.Name = "colvelocidadlimite";
            // 
            // colmulta
            // 
            this.colmulta.HeaderText = "Multa";
            this.colmulta.Name = "colmulta";
            // 
            // Comparendos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 579);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Comparendos";
            this.Text = "Comparendos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProm1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInfra1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProm2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInfra2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTotal3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProm3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInfra3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotal4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProm4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInfra4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgbMultas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colplaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvelocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvelocidadlimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmulta;
    }
}

