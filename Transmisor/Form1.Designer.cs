namespace Transmisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudTamanioDatos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCantidadPaquetes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidadRanuras = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTamanioPaquete = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTimeoutPaquete = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTransmitir = new System.Windows.Forms.Button();
            this.nudIP1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudIP2 = new System.Windows.Forms.NumericUpDown();
            this.nudIP3 = new System.Windows.Forms.NumericUpDown();
            this.nudIP4 = new System.Windows.Forms.NumericUpDown();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTamanioExtraHeaders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadRanuras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioPaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeoutPaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de datos";
            // 
            // nudTamanioDatos
            // 
            this.nudTamanioDatos.Location = new System.Drawing.Point(119, 25);
            this.nudTamanioDatos.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTamanioDatos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTamanioDatos.Name = "nudTamanioDatos";
            this.nudTamanioDatos.Size = new System.Drawing.Size(113, 20);
            this.nudTamanioDatos.TabIndex = 1;
            this.nudTamanioDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTamanioDatos.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTamanioDatos.ValueChanged += new System.EventHandler(this.nudTamanioDatos_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bytes";
            // 
            // lbCantidadPaquetes
            // 
            this.lbCantidadPaquetes.AutoSize = true;
            this.lbCantidadPaquetes.Location = new System.Drawing.Point(140, 93);
            this.lbCantidadPaquetes.Name = "lbCantidadPaquetes";
            this.lbCantidadPaquetes.Size = new System.Drawing.Size(102, 13);
            this.lbCantidadPaquetes.TabIndex = 5;
            this.lbCantidadPaquetes.Text = "lbCantidadPaquetes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de paquetes";
            // 
            // nudCantidadRanuras
            // 
            this.nudCantidadRanuras.Location = new System.Drawing.Point(132, 155);
            this.nudCantidadRanuras.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudCantidadRanuras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadRanuras.Name = "nudCantidadRanuras";
            this.nudCantidadRanuras.Size = new System.Drawing.Size(61, 20);
            this.nudCantidadRanuras.TabIndex = 7;
            this.nudCantidadRanuras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCantidadRanuras.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad de ranuras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bytes";
            // 
            // nudTamanioPaquete
            // 
            this.nudTamanioPaquete.Location = new System.Drawing.Point(132, 63);
            this.nudTamanioPaquete.Maximum = new decimal(new int[] {
            65500,
            0,
            0,
            0});
            this.nudTamanioPaquete.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTamanioPaquete.Name = "nudTamanioPaquete";
            this.nudTamanioPaquete.Size = new System.Drawing.Size(61, 20);
            this.nudTamanioPaquete.TabIndex = 10;
            this.nudTamanioPaquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTamanioPaquete.Value = new decimal(new int[] {
            65500,
            0,
            0,
            0});
            this.nudTamanioPaquete.ValueChanged += new System.EventHandler(this.nudTamanioPaquete_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tamaño de paquete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Milisegundos";
            // 
            // nudTimeoutPaquete
            // 
            this.nudTimeoutPaquete.Location = new System.Drawing.Point(132, 181);
            this.nudTimeoutPaquete.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeoutPaquete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeoutPaquete.Name = "nudTimeoutPaquete";
            this.nudTimeoutPaquete.Size = new System.Drawing.Size(61, 20);
            this.nudTimeoutPaquete.TabIndex = 13;
            this.nudTimeoutPaquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimeoutPaquete.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Timeout de paquete";
            // 
            // btnTransmitir
            // 
            this.btnTransmitir.Location = new System.Drawing.Point(222, 279);
            this.btnTransmitir.Name = "btnTransmitir";
            this.btnTransmitir.Size = new System.Drawing.Size(75, 23);
            this.btnTransmitir.TabIndex = 15;
            this.btnTransmitir.Text = "Transmitir";
            this.btnTransmitir.UseVisualStyleBackColor = true;
            this.btnTransmitir.Click += new System.EventHandler(this.btnTransmitir_Click);
            // 
            // nudIP1
            // 
            this.nudIP1.Location = new System.Drawing.Point(88, 225);
            this.nudIP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudIP1.Name = "nudIP1";
            this.nudIP1.Size = new System.Drawing.Size(46, 20);
            this.nudIP1.TabIndex = 17;
            this.nudIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIP1.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "IP Destino";
            // 
            // nudIP2
            // 
            this.nudIP2.Location = new System.Drawing.Point(140, 225);
            this.nudIP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudIP2.Name = "nudIP2";
            this.nudIP2.Size = new System.Drawing.Size(46, 20);
            this.nudIP2.TabIndex = 18;
            this.nudIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIP2.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            // 
            // nudIP3
            // 
            this.nudIP3.Location = new System.Drawing.Point(192, 225);
            this.nudIP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudIP3.Name = "nudIP3";
            this.nudIP3.Size = new System.Drawing.Size(46, 20);
            this.nudIP3.TabIndex = 19;
            this.nudIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIP3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudIP4
            // 
            this.nudIP4.Location = new System.Drawing.Point(244, 225);
            this.nudIP4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudIP4.Name = "nudIP4";
            this.nudIP4.Size = new System.Drawing.Size(46, 20);
            this.nudIP4.TabIndex = 20;
            this.nudIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIP4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudPuerto
            // 
            this.nudPuerto.Location = new System.Drawing.Point(88, 251);
            this.nudPuerto.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPuerto.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudPuerto.Name = "nudPuerto";
            this.nudPuerto.Size = new System.Drawing.Size(61, 20);
            this.nudPuerto.TabIndex = 22;
            this.nudPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPuerto.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Puerto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbTamanioExtraHeaders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudPuerto);
            this.groupBox1.Controls.Add(this.nudTamanioDatos);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudIP4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudIP3);
            this.groupBox1.Controls.Add(this.lbCantidadPaquetes);
            this.groupBox1.Controls.Add(this.nudIP2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudIP1);
            this.groupBox1.Controls.Add(this.nudCantidadRanuras);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnTransmitir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudTamanioPaquete);
            this.groupBox1.Controls.Add(this.nudTimeoutPaquete);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 319);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Tamaño extra por headers";
            // 
            // lbTamanioExtraHeaders
            // 
            this.lbTamanioExtraHeaders.AutoSize = true;
            this.lbTamanioExtraHeaders.Location = new System.Drawing.Point(160, 115);
            this.lbTamanioExtraHeaders.Name = "lbTamanioExtraHeaders";
            this.lbTamanioExtraHeaders.Size = new System.Drawing.Size(120, 13);
            this.lbTamanioExtraHeaders.TabIndex = 24;
            this.lbTamanioExtraHeaders.Text = "lbTamanioExtraHeaders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 372);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Transmisor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadRanuras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioPaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeoutPaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTamanioDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCantidadPaquetes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCantidadRanuras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTamanioPaquete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTimeoutPaquete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTransmitir;
        private System.Windows.Forms.NumericUpDown nudIP1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudIP2;
        private System.Windows.Forms.NumericUpDown nudIP3;
        private System.Windows.Forms.NumericUpDown nudIP4;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTamanioExtraHeaders;
    }
}

