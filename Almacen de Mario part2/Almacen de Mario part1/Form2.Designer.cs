namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbUnid = new System.Windows.Forms.Label();
            this.lbPac = new System.Windows.Forms.Label();
            this.tbUnidad = new System.Windows.Forms.TextBox();
            this.tbPack = new System.Windows.Forms.TextBox();
            this.tbRendimiento = new System.Windows.Forms.TextBox();
            this.lbXPac = new System.Windows.Forms.Label();
            this.numPack = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRinde = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(309, 51);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(130, 20);
            this.tbProducto.TabIndex = 0;
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(282, 313);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(128, 42);
            this.btAgregar.TabIndex = 12;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(208, 51);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(74, 20);
            this.lbProducto.TabIndex = 13;
            this.lbProducto.Text = "Producto:";
            // 
            // lbUnid
            // 
            this.lbUnid.AutoSize = true;
            this.lbUnid.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnid.Location = new System.Drawing.Point(69, 169);
            this.lbUnid.Name = "lbUnid";
            this.lbUnid.Size = new System.Drawing.Size(90, 20);
            this.lbUnid.TabIndex = 14;
            this.lbUnid.Text = "Por Unidad:";
            // 
            // lbPac
            // 
            this.lbPac.AutoSize = true;
            this.lbPac.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPac.Location = new System.Drawing.Point(376, 169);
            this.lbPac.Name = "lbPac";
            this.lbPac.Size = new System.Drawing.Size(72, 20);
            this.lbPac.TabIndex = 16;
            this.lbPac.Text = "Por Pack:";
            // 
            // tbUnidad
            // 
            this.tbUnidad.Location = new System.Drawing.Point(201, 168);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(100, 20);
            this.tbUnidad.TabIndex = 17;
            // 
            // tbPack
            // 
            this.tbPack.Location = new System.Drawing.Point(448, 165);
            this.tbPack.Name = "tbPack";
            this.tbPack.Size = new System.Drawing.Size(112, 20);
            this.tbPack.TabIndex = 18;
            // 
            // tbRendimiento
            // 
            this.tbRendimiento.Location = new System.Drawing.Point(201, 211);
            this.tbRendimiento.Name = "tbRendimiento";
            this.tbRendimiento.Size = new System.Drawing.Size(100, 20);
            this.tbRendimiento.TabIndex = 20;
            // 
            // lbXPac
            // 
            this.lbXPac.AutoSize = true;
            this.lbXPac.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXPac.Location = new System.Drawing.Point(338, 212);
            this.lbXPac.Name = "lbXPac";
            this.lbXPac.Size = new System.Drawing.Size(141, 40);
            this.lbXPac.TabIndex = 19;
            this.lbXPac.Text = "Cantidades del\r\n Producto por Pack:";
            this.lbXPac.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numPack
            // 
            this.numPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPack.Location = new System.Drawing.Point(494, 230);
            this.numPack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPack.Name = "numPack";
            this.numPack.Size = new System.Drawing.Size(66, 22);
            this.numPack.TabIndex = 21;
            this.numPack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Almacen Don Mario";
            // 
            // lbRinde
            // 
            this.lbRinde.AutoSize = true;
            this.lbRinde.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRinde.Location = new System.Drawing.Point(69, 212);
            this.lbRinde.Name = "lbRinde";
            this.lbRinde.Size = new System.Drawing.Size(114, 20);
            this.lbRinde.TabIndex = 25;
            this.lbRinde.Text = "Cuanto Rinden:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Para que se utiliza:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.cuadro;
            this.pictureBox3.Location = new System.Drawing.Point(256, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.caja1;
            this.pictureBox2.Location = new System.Drawing.Point(323, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(582, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.BackColor = System.Drawing.Color.White;
            this.lbPrecio.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(304, 101);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(75, 26);
            this.lbPrecio.TabIndex = 31;
            this.lbPrecio.Text = "Precios";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(668, 379);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRinde);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPack);
            this.Controls.Add(this.tbRendimiento);
            this.Controls.Add(this.lbXPac);
            this.Controls.Add(this.tbPack);
            this.Controls.Add(this.tbUnidad);
            this.Controls.Add(this.lbPac);
            this.Controls.Add(this.lbUnid);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbProducto);
            this.Name = "Form2";
            this.Text = "Modificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.numPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbUnid;
        private System.Windows.Forms.Label lbPac;
        private System.Windows.Forms.TextBox tbUnidad;
        private System.Windows.Forms.TextBox tbPack;
        private System.Windows.Forms.TextBox tbRendimiento;
        private System.Windows.Forms.Label lbXPac;
        private System.Windows.Forms.NumericUpDown numPack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRinde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbPrecio;
    }
}