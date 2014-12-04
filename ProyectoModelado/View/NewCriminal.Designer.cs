namespace ProyectoModelado.View
{
    partial class NewCriminal
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
            this.imgCriminal = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCriminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCriminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sephiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suavizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nitidezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectoGaussianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtCondena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFianza = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlFotos = new System.Windows.Forms.Panel();
            this.cmbCarcel = new System.Windows.Forms.ComboBox();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.txtRelacion = new System.Windows.Forms.TextBox();
            this.lblRelacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCriminal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCriminal
            // 
            this.imgCriminal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imgCriminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCriminal.Location = new System.Drawing.Point(13, 37);
            this.imgCriminal.Name = "imgCriminal";
            this.imgCriminal.Size = new System.Drawing.Size(230, 290);
            this.imgCriminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCriminal.TabIndex = 0;
            this.imgCriminal.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criminalToolStripMenuItem,
            this.efectosToolStripMenuItem,
            this.imagenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criminalToolStripMenuItem
            // 
            this.criminalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCriminalToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarCriminalToolStripMenuItem});
            this.criminalToolStripMenuItem.Name = "criminalToolStripMenuItem";
            this.criminalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.criminalToolStripMenuItem.Text = "Criminal";
            // 
            // newCriminalToolStripMenuItem
            // 
            this.newCriminalToolStripMenuItem.Name = "newCriminalToolStripMenuItem";
            this.newCriminalToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newCriminalToolStripMenuItem.Text = "Abrir Imagen";
            this.newCriminalToolStripMenuItem.Click += new System.EventHandler(this.newCriminalToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.abrirToolStripMenuItem.Text = "Nuevo Criminal";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarCriminalToolStripMenuItem
            // 
            this.guardarCriminalToolStripMenuItem.Name = "guardarCriminalToolStripMenuItem";
            this.guardarCriminalToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.guardarCriminalToolStripMenuItem.Text = "Guardar Criminal";
            this.guardarCriminalToolStripMenuItem.Click += new System.EventHandler(this.guardarCriminalToolStripMenuItem_Click);
            // 
            // efectosToolStripMenuItem
            // 
            this.efectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaDeGrisesToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem1,
            this.sephiaToolStripMenuItem,
            this.contornoToolStripMenuItem,
            this.brilloToolStripMenuItem,
            this.suavizadoToolStripMenuItem,
            this.nitidezToolStripMenuItem,
            this.efectoGaussianoToolStripMenuItem});
            this.efectosToolStripMenuItem.Name = "efectosToolStripMenuItem";
            this.efectosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.efectosToolStripMenuItem.Text = "Efectos";
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Original";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem1
            // 
            this.escalaDeGrisesToolStripMenuItem1.Name = "escalaDeGrisesToolStripMenuItem1";
            this.escalaDeGrisesToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.escalaDeGrisesToolStripMenuItem1.Text = "Escala de Grises";
            this.escalaDeGrisesToolStripMenuItem1.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem1_Click);
            // 
            // sephiaToolStripMenuItem
            // 
            this.sephiaToolStripMenuItem.Name = "sephiaToolStripMenuItem";
            this.sephiaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sephiaToolStripMenuItem.Text = "Sephia";
            this.sephiaToolStripMenuItem.Click += new System.EventHandler(this.sephiaToolStripMenuItem_Click);
            // 
            // contornoToolStripMenuItem
            // 
            this.contornoToolStripMenuItem.Name = "contornoToolStripMenuItem";
            this.contornoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.contornoToolStripMenuItem.Text = "Contorno";
            this.contornoToolStripMenuItem.Click += new System.EventHandler(this.contornoToolStripMenuItem_Click);
            // 
            // brilloToolStripMenuItem
            // 
            this.brilloToolStripMenuItem.Name = "brilloToolStripMenuItem";
            this.brilloToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.brilloToolStripMenuItem.Text = "Brillo";
            this.brilloToolStripMenuItem.Click += new System.EventHandler(this.brilloToolStripMenuItem_Click);
            // 
            // suavizadoToolStripMenuItem
            // 
            this.suavizadoToolStripMenuItem.Name = "suavizadoToolStripMenuItem";
            this.suavizadoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.suavizadoToolStripMenuItem.Text = "Suavizado";
            this.suavizadoToolStripMenuItem.Click += new System.EventHandler(this.suavizadoToolStripMenuItem_Click);
            // 
            // nitidezToolStripMenuItem
            // 
            this.nitidezToolStripMenuItem.Name = "nitidezToolStripMenuItem";
            this.nitidezToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nitidezToolStripMenuItem.Text = "Nitidez";
            this.nitidezToolStripMenuItem.Click += new System.EventHandler(this.nitidezToolStripMenuItem_Click);
            // 
            // efectoGaussianoToolStripMenuItem
            // 
            this.efectoGaussianoToolStripMenuItem.Name = "efectoGaussianoToolStripMenuItem";
            this.efectoGaussianoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.efectoGaussianoToolStripMenuItem.Text = "Efecto Gaussiano";
            this.efectoGaussianoToolStripMenuItem.Click += new System.EventHandler(this.efectoGaussianoToolStripMenuItem_Click);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarImagenToolStripMenuItem,
            this.eliminarImagenToolStripMenuItem});
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // agregarImagenToolStripMenuItem
            // 
            this.agregarImagenToolStripMenuItem.Name = "agregarImagenToolStripMenuItem";
            this.agregarImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarImagenToolStripMenuItem.Text = "Agregar Imagen";
            this.agregarImagenToolStripMenuItem.Click += new System.EventHandler(this.agregarImagenToolStripMenuItem_Click);
            // 
            // eliminarImagenToolStripMenuItem
            // 
            this.eliminarImagenToolStripMenuItem.Name = "eliminarImagenToolStripMenuItem";
            this.eliminarImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.eliminarImagenToolStripMenuItem.Text = "EliminarImagen";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(280, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(381, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(381, 79);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(173, 20);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellidos";
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(381, 122);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(173, 20);
            this.txtAlias.TabIndex = 7;
            this.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alias";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(381, 163);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 20);
            this.txtEdad.TabIndex = 9;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edad";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatura.Location = new System.Drawing.Point(381, 203);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(55, 20);
            this.txtEstatura.TabIndex = 11;
            this.txtEstatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estatura";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(381, 279);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(173, 20);
            this.txtNacionalidad.TabIndex = 13;
            this.txtNacionalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nacionalidad";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(696, 37);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(173, 20);
            this.txtOrigen.TabIndex = 15;
            this.txtOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Origen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Carcel";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(601, 122);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(57, 18);
            this.lblEstatus.TabIndex = 18;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtCondena
            // 
            this.txtCondena.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondena.Location = new System.Drawing.Point(696, 159);
            this.txtCondena.Name = "txtCondena";
            this.txtCondena.Size = new System.Drawing.Size(173, 20);
            this.txtCondena.TabIndex = 21;
            this.txtCondena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(601, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Condena";
            // 
            // txtFianza
            // 
            this.txtFianza.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFianza.Location = new System.Drawing.Point(696, 199);
            this.txtFianza.Name = "txtFianza";
            this.txtFianza.Size = new System.Drawing.Size(173, 20);
            this.txtFianza.TabIndex = 23;
            this.txtFianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(601, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fianza";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(696, 244);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(173, 98);
            this.txtDescripcion.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(601, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Descripción";
            // 
            // pnlFotos
            // 
            this.pnlFotos.AutoScroll = true;
            this.pnlFotos.BackColor = System.Drawing.Color.Black;
            this.pnlFotos.Location = new System.Drawing.Point(13, 366);
            this.pnlFotos.Name = "pnlFotos";
            this.pnlFotos.Size = new System.Drawing.Size(856, 195);
            this.pnlFotos.TabIndex = 26;
            // 
            // cmbCarcel
            // 
            this.cmbCarcel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarcel.FormattingEnabled = true;
            this.cmbCarcel.Location = new System.Drawing.Point(696, 77);
            this.cmbCarcel.Name = "cmbCarcel";
            this.cmbCarcel.Size = new System.Drawing.Size(173, 23);
            this.cmbCarcel.TabIndex = 27;
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "Normal",
            "Peligroso",
            "Extre-Peligroso"});
            this.cmbEstatus.Location = new System.Drawing.Point(695, 117);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(173, 23);
            this.cmbEstatus.TabIndex = 28;
            // 
            // txtRelacion
            // 
            this.txtRelacion.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelacion.Location = new System.Drawing.Point(381, 243);
            this.txtRelacion.Name = "txtRelacion";
            this.txtRelacion.Size = new System.Drawing.Size(173, 20);
            this.txtRelacion.TabIndex = 30;
            this.txtRelacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRelacion
            // 
            this.lblRelacion.AutoSize = true;
            this.lblRelacion.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacion.Location = new System.Drawing.Point(280, 243);
            this.lblRelacion.Name = "lblRelacion";
            this.lblRelacion.Size = new System.Drawing.Size(65, 18);
            this.lblRelacion.TabIndex = 29;
            this.lblRelacion.Text = "Relación";
            // 
            // NewCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 581);
            this.Controls.Add(this.txtRelacion);
            this.Controls.Add(this.lblRelacion);
            this.Controls.Add(this.cmbEstatus);
            this.Controls.Add(this.cmbCarcel);
            this.Controls.Add(this.pnlFotos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFianza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCondena);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.imgCriminal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewCriminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCriminal";
            ((System.ComponentModel.ISupportInitialize)(this.imgCriminal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCriminal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCriminalToolStripMenuItem;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtCondena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFianza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlFotos;
        private System.Windows.Forms.ToolStripMenuItem efectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sephiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCriminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suavizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nitidezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efectoGaussianoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbCarcel;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.TextBox txtRelacion;
        private System.Windows.Forms.Label lblRelacion;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem;
    }
}