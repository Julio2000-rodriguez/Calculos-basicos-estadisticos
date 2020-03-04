namespace Calculos_basicos_estadisticos
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
            this.lblserie = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(21, 46);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(39, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(21, 106);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(78, 39);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(12, 152);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnMediaAritmetica.TabIndex = 3;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(93, 152);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(121, 23);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar ";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTipica
            // 
            this.btnCalcularTipica.Location = new System.Drawing.Point(233, 152);
            this.btnCalcularTipica.Name = "btnCalcularTipica";
            this.btnCalcularTipica.Size = new System.Drawing.Size(121, 23);
            this.btnCalcularTipica.TabIndex = 5;
            this.btnCalcularTipica.Text = "Calcular Tipica ";
            this.btnCalcularTipica.UseVisualStyleBackColor = true;
            this.btnCalcularTipica.Click += new System.EventHandler(this.btnCalcularTipica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(567, 430);
            this.Controls.Add(this.btnCalcularTipica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTipica;
    }
}

