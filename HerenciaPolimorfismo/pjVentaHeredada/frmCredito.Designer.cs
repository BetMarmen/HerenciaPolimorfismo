namespace pjVentaHeredada
{
    partial class frmCredito
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvResunen = new System.Windows.Forms.ListView();
            this.btnResumen = new System.Windows.Forms.Button();
            this.cboLetras = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 30);
            this.label1.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(24, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(720, 133);
            this.groupBox1.TabIndex = 1;
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
            this.lblHora.Location = new System.Drawing.Point(607, 85);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 20);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(469, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "RUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
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
            this.groupBox2.Location = new System.Drawing.Point(29, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(715, 133);
            this.groupBox2.TabIndex = 2;
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
            this.label9.Location = new System.Drawing.Point(295, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "CANTIDAD SOLICITADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "SELECCIONE UN PRODUCTO";
            // 
            // lvDetalle
            // 
            this.lvDetalle.Location = new System.Drawing.Point(29, 379);
            this.lvDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(715, 128);
            this.lvDetalle.TabIndex = 3;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvResunen);
            this.groupBox3.Controls.Add(this.btnResumen);
            this.groupBox3.Controls.Add(this.cboLetras);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(29, 532);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(507, 175);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPCIONES DEL CRÉDITO";
            // 
            // lvResunen
            // 
            this.lvResunen.Location = new System.Drawing.Point(253, 20);
            this.lvResunen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvResunen.Name = "lvResunen";
            this.lvResunen.Size = new System.Drawing.Size(247, 128);
            this.lvResunen.TabIndex = 3;
            this.lvResunen.UseCompatibleStateImageBehavior = false;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(16, 97);
            this.btnResumen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(86, 31);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "MOSTRAR RESUMEN";
            this.btnResumen.UseVisualStyleBackColor = true;
            // 
            // cboLetras
            // 
            this.cboLetras.FormattingEnabled = true;
            this.cboLetras.Location = new System.Drawing.Point(16, 59);
            this.cboLetras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLetras.Name = "cboLetras";
            this.cboLetras.Size = new System.Drawing.Size(138, 28);
            this.cboLetras.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "SELECCIONE LETRAS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(569, 552);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "MONTO A PAGAR";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(569, 601);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(58, 20);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "label12";
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 716);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCredito";
            this.Text = "frmCredito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private GroupBox groupBox3;
        private ListView lvResunen;
        private Button btnResumen;
        private ComboBox cboLetras;
        private Label label10;
        private Label label11;
        private Label lblMonto;
    }
}