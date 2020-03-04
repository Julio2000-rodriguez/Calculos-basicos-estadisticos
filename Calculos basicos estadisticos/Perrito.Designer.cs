namespace Calculos_basicos_estadisticos
{
    partial class Perrito
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
            this.cboCojo = new System.Windows.Forms.ComboBox();
            this.cboHecho = new System.Windows.Forms.ComboBox();
            this.cboHacer = new System.Windows.Forms.ComboBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCojo
            // 
            this.cboCojo.FormattingEnabled = true;
            this.cboCojo.Location = new System.Drawing.Point(12, 63);
            this.cboCojo.Name = "cboCojo";
            this.cboCojo.Size = new System.Drawing.Size(121, 21);
            this.cboCojo.TabIndex = 0;
            this.cboCojo.SelectedIndexChanged += new System.EventHandler(this.cboCojo_SelectedIndexChanged);
            // 
            // cboHecho
            // 
            this.cboHecho.FormattingEnabled = true;
            this.cboHecho.Location = new System.Drawing.Point(151, 111);
            this.cboHecho.Name = "cboHecho";
            this.cboHecho.Size = new System.Drawing.Size(121, 21);
            this.cboHecho.TabIndex = 1;
            // 
            // cboHacer
            // 
            this.cboHacer.FormattingEnabled = true;
            this.cboHacer.Location = new System.Drawing.Point(151, 199);
            this.cboHacer.Name = "cboHacer";
            this.cboHacer.Size = new System.Drawing.Size(121, 21);
            this.cboHacer.TabIndex = 2;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(172, 162);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 3;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(21, 126);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "Convertir ";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(37, 169);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese Cantidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conversores";
            // 
            // Perrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.cboHacer);
            this.Controls.Add(this.cboHecho);
            this.Controls.Add(this.cboCojo);
            this.Name = "Perrito";
            this.Text = "Perrito";
            this.Load += new System.EventHandler(this.Perrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCojo;
        private System.Windows.Forms.ComboBox cboHecho;
        private System.Windows.Forms.ComboBox cboHacer;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}