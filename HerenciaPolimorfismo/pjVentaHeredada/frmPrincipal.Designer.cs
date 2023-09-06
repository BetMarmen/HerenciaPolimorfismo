namespace pjVentaHeredada
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnContado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta De Productos";
            // 
            // btnCredito
            // 
            this.btnCredito.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCredito.Location = new System.Drawing.Point(106, 115);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(194, 42);
            this.btnCredito.TabIndex = 1;
            this.btnCredito.Text = "Venta Al Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnContado
            // 
            this.btnContado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContado.Location = new System.Drawing.Point(435, 115);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(199, 42);
            this.btnContado.TabIndex = 2;
            this.btnContado.Text = "Venta Al Contado";
            this.btnContado.UseVisualStyleBackColor = true;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 261);
            this.Controls.Add(this.btnContado);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCredito;
        private Button btnContado;
    }
}