﻿namespace PPAI_DSI
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
            this.txt_cantidad_alumnos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_sedes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_escuelas = new System.Windows.Forms.ComboBox();
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_exposiciones = new System.Windows.Forms.DataGridView();
            this.dt_fecha_reserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_registrar_reserva = new System.Windows.Forms.Button();
            this.group_registrar_reserva = new System.Windows.Forms.GroupBox();
            this.lbl_guias_disponibles = new System.Windows.Forms.Label();
            this.grid_guias_disponibles = new System.Windows.Forms.DataGridView();
            this.dt_hora_reserva = new System.Windows.Forms.DateTimePicker();
            this.lbl_duracion_reserva = new System.Windows.Forms.Label();
            this.btn_ejecutar_registro_reserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_exposiciones)).BeginInit();
            this.group_registrar_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_guias_disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Escuelas";
            // 
            // txt_cantidad_alumnos
            // 
            this.txt_cantidad_alumnos.Enabled = false;
            this.txt_cantidad_alumnos.Location = new System.Drawing.Point(20, 92);
            this.txt_cantidad_alumnos.Name = "txt_cantidad_alumnos";
            this.txt_cantidad_alumnos.Size = new System.Drawing.Size(47, 20);
            this.txt_cantidad_alumnos.TabIndex = 29;
            this.txt_cantidad_alumnos.TextChanged += new System.EventHandler(this.txtVisitantes_Enter);
            this.txt_cantidad_alumnos.Enter += new System.EventHandler(this.txtVisitantes_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ingrese la cantidad de visitantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sedes";
            // 
            // grid_sedes
            // 
            this.grid_sedes.AllowUserToAddRows = false;
            this.grid_sedes.AllowUserToDeleteRows = false;
            this.grid_sedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sedes.Location = new System.Drawing.Point(20, 147);
            this.grid_sedes.MultiSelect = false;
            this.grid_sedes.Name = "grid_sedes";
            this.grid_sedes.ReadOnly = true;
            this.grid_sedes.Size = new System.Drawing.Size(556, 130);
            this.grid_sedes.TabIndex = 31;
            this.grid_sedes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipos de visita";
            // 
            // cmb_escuelas
            // 
            this.cmb_escuelas.FormattingEnabled = true;
            this.cmb_escuelas.Location = new System.Drawing.Point(20, 43);
            this.cmb_escuelas.Name = "cmb_escuelas";
            this.cmb_escuelas.Size = new System.Drawing.Size(121, 21);
            this.cmb_escuelas.TabIndex = 41;
            this.cmb_escuelas.TextChanged += new System.EventHandler(this.cmb_escuelas_TextChanged);
            this.cmb_escuelas.Enter += new System.EventHandler(this.cmb_escuelas_Enter);
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Location = new System.Drawing.Point(20, 302);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVisita.TabIndex = 42;
            this.cmbTipoVisita.Enter += new System.EventHandler(this.cmbTipoVisita_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Exposiciones";
            // 
            // grid_exposiciones
            // 
            this.grid_exposiciones.AllowUserToAddRows = false;
            this.grid_exposiciones.AllowUserToDeleteRows = false;
            this.grid_exposiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_exposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_exposiciones.Location = new System.Drawing.Point(20, 354);
            this.grid_exposiciones.Name = "grid_exposiciones";
            this.grid_exposiciones.ReadOnly = true;
            this.grid_exposiciones.Size = new System.Drawing.Size(556, 96);
            this.grid_exposiciones.TabIndex = 43;
            this.grid_exposiciones.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_RowHeaderMouseClick);
            // 
            // dt_fecha_reserva
            // 
            this.dt_fecha_reserva.Location = new System.Drawing.Point(20, 482);
            this.dt_fecha_reserva.Name = "dt_fecha_reserva";
            this.dt_fecha_reserva.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha_reserva.TabIndex = 46;
            this.dt_fecha_reserva.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de reserva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Hora de reserva";
            // 
            // btn_registrar_reserva
            // 
            this.btn_registrar_reserva.Location = new System.Drawing.Point(12, 23);
            this.btn_registrar_reserva.Name = "btn_registrar_reserva";
            this.btn_registrar_reserva.Size = new System.Drawing.Size(185, 23);
            this.btn_registrar_reserva.TabIndex = 50;
            this.btn_registrar_reserva.Text = "Registrar Reserva de Visita Guiada";
            this.btn_registrar_reserva.UseVisualStyleBackColor = true;
            this.btn_registrar_reserva.Click += new System.EventHandler(this.opcionRegReservaVisitaGuiada);
            // 
            // group_registrar_reserva
            // 
            this.group_registrar_reserva.Controls.Add(this.btn_ejecutar_registro_reserva);
            this.group_registrar_reserva.Controls.Add(this.lbl_guias_disponibles);
            this.group_registrar_reserva.Controls.Add(this.grid_guias_disponibles);
            this.group_registrar_reserva.Controls.Add(this.dt_hora_reserva);
            this.group_registrar_reserva.Controls.Add(this.lbl_duracion_reserva);
            this.group_registrar_reserva.Controls.Add(this.cmb_escuelas);
            this.group_registrar_reserva.Controls.Add(this.label1);
            this.group_registrar_reserva.Controls.Add(this.label6);
            this.group_registrar_reserva.Controls.Add(this.txt_cantidad_alumnos);
            this.group_registrar_reserva.Controls.Add(this.label4);
            this.group_registrar_reserva.Controls.Add(this.label3);
            this.group_registrar_reserva.Controls.Add(this.dt_fecha_reserva);
            this.group_registrar_reserva.Controls.Add(this.grid_sedes);
            this.group_registrar_reserva.Controls.Add(this.label5);
            this.group_registrar_reserva.Controls.Add(this.label2);
            this.group_registrar_reserva.Controls.Add(this.cmbTipoVisita);
            this.group_registrar_reserva.Controls.Add(this.grid_exposiciones);
            this.group_registrar_reserva.Controls.Add(this.label7);
            this.group_registrar_reserva.Location = new System.Drawing.Point(12, 62);
            this.group_registrar_reserva.Name = "group_registrar_reserva";
            this.group_registrar_reserva.Size = new System.Drawing.Size(599, 766);
            this.group_registrar_reserva.TabIndex = 51;
            this.group_registrar_reserva.TabStop = false;
            this.group_registrar_reserva.Text = "Registrar Reserva";
            this.group_registrar_reserva.Visible = false;
            // 
            // lbl_guias_disponibles
            // 
            this.lbl_guias_disponibles.AutoSize = true;
            this.lbl_guias_disponibles.Location = new System.Drawing.Point(21, 576);
            this.lbl_guias_disponibles.Name = "lbl_guias_disponibles";
            this.lbl_guias_disponibles.Size = new System.Drawing.Size(89, 13);
            this.lbl_guias_disponibles.TabIndex = 53;
            this.lbl_guias_disponibles.Text = "Guias disponibles";
            // 
            // grid_guias_disponibles
            // 
            this.grid_guias_disponibles.AllowUserToAddRows = false;
            this.grid_guias_disponibles.AllowUserToDeleteRows = false;
            this.grid_guias_disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_guias_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_guias_disponibles.Location = new System.Drawing.Point(20, 595);
            this.grid_guias_disponibles.Name = "grid_guias_disponibles";
            this.grid_guias_disponibles.ReadOnly = true;
            this.grid_guias_disponibles.Size = new System.Drawing.Size(556, 120);
            this.grid_guias_disponibles.TabIndex = 52;
            this.grid_guias_disponibles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_guias_disponibles_RowHeaderMouseClick);
            // 
            // dt_hora_reserva
            // 
            this.dt_hora_reserva.CustomFormat = "HH:mm:ss";
            this.dt_hora_reserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_hora_reserva.Location = new System.Drawing.Point(21, 537);
            this.dt_hora_reserva.Name = "dt_hora_reserva";
            this.dt_hora_reserva.ShowUpDown = true;
            this.dt_hora_reserva.Size = new System.Drawing.Size(120, 20);
            this.dt_hora_reserva.TabIndex = 51;
            this.dt_hora_reserva.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lbl_duracion_reserva
            // 
            this.lbl_duracion_reserva.AutoSize = true;
            this.lbl_duracion_reserva.Location = new System.Drawing.Point(245, 488);
            this.lbl_duracion_reserva.Name = "lbl_duracion_reserva";
            this.lbl_duracion_reserva.Size = new System.Drawing.Size(114, 13);
            this.lbl_duracion_reserva.TabIndex = 50;
            this.lbl_duracion_reserva.Text = "Duración de Reserva: ";
            // 
            // btn_ejecutar_registro_reserva
            // 
            this.btn_ejecutar_registro_reserva.Location = new System.Drawing.Point(223, 721);
            this.btn_ejecutar_registro_reserva.Name = "btn_ejecutar_registro_reserva";
            this.btn_ejecutar_registro_reserva.Size = new System.Drawing.Size(111, 23);
            this.btn_ejecutar_registro_reserva.TabIndex = 54;
            this.btn_ejecutar_registro_reserva.Text = "Registrar Reserva";
            this.btn_ejecutar_registro_reserva.UseVisualStyleBackColor = true;
            this.btn_ejecutar_registro_reserva.Click += new System.EventHandler(this.btn_ejecutar_registro_reserva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 908);
            this.Controls.Add(this.group_registrar_reserva);
            this.Controls.Add(this.btn_registrar_reserva);
            this.Name = "Form1";
            this.Text = "Ventana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_exposiciones)).EndInit();
            this.group_registrar_reserva.ResumeLayout(false);
            this.group_registrar_reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_guias_disponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad_alumnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_sedes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_escuelas;
        private System.Windows.Forms.ComboBox cmbTipoVisita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_exposiciones;
        private System.Windows.Forms.DateTimePicker dt_fecha_reserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_registrar_reserva;
        private System.Windows.Forms.GroupBox group_registrar_reserva;
        private System.Windows.Forms.Label lbl_duracion_reserva;
        private System.Windows.Forms.DateTimePicker dt_hora_reserva;
        private System.Windows.Forms.Label lbl_guias_disponibles;
        private System.Windows.Forms.DataGridView grid_guias_disponibles;
        private System.Windows.Forms.Button btn_ejecutar_registro_reserva;
    }
}

