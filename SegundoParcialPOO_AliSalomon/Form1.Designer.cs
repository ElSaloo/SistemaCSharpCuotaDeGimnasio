namespace SegundoParcialPOO_AliSalomon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtgvSocio = new System.Windows.Forms.DataGridView();
            this.dtgvCuotasDelClienteSeleccionado = new System.Windows.Forms.DataGridView();
            this.btnSocioAlta = new System.Windows.Forms.Button();
            this.btnSocioModificacion = new System.Windows.Forms.Button();
            this.btnSocioBaja = new System.Windows.Forms.Button();
            this.btnCuotaAlta = new System.Windows.Forms.Button();
            this.dtgvCuotasPagadasDelSocioSeleccionado = new System.Windows.Forms.DataGridView();
            this.dtgvPagosOrdenados = new System.Windows.Forms.DataGridView();
            this.dtgvTodasCuotasPagadas = new System.Windows.Forms.DataGridView();
            this.radioButtonMayorAMenor = new System.Windows.Forms.RadioButton();
            this.radioButtonMenorAMayor = new System.Windows.Forms.RadioButton();
            this.radioButtonEspecial = new System.Windows.Forms.RadioButton();
            this.radioButtonComun = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnGeneraCuotaATodos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCuotasDelClienteSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCuotasPagadasDelSocioSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagosOrdenados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTodasCuotasPagadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSocio
            // 
            this.dtgvSocio.AllowUserToAddRows = false;
            this.dtgvSocio.AllowUserToDeleteRows = false;
            this.dtgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSocio.Location = new System.Drawing.Point(26, 52);
            this.dtgvSocio.Name = "dtgvSocio";
            this.dtgvSocio.ReadOnly = true;
            this.dtgvSocio.Size = new System.Drawing.Size(243, 375);
            this.dtgvSocio.TabIndex = 0;
            this.dtgvSocio.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSocio_RowEnter);
            // 
            // dtgvCuotasDelClienteSeleccionado
            // 
            this.dtgvCuotasDelClienteSeleccionado.AllowUserToAddRows = false;
            this.dtgvCuotasDelClienteSeleccionado.AllowUserToDeleteRows = false;
            this.dtgvCuotasDelClienteSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCuotasDelClienteSeleccionado.Location = new System.Drawing.Point(298, 52);
            this.dtgvCuotasDelClienteSeleccionado.Name = "dtgvCuotasDelClienteSeleccionado";
            this.dtgvCuotasDelClienteSeleccionado.ReadOnly = true;
            this.dtgvCuotasDelClienteSeleccionado.Size = new System.Drawing.Size(611, 105);
            this.dtgvCuotasDelClienteSeleccionado.TabIndex = 1;
            // 
            // btnSocioAlta
            // 
            this.btnSocioAlta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSocioAlta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSocioAlta.Location = new System.Drawing.Point(32, 433);
            this.btnSocioAlta.Name = "btnSocioAlta";
            this.btnSocioAlta.Size = new System.Drawing.Size(75, 23);
            this.btnSocioAlta.TabIndex = 2;
            this.btnSocioAlta.Text = "Alta";
            this.btnSocioAlta.UseVisualStyleBackColor = false;
            this.btnSocioAlta.Click += new System.EventHandler(this.btnSocioAlta_Click);
            // 
            // btnSocioModificacion
            // 
            this.btnSocioModificacion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSocioModificacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSocioModificacion.Location = new System.Drawing.Point(113, 433);
            this.btnSocioModificacion.Name = "btnSocioModificacion";
            this.btnSocioModificacion.Size = new System.Drawing.Size(75, 23);
            this.btnSocioModificacion.TabIndex = 3;
            this.btnSocioModificacion.Text = "Modificacion";
            this.btnSocioModificacion.UseVisualStyleBackColor = false;
            this.btnSocioModificacion.Click += new System.EventHandler(this.btnSocioModificacion_Click);
            // 
            // btnSocioBaja
            // 
            this.btnSocioBaja.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSocioBaja.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSocioBaja.Location = new System.Drawing.Point(194, 433);
            this.btnSocioBaja.Name = "btnSocioBaja";
            this.btnSocioBaja.Size = new System.Drawing.Size(75, 23);
            this.btnSocioBaja.TabIndex = 4;
            this.btnSocioBaja.Text = "Baja";
            this.btnSocioBaja.UseVisualStyleBackColor = false;
            this.btnSocioBaja.Click += new System.EventHandler(this.btnSocioBaja_Click);
            // 
            // btnCuotaAlta
            // 
            this.btnCuotaAlta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCuotaAlta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuotaAlta.Location = new System.Drawing.Point(298, 163);
            this.btnCuotaAlta.Name = "btnCuotaAlta";
            this.btnCuotaAlta.Size = new System.Drawing.Size(75, 23);
            this.btnCuotaAlta.TabIndex = 5;
            this.btnCuotaAlta.Text = "Alta";
            this.btnCuotaAlta.UseVisualStyleBackColor = false;
            this.btnCuotaAlta.Click += new System.EventHandler(this.btnCuotaAlta_Click);
            // 
            // dtgvCuotasPagadasDelSocioSeleccionado
            // 
            this.dtgvCuotasPagadasDelSocioSeleccionado.AllowUserToAddRows = false;
            this.dtgvCuotasPagadasDelSocioSeleccionado.AllowUserToDeleteRows = false;
            this.dtgvCuotasPagadasDelSocioSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCuotasPagadasDelSocioSeleccionado.Location = new System.Drawing.Point(298, 234);
            this.dtgvCuotasPagadasDelSocioSeleccionado.Name = "dtgvCuotasPagadasDelSocioSeleccionado";
            this.dtgvCuotasPagadasDelSocioSeleccionado.ReadOnly = true;
            this.dtgvCuotasPagadasDelSocioSeleccionado.Size = new System.Drawing.Size(611, 110);
            this.dtgvCuotasPagadasDelSocioSeleccionado.TabIndex = 8;
            // 
            // dtgvPagosOrdenados
            // 
            this.dtgvPagosOrdenados.AllowUserToAddRows = false;
            this.dtgvPagosOrdenados.AllowUserToDeleteRows = false;
            this.dtgvPagosOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPagosOrdenados.Location = new System.Drawing.Point(298, 393);
            this.dtgvPagosOrdenados.Name = "dtgvPagosOrdenados";
            this.dtgvPagosOrdenados.ReadOnly = true;
            this.dtgvPagosOrdenados.Size = new System.Drawing.Size(611, 106);
            this.dtgvPagosOrdenados.TabIndex = 9;
            // 
            // dtgvTodasCuotasPagadas
            // 
            this.dtgvTodasCuotasPagadas.AllowUserToAddRows = false;
            this.dtgvTodasCuotasPagadas.AllowUserToDeleteRows = false;
            this.dtgvTodasCuotasPagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTodasCuotasPagadas.Location = new System.Drawing.Point(940, 52);
            this.dtgvTodasCuotasPagadas.Name = "dtgvTodasCuotasPagadas";
            this.dtgvTodasCuotasPagadas.ReadOnly = true;
            this.dtgvTodasCuotasPagadas.Size = new System.Drawing.Size(178, 447);
            this.dtgvTodasCuotasPagadas.TabIndex = 10;
            // 
            // radioButtonMayorAMenor
            // 
            this.radioButtonMayorAMenor.AutoSize = true;
            this.radioButtonMayorAMenor.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMayorAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMayorAMenor.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonMayorAMenor.Location = new System.Drawing.Point(298, 363);
            this.radioButtonMayorAMenor.Name = "radioButtonMayorAMenor";
            this.radioButtonMayorAMenor.Size = new System.Drawing.Size(125, 24);
            this.radioButtonMayorAMenor.TabIndex = 11;
            this.radioButtonMayorAMenor.TabStop = true;
            this.radioButtonMayorAMenor.Text = "Importe + / -";
            this.radioButtonMayorAMenor.UseVisualStyleBackColor = false;
            this.radioButtonMayorAMenor.CheckedChanged += new System.EventHandler(this.radioButtonMayorAMenor_CheckedChanged);
            // 
            // radioButtonMenorAMayor
            // 
            this.radioButtonMenorAMayor.AutoSize = true;
            this.radioButtonMenorAMayor.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMenorAMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMenorAMayor.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonMenorAMayor.Location = new System.Drawing.Point(429, 363);
            this.radioButtonMenorAMayor.Name = "radioButtonMenorAMayor";
            this.radioButtonMenorAMayor.Size = new System.Drawing.Size(125, 24);
            this.radioButtonMenorAMayor.TabIndex = 12;
            this.radioButtonMenorAMayor.TabStop = true;
            this.radioButtonMenorAMayor.Text = "Importe - / +";
            this.radioButtonMenorAMayor.UseVisualStyleBackColor = false;
            this.radioButtonMenorAMayor.CheckedChanged += new System.EventHandler(this.radioButtonMenorAMayor_CheckedChanged);
            // 
            // radioButtonEspecial
            // 
            this.radioButtonEspecial.AutoSize = true;
            this.radioButtonEspecial.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEspecial.ForeColor = System.Drawing.Color.Gold;
            this.radioButtonEspecial.Location = new System.Drawing.Point(204, 29);
            this.radioButtonEspecial.Name = "radioButtonEspecial";
            this.radioButtonEspecial.Size = new System.Drawing.Size(65, 17);
            this.radioButtonEspecial.TabIndex = 14;
            this.radioButtonEspecial.TabStop = true;
            this.radioButtonEspecial.Text = "Especial";
            this.radioButtonEspecial.UseVisualStyleBackColor = false;
            // 
            // radioButtonComun
            // 
            this.radioButtonComun.AutoSize = true;
            this.radioButtonComun.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonComun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonComun.Location = new System.Drawing.Point(140, 29);
            this.radioButtonComun.Name = "radioButtonComun";
            this.radioButtonComun.Size = new System.Drawing.Size(58, 17);
            this.radioButtonComun.TabIndex = 13;
            this.radioButtonComun.TabStop = true;
            this.radioButtonComun.Text = "Comun";
            this.radioButtonComun.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Socios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(293, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cuotas del socio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(294, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cuotas Pagadas del socio";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.Snow;
            this.btnPagar.Location = new System.Drawing.Point(379, 163);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 18;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnGeneraCuotaATodos
            // 
            this.btnGeneraCuotaATodos.BackColor = System.Drawing.Color.Firebrick;
            this.btnGeneraCuotaATodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraCuotaATodos.ForeColor = System.Drawing.Color.Snow;
            this.btnGeneraCuotaATodos.Location = new System.Drawing.Point(32, 462);
            this.btnGeneraCuotaATodos.Name = "btnGeneraCuotaATodos";
            this.btnGeneraCuotaATodos.Size = new System.Drawing.Size(237, 37);
            this.btnGeneraCuotaATodos.TabIndex = 19;
            this.btnGeneraCuotaATodos.Text = "Generar cuota a todos";
            this.btnGeneraCuotaATodos.UseVisualStyleBackColor = false;
            this.btnGeneraCuotaATodos.Click += new System.EventHandler(this.btnGeneraCuotaATodos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(935, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cuotas pagadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeneraCuotaATodos);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonEspecial);
            this.Controls.Add(this.radioButtonComun);
            this.Controls.Add(this.radioButtonMenorAMayor);
            this.Controls.Add(this.radioButtonMayorAMenor);
            this.Controls.Add(this.dtgvTodasCuotasPagadas);
            this.Controls.Add(this.dtgvPagosOrdenados);
            this.Controls.Add(this.dtgvCuotasPagadasDelSocioSeleccionado);
            this.Controls.Add(this.btnCuotaAlta);
            this.Controls.Add(this.btnSocioBaja);
            this.Controls.Add(this.btnSocioModificacion);
            this.Controls.Add(this.btnSocioAlta);
            this.Controls.Add(this.dtgvCuotasDelClienteSeleccionado);
            this.Controls.Add(this.dtgvSocio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Life Club -Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCuotasDelClienteSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCuotasPagadasDelSocioSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPagosOrdenados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTodasCuotasPagadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSocio;
        private System.Windows.Forms.DataGridView dtgvCuotasDelClienteSeleccionado;
        private System.Windows.Forms.Button btnSocioAlta;
        private System.Windows.Forms.Button btnSocioModificacion;
        private System.Windows.Forms.Button btnSocioBaja;
        private System.Windows.Forms.Button btnCuotaAlta;
        private System.Windows.Forms.DataGridView dtgvCuotasPagadasDelSocioSeleccionado;
        private System.Windows.Forms.DataGridView dtgvPagosOrdenados;
        private System.Windows.Forms.DataGridView dtgvTodasCuotasPagadas;
        private System.Windows.Forms.RadioButton radioButtonMayorAMenor;
        private System.Windows.Forms.RadioButton radioButtonMenorAMayor;
        private System.Windows.Forms.RadioButton radioButtonEspecial;
        private System.Windows.Forms.RadioButton radioButtonComun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnGeneraCuotaATodos;
        private System.Windows.Forms.Label label4;
    }
}

