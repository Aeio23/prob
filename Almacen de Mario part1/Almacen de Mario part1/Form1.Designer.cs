namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMPrecio = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lnumCantidad = new System.Windows.Forms.NumericUpDown();
            this.btModificar = new System.Windows.Forms.Button();
            this.btVenta = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbListaP = new System.Windows.Forms.Label();
            this.cbListaP = new System.Windows.Forms.ComboBox();
            this.almacen = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.rbUnidad = new System.Windows.Forms.RadioButton();
            this.rbPack = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.lnumCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMPrecio
            // 
            this.lbMPrecio.AutoSize = true;
            this.lbMPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMPrecio.Location = new System.Drawing.Point(223, 188);
            this.lbMPrecio.Name = "lbMPrecio";
            this.lbMPrecio.Size = new System.Drawing.Size(56, 18);
            this.lbMPrecio.TabIndex = 17;
            this.lbMPrecio.Text = "$ 00,00";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(145, 188);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(55, 18);
            this.lbPrecio.TabIndex = 16;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(267, 90);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(86, 18);
            this.lbCantidad.TabIndex = 15;
            this.lbCantidad.Text = "Cantidades:";
            // 
            // lnumCantidad
            // 
            this.lnumCantidad.Location = new System.Drawing.Point(270, 120);
            this.lnumCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lnumCantidad.Name = "lnumCantidad";
            this.lnumCantidad.Size = new System.Drawing.Size(84, 20);
            this.lnumCantidad.TabIndex = 14;
            this.lnumCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.Silver;
            this.btModificar.Location = new System.Drawing.Point(12, 12);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 13;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btVenta
            // 
            this.btVenta.BackColor = System.Drawing.Color.DarkGray;
            this.btVenta.Location = new System.Drawing.Point(282, 246);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(86, 39);
            this.btVenta.TabIndex = 12;
            this.btVenta.Text = "Venta";
            this.btVenta.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.DarkGray;
            this.btAgregar.Location = new System.Drawing.Point(117, 246);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(86, 39);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // lbListaP
            // 
            this.lbListaP.AutoSize = true;
            this.lbListaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaP.Location = new System.Drawing.Point(72, 90);
            this.lbListaP.Name = "lbListaP";
            this.lbListaP.Size = new System.Drawing.Size(128, 18);
            this.lbListaP.TabIndex = 10;
            this.lbListaP.Text = "Lista de Produtos:";
            // 
            // cbListaP
            // 
            this.cbListaP.FormattingEnabled = true;
            this.cbListaP.Location = new System.Drawing.Point(61, 130);
            this.cbListaP.Name = "cbListaP";
            this.cbListaP.Size = new System.Drawing.Size(139, 21);
            this.cbListaP.TabIndex = 9;
            // 
            // almacen
            // 
            this.almacen.AutoSize = true;
            this.almacen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almacen.Location = new System.Drawing.Point(357, 15);
            this.almacen.Name = "almacen";
            this.almacen.Size = new System.Drawing.Size(118, 17);
            this.almacen.TabIndex = 21;
            this.almacen.Text = "Almacen Don Mario";
            // 
            // imagen
            // 
            this.imagen.Image = global::WindowsFormsApplication2.Properties.Resources.index;
            this.imagen.Location = new System.Drawing.Point(481, 6);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(55, 35);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 22;
            this.imagen.TabStop = false;
            // 
            // rbUnidad
            // 
            this.rbUnidad.AutoSize = true;
            this.rbUnidad.Checked = true;
            this.rbUnidad.Location = new System.Drawing.Point(360, 109);
            this.rbUnidad.Name = "rbUnidad";
            this.rbUnidad.Size = new System.Drawing.Size(59, 17);
            this.rbUnidad.TabIndex = 23;
            this.rbUnidad.TabStop = true;
            this.rbUnidad.Text = "Unidad";
            this.rbUnidad.UseVisualStyleBackColor = true;
            // 
            // rbPack
            // 
            this.rbPack.AutoSize = true;
            this.rbPack.Location = new System.Drawing.Point(360, 132);
            this.rbPack.Name = "rbPack";
            this.rbPack.Size = new System.Drawing.Size(50, 17);
            this.rbPack.TabIndex = 24;
            this.rbPack.Text = "Pack";
            this.rbPack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 387);
            this.Controls.Add(this.rbPack);
            this.Controls.Add(this.rbUnidad);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.almacen);
            this.Controls.Add(this.lbMPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lnumCantidad);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btVenta);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbListaP);
            this.Controls.Add(this.cbListaP);
            this.Name = "Form1";
            this.Text = "Almacen Don Mario";
            ((System.ComponentModel.ISupportInitialize)(this.lnumCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.NumericUpDown lnumCantidad;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbListaP;
        private System.Windows.Forms.ComboBox cbListaP;
        private System.Windows.Forms.Label almacen;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.RadioButton rbUnidad;
        private System.Windows.Forms.RadioButton rbPack;

    }
}

