﻿namespace WindowsFormsApp1
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.FVB1Y = new System.Windows.Forms.Label();
            this.fvby = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbReintegro = new System.Windows.Forms.RadioButton();
            this.btOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(268, 48);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(274, 44);
            this.txtSaldo.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(327, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(274, 44);
            this.txtCantidad.TabIndex = 1;
            // 
            // FVB1Y
            // 
            this.FVB1Y.AutoSize = true;
            this.FVB1Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FVB1Y.Location = new System.Drawing.Point(25, 55);
            this.FVB1Y.Name = "FVB1Y";
            this.FVB1Y.Size = new System.Drawing.Size(237, 37);
            this.FVB1Y.TabIndex = 2;
            this.FVB1Y.Text = "Saldo FVB 1-Y:";
            // 
            // fvby
            // 
            this.fvby.AutoSize = true;
            this.fvby.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fvby.Location = new System.Drawing.Point(25, 145);
            this.fvby.Name = "fvby";
            this.fvby.Size = new System.Drawing.Size(284, 37);
            this.fvby.TabIndex = 3;
            this.fvby.Text = "Cantidad FVB 1-Y:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(79, 229);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 41);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ingreso";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbReintegro
            // 
            this.rbReintegro.AutoSize = true;
            this.rbReintegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReintegro.Location = new System.Drawing.Point(261, 229);
            this.rbReintegro.Name = "rbReintegro";
            this.rbReintegro.Size = new System.Drawing.Size(172, 41);
            this.rbReintegro.TabIndex = 5;
            this.rbReintegro.TabStop = true;
            this.rbReintegro.Text = "Reintegro";
            this.rbReintegro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbReintegro.UseVisualStyleBackColor = true;
            // 
            // btOperar
            // 
            this.btOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOperar.Location = new System.Drawing.Point(554, 55);
            this.btOperar.Name = "btOperar";
            this.btOperar.Size = new System.Drawing.Size(183, 73);
            this.btOperar.TabIndex = 6;
            this.btOperar.Text = "Realizar Operación";
            this.btOperar.UseVisualStyleBackColor = true;
            this.btOperar.Click += new System.EventHandler(this.btOperar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 324);
            this.Controls.Add(this.btOperar);
            this.Controls.Add(this.rbReintegro);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.fvby);
            this.Controls.Add(this.FVB1Y);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtSaldo);
            this.Name = "Form1";
            this.Text = "La Banca Siempre Gana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label FVB1Y;
        private System.Windows.Forms.Label fvby;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbReintegro;
        private System.Windows.Forms.Button btOperar;
    }
}

