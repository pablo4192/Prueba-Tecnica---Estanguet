namespace IngematicaAppTest
{
    partial class FrmTest
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
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblLocalidadDestino = new System.Windows.Forms.Label();
            this.cbLocalidadDestino = new System.Windows.Forms.ComboBox();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.cbTipoTransporte = new System.Windows.Forms.ComboBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtFechaLlegada = new System.Windows.Forms.TextBox();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.txtDiasDemora = new System.Windows.Forms.TextBox();
            this.lblDiasDemora = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rdbAutopista = new System.Windows.Forms.RadioButton();
            this.rdbRuta = new System.Windows.Forms.RadioButton();
            this.lblCamino = new System.Windows.Forms.Label();
            this.lblAvisoCamino = new System.Windows.Forms.Label();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(239, 53);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(219, 28);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(17, 59);
            this.lblFechaInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(116, 24);
            this.lblFechaInicial.TabIndex = 1;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblLocalidadDestino
            // 
            this.lblLocalidadDestino.AutoSize = true;
            this.lblLocalidadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadDestino.Location = new System.Drawing.Point(16, 123);
            this.lblLocalidadDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidadDestino.Name = "lblLocalidadDestino";
            this.lblLocalidadDestino.Size = new System.Drawing.Size(159, 24);
            this.lblLocalidadDestino.TabIndex = 2;
            this.lblLocalidadDestino.Text = "Localidad Destino";
            // 
            // cbLocalidadDestino
            // 
            this.cbLocalidadDestino.DisplayMember = "Id";
            this.cbLocalidadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidadDestino.FormattingEnabled = true;
            this.cbLocalidadDestino.Location = new System.Drawing.Point(239, 119);
            this.cbLocalidadDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocalidadDestino.Name = "cbLocalidadDestino";
            this.cbLocalidadDestino.Size = new System.Drawing.Size(219, 30);
            this.cbLocalidadDestino.TabIndex = 3;
            this.cbLocalidadDestino.ValueMember = "Id";
            // 
            // lblTipoTransporte
            // 
            this.lblTipoTransporte.AutoSize = true;
            this.lblTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransporte.Location = new System.Drawing.Point(17, 181);
            this.lblTipoTransporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTransporte.Name = "lblTipoTransporte";
            this.lblTipoTransporte.Size = new System.Drawing.Size(144, 24);
            this.lblTipoTransporte.TabIndex = 4;
            this.lblTipoTransporte.Text = "Tipo Transporte";
            // 
            // cbTipoTransporte
            // 
            this.cbTipoTransporte.DisplayMember = "Id";
            this.cbTipoTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTransporte.FormattingEnabled = true;
            this.cbTipoTransporte.Location = new System.Drawing.Point(239, 177);
            this.cbTipoTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoTransporte.Name = "cbTipoTransporte";
            this.cbTipoTransporte.Size = new System.Drawing.Size(219, 30);
            this.cbTipoTransporte.TabIndex = 5;
            this.cbTipoTransporte.ValueMember = "Id";
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtFechaLlegada);
            this.gbResultado.Controls.Add(this.lblFechaLlegada);
            this.gbResultado.Controls.Add(this.txtDiasDemora);
            this.gbResultado.Controls.Add(this.lblDiasDemora);
            this.gbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(535, 53);
            this.gbResultado.Margin = new System.Windows.Forms.Padding(4);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Padding = new System.Windows.Forms.Padding(4);
            this.gbResultado.Size = new System.Drawing.Size(525, 234);
            this.gbResultado.TabIndex = 6;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(213, 119);
            this.txtFechaLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.ReadOnly = true;
            this.txtFechaLlegada.Size = new System.Drawing.Size(219, 28);
            this.txtFechaLlegada.TabIndex = 3;
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.Location = new System.Drawing.Point(27, 124);
            this.lblFechaLlegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(136, 24);
            this.lblFechaLlegada.TabIndex = 2;
            this.lblFechaLlegada.Text = "Fecha Llegada";
            // 
            // txtDiasDemora
            // 
            this.txtDiasDemora.Location = new System.Drawing.Point(213, 69);
            this.txtDiasDemora.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiasDemora.Name = "txtDiasDemora";
            this.txtDiasDemora.ReadOnly = true;
            this.txtDiasDemora.Size = new System.Drawing.Size(219, 28);
            this.txtDiasDemora.TabIndex = 1;
            // 
            // lblDiasDemora
            // 
            this.lblDiasDemora.AutoSize = true;
            this.lblDiasDemora.Location = new System.Drawing.Point(27, 74);
            this.lblDiasDemora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasDemora.Name = "lblDiasDemora";
            this.lblDiasDemora.Size = new System.Drawing.Size(118, 24);
            this.lblDiasDemora.TabIndex = 0;
            this.lblDiasDemora.Text = "Dias Demora";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(900, 324);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(165, 47);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(684, 324);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 47);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rdbAutopista
            // 
            this.rdbAutopista.AutoSize = true;
            this.rdbAutopista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAutopista.Location = new System.Drawing.Point(358, 242);
            this.rdbAutopista.Name = "rdbAutopista";
            this.rdbAutopista.Size = new System.Drawing.Size(100, 24);
            this.rdbAutopista.TabIndex = 11;
            this.rdbAutopista.TabStop = true;
            this.rdbAutopista.Text = "Autopista";
            this.rdbAutopista.UseVisualStyleBackColor = true;
            // 
            // rdbRuta
            // 
            this.rdbRuta.AutoSize = true;
            this.rdbRuta.BackColor = System.Drawing.SystemColors.Control;
            this.rdbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRuta.Location = new System.Drawing.Point(266, 242);
            this.rdbRuta.Name = "rdbRuta";
            this.rdbRuta.Size = new System.Drawing.Size(65, 24);
            this.rdbRuta.TabIndex = 12;
            this.rdbRuta.Text = "Ruta";
            this.rdbRuta.UseVisualStyleBackColor = false;
            // 
            // lblCamino
            // 
            this.lblCamino.AutoSize = true;
            this.lblCamino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamino.Location = new System.Drawing.Point(16, 242);
            this.lblCamino.Name = "lblCamino";
            this.lblCamino.Size = new System.Drawing.Size(207, 25);
            this.lblCamino.TabIndex = 13;
            this.lblCamino.Text = "Indique tipo de camino";
            // 
            // lblAvisoCamino
            // 
            this.lblAvisoCamino.AutoSize = true;
            this.lblAvisoCamino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCamino.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoCamino.Location = new System.Drawing.Point(183, 271);
            this.lblAvisoCamino.Name = "lblAvisoCamino";
            this.lblAvisoCamino.Size = new System.Drawing.Size(275, 16);
            this.lblAvisoCamino.TabIndex = 14;
            this.lblAvisoCamino.Text = "Escoger tipo de camino es obligatorio.";
            this.lblAvisoCamino.Visible = false;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 459);
            this.Controls.Add(this.lblAvisoCamino);
            this.Controls.Add(this.lblCamino);
            this.Controls.Add(this.rdbRuta);
            this.Controls.Add(this.rdbAutopista);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.cbTipoTransporte);
            this.Controls.Add(this.lblTipoTransporte);
            this.Controls.Add(this.cbLocalidadDestino);
            this.Controls.Add(this.lblLocalidadDestino);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dtpFechaInicial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblLocalidadDestino;
        private System.Windows.Forms.ComboBox cbLocalidadDestino;
        private System.Windows.Forms.Label lblTipoTransporte;
        private System.Windows.Forms.ComboBox cbTipoTransporte;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblDiasDemora;
        private System.Windows.Forms.TextBox txtFechaLlegada;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.TextBox txtDiasDemora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rdbAutopista;
        private System.Windows.Forms.RadioButton rdbRuta;
        private System.Windows.Forms.Label lblCamino;
        private System.Windows.Forms.Label lblAvisoCamino;
    }
}

