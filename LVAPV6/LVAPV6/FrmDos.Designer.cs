namespace LVAPV6
{
    partial class FrmDos
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
            this.lblformados = new System.Windows.Forms.Label();
            this.bttncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblformados
            // 
            this.lblformados.AutoSize = true;
            this.lblformados.Location = new System.Drawing.Point(184, 87);
            this.lblformados.Name = "lblformados";
            this.lblformados.Size = new System.Drawing.Size(75, 17);
            this.lblformados.TabIndex = 0;
            this.lblformados.Text = "Forma dos";
            // 
            // bttncerrar
            // 
            this.bttncerrar.Location = new System.Drawing.Point(625, 326);
            this.bttncerrar.Name = "bttncerrar";
            this.bttncerrar.Size = new System.Drawing.Size(75, 23);
            this.bttncerrar.TabIndex = 1;
            this.bttncerrar.Text = "Cerrar";
            this.bttncerrar.UseVisualStyleBackColor = true;
            this.bttncerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttncerrar);
            this.Controls.Add(this.lblformados);
            this.Name = "FrmDos";
            this.Text = "FrmDos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblformados;
        private System.Windows.Forms.Button bttncerrar;
    }
}