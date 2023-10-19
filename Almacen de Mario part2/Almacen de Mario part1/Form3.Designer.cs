namespace WindowsFormsApplication2
{
    partial class Form3
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
            this.lbstock = new System.Windows.Forms.Label();
            this.lbPStock = new System.Windows.Forms.Label();
            this.pbstock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbstock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstock.Location = new System.Drawing.Point(137, 28);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(173, 42);
            this.lbstock.TabIndex = 1;
            this.lbstock.Text = "Tienes menos \r\ndel 10% de stock de";
            // 
            // lbPStock
            // 
            this.lbPStock.AutoSize = true;
            this.lbPStock.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPStock.Location = new System.Drawing.Point(137, 81);
            this.lbPStock.Name = "lbPStock";
            this.lbPStock.Size = new System.Drawing.Size(17, 21);
            this.lbPStock.TabIndex = 2;
            this.lbPStock.Text = "-";
            // 
            // pbstock
            // 
            this.pbstock.Image = global::WindowsFormsApplication2.Properties.Resources.img_stock;
            this.pbstock.Location = new System.Drawing.Point(26, 28);
            this.pbstock.Name = "pbstock";
            this.pbstock.Size = new System.Drawing.Size(93, 100);
            this.pbstock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbstock.TabIndex = 0;
            this.pbstock.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 163);
            this.Controls.Add(this.lbPStock);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.pbstock);
            this.Name = "Form3";
            this.Text = "Poco Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pbstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbstock;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.Label lbPStock;
    }
}