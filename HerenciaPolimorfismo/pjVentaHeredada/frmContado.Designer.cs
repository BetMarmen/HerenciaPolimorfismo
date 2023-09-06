namespace pjVentaHeredada
{
    partial class frmContado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.RESUMEN = new System.Windows.Forms.Label();
            this.lstrResumen = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENTA DE PRODUCTOS AL CREDITO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(720, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(258, 81);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(114, 27);
            this.txtRuc.TabIndex = 7;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(31, 81);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(114, 27);
            this.txtCliente.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(607, 86);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 20);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(469, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "RUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE O RAZÓN SOCIAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.btnAdquirir);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(42, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(720, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(295, 67);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(114, 27);
            this.txtCantidad.TabIndex = 4;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(26, 67);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(138, 28);
            this.cboProducto.TabIndex = 3;
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Location = new System.Drawing.Point(525, 43);
            this.btnAdquirir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(86, 31);
            this.btnAdquirir.TabIndex = 2;
            this.btnAdquirir.Text = "ADQUIRIR";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "CANTIDAD SOLICITADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "SELECCIONE UN PRODUCTO";
            // 
            // lvDetalle
            // 
            this.lvDetalle.Location = new System.Drawing.Point(42, 333);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(720, 97);
            this.lvDetalle.TabIndex = 4;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            // 
            // RESUMEN
            // 
            this.RESUMEN.AutoSize = true;
            this.RESUMEN.Location = new System.Drawing.Point(42, 448);
            this.RESUMEN.Name = "RESUMEN";
            this.RESUMEN.Size = new System.Drawing.Size(76, 20);
            this.RESUMEN.TabIndex = 5;
            this.RESUMEN.Text = "RESUMEN";
            // 
            // lstrResumen
            // 
            this.lstrResumen.FormattingEnabled = true;
            this.lstrResumen.ItemHeight = 20;
            this.lstrResumen.Location = new System.Drawing.Point(42, 471);
            this.lstrResumen.Name = "lstrResumen";
            this.lstrResumen.Size = new System.Drawing.Size(385, 124);
            this.lstrResumen.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(446, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "NETO A PAGAR";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonto.Location = new System.Drawing.Point(466, 520);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(60, 20);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "label10";
            // 
            // frmContado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstrResumen);
            this.Controls.Add(this.RESUMEN);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmContado";
            this.Text = "frmContado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtRuc;
        private TextBox txtCliente;
        private Label lblHora;
        private Label label6;
        private Label lblFecha;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtCantidad;
        private ComboBox cboProducto;
        private Button btnAdquirir;
        private Label label9;
        private Label label8;
        private ListView lvDetalle;
        private Label RESUMEN;
        private ListBox lstrResumen;
        private Label label7;
        private Label lblMonto;
    }
}