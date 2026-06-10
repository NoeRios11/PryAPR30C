namespace PryAPR30C.cafeteria
{
    partial class FRMCafeteria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkImportada = new System.Windows.Forms.CheckBox();
            this.rbAlcoholica = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmTamaño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBebida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCaliente = new System.Windows.Forms.RadioButton();
            this.rbFria = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblPreparacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkImportada);
            this.groupBox1.Controls.Add(this.rbAlcoholica);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtExtra);
            this.groupBox1.Controls.Add(this.lblExtra);
            this.groupBox1.Controls.Add(this.cmTamaño);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBebida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbCaliente);
            this.groupBox1.Controls.Add(this.rbFria);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(512, 655);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAPTURA DE BEBIDAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkImportada
            // 
            this.chkImportada.AutoSize = true;
            this.chkImportada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkImportada.Location = new System.Drawing.Point(23, 564);
            this.chkImportada.Name = "chkImportada";
            this.chkImportada.Size = new System.Drawing.Size(428, 32);
            this.chkImportada.TabIndex = 12;
            this.chkImportada.Text = "¿Es de Procedencia Extranjera?";
            this.chkImportada.UseVisualStyleBackColor = true;
            // 
            // rbAlcoholica
            // 
            this.rbAlcoholica.AutoSize = true;
            this.rbAlcoholica.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlcoholica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAlcoholica.Location = new System.Drawing.Point(9, 113);
            this.rbAlcoholica.Name = "rbAlcoholica";
            this.rbAlcoholica.Size = new System.Drawing.Size(229, 30);
            this.rbAlcoholica.TabIndex = 11;
            this.rbAlcoholica.TabStop = true;
            this.rbAlcoholica.Text = "Bebida Alcholica";
            this.rbAlcoholica.UseVisualStyleBackColor = true;
            this.rbAlcoholica.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(75, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(8, 450);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(262, 36);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExtra.Location = new System.Drawing.Point(-5, 417);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(233, 28);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Cantidad de Hielo";
            this.lblExtra.Click += new System.EventHandler(this.lblExtra_Click);
            // 
            // cmTamaño
            // 
            this.cmTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTamaño.FormattingEnabled = true;
            this.cmTamaño.Items.AddRange(new object[] {
            "CHICO",
            "MEDIANO",
            "GRANDE"});
            this.cmTamaño.Location = new System.Drawing.Point(9, 357);
            this.cmTamaño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmTamaño.Name = "cmTamaño";
            this.cmTamaño.Size = new System.Drawing.Size(262, 36);
            this.cmTamaño.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamaño";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(8, 266);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(262, 36);
            this.txtPrecio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBebida
            // 
            this.txtBebida.Location = new System.Drawing.Point(8, 181);
            this.txtBebida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBebida.Name = "txtBebida";
            this.txtBebida.Size = new System.Drawing.Size(262, 36);
            this.txtBebida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la Bebida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbCaliente
            // 
            this.rbCaliente.AutoSize = true;
            this.rbCaliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCaliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbCaliente.Location = new System.Drawing.Point(9, 76);
            this.rbCaliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCaliente.Name = "rbCaliente";
            this.rbCaliente.Size = new System.Drawing.Size(232, 31);
            this.rbCaliente.TabIndex = 1;
            this.rbCaliente.TabStop = true;
            this.rbCaliente.Text = "Bebida Caliente";
            this.rbCaliente.UseVisualStyleBackColor = true;
            this.rbCaliente.CheckedChanged += new System.EventHandler(this.label2_Click);
            // 
            // rbFria
            // 
            this.rbFria.AutoSize = true;
            this.rbFria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbFria.Location = new System.Drawing.Point(9, 46);
            this.rbFria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFria.Name = "rbFria";
            this.rbFria.Size = new System.Drawing.Size(180, 31);
            this.rbFria.TabIndex = 0;
            this.rbFria.TabStop = true;
            this.rbFria.Text = "Bebida Fria";
            this.rbFria.UseVisualStyleBackColor = true;
            this.rbFria.CheckedChanged += new System.EventHandler(this.rbFria_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lblContador);
            this.groupBox2.Controls.Add(this.lblPreparacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(532, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 655);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA BEBIDAS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(3, 554);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 28);
            this.lblContador.TabIndex = 5;
            // 
            // lblPreparacion
            // 
            this.lblPreparacion.AutoSize = true;
            this.lblPreparacion.Location = new System.Drawing.Point(6, 506);
            this.lblPreparacion.Name = "lblPreparacion";
            this.lblPreparacion.Size = new System.Drawing.Size(0, 28);
            this.lblPreparacion.TabIndex = 4;
            this.lblPreparacion.Click += new System.EventHandler(this.lblPreparacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gray;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(16, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(683, 424);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "(SOLO APLICA EN BEBIDAS ALCOHOLICAS)";
            // 
            // FRMCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMCafeteria";
            this.Text = "FRMCafeteria";
            this.Load += new System.EventHandler(this.FRMCafeteria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCaliente;
        private System.Windows.Forms.TextBox txtBebida;
        private System.Windows.Forms.ComboBox cmTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbAlcoholica;
        private System.Windows.Forms.CheckBox chkImportada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPreparacion;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label5;
    }
}