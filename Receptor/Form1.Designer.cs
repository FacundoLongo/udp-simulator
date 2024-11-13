namespace Receptor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCantidadPaquetes = new System.Windows.Forms.Label();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalBytesRecibidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalBytesDatos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalBytesHeaders = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTotalBytesHeaders);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTotalBytesDatos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbTotalBytesRecibidos);
            this.groupBox1.Controls.Add(this.nudPuerto);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbCantidadPaquetes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 174);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // nudPuerto
            // 
            this.nudPuerto.Location = new System.Drawing.Point(89, 28);
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
            this.label11.Location = new System.Drawing.Point(24, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de paquetes";
            // 
            // lbCantidadPaquetes
            // 
            this.lbCantidadPaquetes.AutoSize = true;
            this.lbCantidadPaquetes.Location = new System.Drawing.Point(158, 69);
            this.lbCantidadPaquetes.Name = "lbCantidadPaquetes";
            this.lbCantidadPaquetes.Size = new System.Drawing.Size(102, 13);
            this.lbCantidadPaquetes.TabIndex = 5;
            this.lbCantidadPaquetes.Text = "lbCantidadPaquetes";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(12, 204);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(75, 23);
            this.btnRecibir.TabIndex = 15;
            this.btnRecibir.Text = "Recibir";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(312, 205);
            this.textBox1.TabIndex = 26;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 204);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total bytes recibidos";
            // 
            // lbTotalBytesRecibidos
            // 
            this.lbTotalBytesRecibidos.AutoSize = true;
            this.lbTotalBytesRecibidos.Location = new System.Drawing.Point(158, 92);
            this.lbTotalBytesRecibidos.Name = "lbTotalBytesRecibidos";
            this.lbTotalBytesRecibidos.Size = new System.Drawing.Size(112, 13);
            this.lbTotalBytesRecibidos.TabIndex = 24;
            this.lbTotalBytesRecibidos.Text = "lbTotalBytesRecibidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total bytes datos";
            // 
            // lbTotalBytesDatos
            // 
            this.lbTotalBytesDatos.AutoSize = true;
            this.lbTotalBytesDatos.Location = new System.Drawing.Point(158, 113);
            this.lbTotalBytesDatos.Name = "lbTotalBytesDatos";
            this.lbTotalBytesDatos.Size = new System.Drawing.Size(93, 13);
            this.lbTotalBytesDatos.TabIndex = 26;
            this.lbTotalBytesDatos.Text = "lbTotalBytesDatos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tamaño extra por headers";
            // 
            // lbTotalBytesHeaders
            // 
            this.lbTotalBytesHeaders.AutoSize = true;
            this.lbTotalBytesHeaders.Location = new System.Drawing.Point(158, 137);
            this.lbTotalBytesHeaders.Name = "lbTotalBytesHeaders";
            this.lbTotalBytesHeaders.Size = new System.Drawing.Size(105, 13);
            this.lbTotalBytesHeaders.TabIndex = 28;
            this.lbTotalBytesHeaders.Text = "lbTotalBytesHeaders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRecibir);
            this.Name = "Form1";
            this.Text = "Receptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCantidadPaquetes;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalBytesDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalBytesRecibidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalBytesHeaders;
    }
}

