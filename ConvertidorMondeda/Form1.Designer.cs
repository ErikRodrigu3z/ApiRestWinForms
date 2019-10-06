namespace ConvertidorMondeda
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboFormato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboDestino = new System.Windows.Forms.ComboBox();
            this.cmboOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblActualizacion = new System.Windows.Forms.Label();
            this.lblMDestino = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMOrigen = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(128, 171);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 43);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mondeda Origen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboFormato);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmboDestino);
            this.groupBox1.Controls.Add(this.cmboOrigen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApiKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar Petición";
            // 
            // cmboFormato
            // 
            this.cmboFormato.FormattingEnabled = true;
            this.cmboFormato.Items.AddRange(new object[] {
            "json",
            "xml"});
            this.cmboFormato.Location = new System.Drawing.Point(189, 88);
            this.cmboFormato.Name = "cmboFormato";
            this.cmboFormato.Size = new System.Drawing.Size(121, 21);
            this.cmboFormato.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Formato";
            // 
            // cmboDestino
            // 
            this.cmboDestino.FormattingEnabled = true;
            this.cmboDestino.Items.AddRange(new object[] {
            "MXN",
            "USD",
            "EUR",
            "CAD"});
            this.cmboDestino.Location = new System.Drawing.Point(189, 47);
            this.cmboDestino.Name = "cmboDestino";
            this.cmboDestino.Size = new System.Drawing.Size(121, 21);
            this.cmboDestino.TabIndex = 12;
            // 
            // cmboOrigen
            // 
            this.cmboOrigen.FormattingEnabled = true;
            this.cmboOrigen.Items.AddRange(new object[] {
            "MXN",
            "USD",
            "EUR",
            "CAD"});
            this.cmboOrigen.Location = new System.Drawing.Point(25, 47);
            this.cmboOrigen.Name = "cmboOrigen";
            this.cmboOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmboOrigen.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Api Key";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(25, 88);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(25, 134);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(285, 20);
            this.txtApiKey.TabIndex = 7;
            this.txtApiKey.Text = "2443|EorKdxYBZz2EfuOprGiqUEWUfR38dnJm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moneda a Convertir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actualización:";
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.AutoSize = true;
            this.lblActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblActualizacion.Location = new System.Drawing.Point(563, 12);
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(155, 25);
            this.lblActualizacion.TabIndex = 6;
            this.lblActualizacion.Text = "???????????";
            // 
            // lblMDestino
            // 
            this.lblMDestino.AutoSize = true;
            this.lblMDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMDestino.Location = new System.Drawing.Point(563, 59);
            this.lblMDestino.Name = "lblMDestino";
            this.lblMDestino.Size = new System.Drawing.Size(155, 25);
            this.lblMDestino.TabIndex = 8;
            this.lblMDestino.Text = "???????????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mondeda Destino:";
            // 
            // lblMOrigen
            // 
            this.lblMOrigen.AutoSize = true;
            this.lblMOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMOrigen.Location = new System.Drawing.Point(563, 114);
            this.lblMOrigen.Name = "lblMOrigen";
            this.lblMOrigen.Size = new System.Drawing.Size(155, 25);
            this.lblMOrigen.TabIndex = 10;
            this.lblMOrigen.Text = "???????????";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mondeda Origen:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(466, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Estaus:";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstatus.Location = new System.Drawing.Point(563, 221);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(155, 25);
            this.lblEstatus.TabIndex = 14;
            this.lblEstatus.Text = "???????????";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValor.Location = new System.Drawing.Point(563, 167);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(155, 25);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "???????????";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(483, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 25);
            this.label17.TabIndex = 15;
            this.label17.Text = "Valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 268);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMOrigen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblActualizacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmboOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboDestino;
        private System.Windows.Forms.ComboBox cmboFormato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblActualizacion;
        private System.Windows.Forms.Label lblMDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMOrigen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label17;
    }
}

