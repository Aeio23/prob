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
            this.lnumCantidadUnid = new System.Windows.Forms.NumericUpDown();
            this.btModificar = new System.Windows.Forms.Button();
            this.lbListaP = new System.Windows.Forms.Label();
            this.cbListaP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbUnidad = new System.Windows.Forms.RadioButton();
            this.rbPack = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lnumCantidadUnid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMPrecio
            // 
            this.lbMPrecio.AutoSize = true;
            this.lbMPrecio.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMPrecio.Location = new System.Drawing.Point(337, 227);
            this.lbMPrecio.Name = "lbMPrecio";
            this.lbMPrecio.Size = new System.Drawing.Size(99, 36);
            this.lbMPrecio.TabIndex = 17;
            this.lbMPrecio.Text = "$ 00,00";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(213, 227);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(94, 36);
            this.lbPrecio.TabIndex = 16;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(401, 94);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(87, 20);
            this.lbCantidad.TabIndex = 15;
            this.lbCantidad.Text = "Cantidades:";
            // 
            // lnumCantidadUnid
            // 
            this.lnumCantidadUnid.Location = new System.Drawing.Point(362, 137);
            this.lnumCantidadUnid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lnumCantidadUnid.Name = "lnumCantidadUnid";
            this.lnumCantidadUnid.Size = new System.Drawing.Size(84, 20);
            this.lnumCantidadUnid.TabIndex = 14;
            this.lnumCantidadUnid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(12, 11);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 13;
            this.btModificar.Text = "Agregar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // lbListaP
            // 
            this.lbListaP.AutoSize = true;
            this.lbListaP.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaP.Location = new System.Drawing.Point(141, 94);
            this.lbListaP.Name = "lbListaP";
            this.lbListaP.Size = new System.Drawing.Size(128, 20);
            this.lbListaP.TabIndex = 10;
            this.lbListaP.Text = "Lista de Produtos:";
            // 
            // cbListaP
            // 
            this.cbListaP.FormattingEnabled = true;
            this.cbListaP.Location = new System.Drawing.Point(130, 137);
            this.cbListaP.Name = "cbListaP";
            this.cbListaP.Size = new System.Drawing.Size(139, 21);
            this.cbListaP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Almacen Don Mario";
            // 
            // rbUnidad
            // 
            this.rbUnidad.AutoSize = true;
            this.rbUnidad.Checked = true;
            this.rbUnidad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnidad.Location = new System.Drawing.Point(461, 119);
            this.rbUnidad.Name = "rbUnidad";
            this.rbUnidad.Size = new System.Drawing.Size(66, 21);
            this.rbUnidad.TabIndex = 23;
            this.rbUnidad.TabStop = true;
            this.rbUnidad.Text = "Unidad";
            this.rbUnidad.UseVisualStyleBackColor = true;
            // 
            // rbPack
            // 
            this.rbPack.AutoSize = true;
            this.rbPack.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPack.Location = new System.Drawing.Point(461, 157);
            this.rbPack.Name = "rbPack";
            this.rbPack.Size = new System.Drawing.Size(52, 21);
            this.rbPack.TabIndex = 24;
            this.rbPack.Text = "Pack";
            this.rbPack.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(601, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rubro:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Papeleria",
            "Anillado",
            "Engrapado",
            "Alimentos",
            "Bebidas",
            "Productos Tecnologicos",
            "Productos de Higiene",
            "Productos Electronicos",
            "Especiales",
            "Otros..."});
            this.checkedListBox1.Location = new System.Drawing.Point(524, 222);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(132, 106);
            this.checkedListBox1.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.cuadro;
            this.pictureBox3.Location = new System.Drawing.Point(229, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // btVenta
            // 
            this.btVenta.BackColor = System.Drawing.Color.White;
            this.btVenta.FlatAppearance.BorderSize = 0;
            this.btVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenta.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenta.Location = new System.Drawing.Point(269, 301);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(97, 49);
            this.btVenta.TabIndex = 32;
            this.btVenta.Text = "Venta";
            this.btVenta.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 399);
            this.Controls.Add(this.btVenta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbPack);
            this.Controls.Add(this.rbUnidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lnumCantidadUnid);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.lbListaP);
            this.Controls.Add(this.cbListaP);
            this.Name = "Form1";
            this.Text = "Almacen Don Mario";
            ((System.ComponentModel.ISupportInitialize)(this.lnumCantidadUnid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.NumericUpDown lnumCantidadUnid;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label lbListaP;
        private System.Windows.Forms.ComboBox cbListaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbUnidad;
        private System.Windows.Forms.RadioButton rbPack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btVenta;

    }
}

