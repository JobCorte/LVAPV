namespace LVAPV6
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
            this.lblformauno = new System.Windows.Forms.Label();
            this.bttnllamardos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblformauno
            // 
            this.lblformauno.AutoSize = true;
            this.lblformauno.Location = new System.Drawing.Point(39, 40);
            this.lblformauno.Name = "lblformauno";
            this.lblformauno.Size = new System.Drawing.Size(76, 17);
            this.lblformauno.TabIndex = 0;
            this.lblformauno.Text = "Forma uno";
            // 
            // bttnllamardos
            // 
            this.bttnllamardos.Location = new System.Drawing.Point(12, 172);
            this.bttnllamardos.Name = "bttnllamardos";
            this.bttnllamardos.Size = new System.Drawing.Size(201, 23);
            this.bttnllamardos.TabIndex = 1;
            this.bttnllamardos.Text = "Llamar forma dos";
            this.bttnllamardos.UseVisualStyleBackColor = true;
            this.bttnllamardos.Click += new System.EventHandler(this.bttnllamardos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnllamardos);
            this.Controls.Add(this.lblformauno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblformauno;
        private System.Windows.Forms.Button bttnllamardos;
    }
}

