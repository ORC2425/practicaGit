﻿namespace EjercicioTelegrama
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.lvlTexto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbOrdinario = new System.Windows.Forms.RadioButton();
            this.cbUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(218, 336);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(166, 107);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(413, 144);
            this.txtTelegrama.TabIndex = 2;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(165, 339);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(37, 13);
            this.lblCoste.TabIndex = 3;
            this.lblCoste.Text = "Coste:";
            // 
            // lvlTexto
            // 
            this.lvlTexto.AutoSize = true;
            this.lvlTexto.Location = new System.Drawing.Point(163, 75);
            this.lvlTexto.Name = "lvlTexto";
            this.lvlTexto.Size = new System.Drawing.Size(37, 13);
            this.lvlTexto.TabIndex = 4;
            this.lvlTexto.Text = "Texto:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(487, 319);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(176, 54);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbOrdinario
            // 
            this.cbOrdinario.AutoSize = true;
            this.cbOrdinario.Checked = true;
            this.cbOrdinario.Location = new System.Drawing.Point(161, 287);
            this.cbOrdinario.Name = "cbOrdinario";
            this.cbOrdinario.Size = new System.Drawing.Size(67, 17);
            this.cbOrdinario.TabIndex = 6;
            this.cbOrdinario.TabStop = true;
            this.cbOrdinario.Text = "Ordinario";
            this.cbOrdinario.UseVisualStyleBackColor = true;
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(234, 287);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(63, 17);
            this.cbUrgente.TabIndex = 7;
            this.cbUrgente.Text = "Urgente";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUrgente);
            this.Controls.Add(this.cbOrdinario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lvlTexto);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.txtPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Label lvlTexto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton cbOrdinario;
        private System.Windows.Forms.RadioButton cbUrgente;
    }
}

