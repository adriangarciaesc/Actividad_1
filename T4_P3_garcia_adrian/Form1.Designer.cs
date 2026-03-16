namespace T4_P3_garcia_adrian
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
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.chkPrioridadAlta = new System.Windows.Forms.CheckBox();
            this.lblContadorTareas = new System.Windows.Forms.Label();
            this.lblnoProgramar = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.labnoProgramar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(90, 39);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(253, 22);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(90, 67);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(253, 207);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(90, 280);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerFecha.TabIndex = 2;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(125, 365);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(165, 46);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir Tarea";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.ItemHeight = 16;
            this.listBoxTareas.Location = new System.Drawing.Point(366, 71);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(422, 260);
            this.listBoxTareas.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(653, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(390, 339);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(162, 43);
            this.btnCompletar.TabIndex = 6;
            this.btnCompletar.Text = "Marcar como completada";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(558, 342);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 43);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // chkPrioridadAlta
            // 
            this.chkPrioridadAlta.AutoSize = true;
            this.chkPrioridadAlta.Location = new System.Drawing.Point(150, 339);
            this.chkPrioridadAlta.Name = "chkPrioridadAlta";
            this.chkPrioridadAlta.Size = new System.Drawing.Size(110, 20);
            this.chkPrioridadAlta.TabIndex = 10;
            this.chkPrioridadAlta.Text = "Prioridad Alta";
            this.chkPrioridadAlta.UseVisualStyleBackColor = true;
            // 
            // lblContadorTareas
            // 
            this.lblContadorTareas.AutoSize = true;
            this.lblContadorTareas.Location = new System.Drawing.Point(493, 45);
            this.lblContadorTareas.Name = "lblContadorTareas";
            this.lblContadorTareas.Size = new System.Drawing.Size(91, 16);
            this.lblContadorTareas.TabIndex = 11;
            this.lblContadorTareas.Text = "labelCantidad";
            // 
            // lblnoProgramar
            // 
            this.lblnoProgramar.AutoSize = true;
            this.lblnoProgramar.Location = new System.Drawing.Point(376, 45);
            this.lblnoProgramar.Name = "lblnoProgramar";
            this.lblnoProgramar.Size = new System.Drawing.Size(124, 16);
            this.lblnoProgramar.TabIndex = 12;
            this.lblnoProgramar.Text = "Número de Tareas:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Entornos de Desarrollo",
            "Base de Datos",
            "Sistemas Informaticos",
            "Programacion",
            "Lenguaje de Marcas",
            "Intermodular",
            "FOL",
            "Ingles"});
            this.cmbCategoria.Location = new System.Drawing.Point(202, 308);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 13;
            // 
            // labnoProgramar
            // 
            this.labnoProgramar.AutoSize = true;
            this.labnoProgramar.Location = new System.Drawing.Point(105, 311);
            this.labnoProgramar.Name = "labnoProgramar";
            this.labnoProgramar.Size = new System.Drawing.Size(91, 16);
            this.labnoProgramar.TabIndex = 14;
            this.labnoProgramar.Text = "Tipo de tarea:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labnoProgramar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblnoProgramar);
            this.Controls.Add(this.lblContadorTareas);
            this.Controls.Add(this.chkPrioridadAlta);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listBoxTareas);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.CheckBox chkPrioridadAlta;
        private System.Windows.Forms.Label lblContadorTareas;
        private System.Windows.Forms.Label lblnoProgramar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label labnoProgramar;
    }
}

