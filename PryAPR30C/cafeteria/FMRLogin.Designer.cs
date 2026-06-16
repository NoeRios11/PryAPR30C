namespace PryAPR30C.cafeteria
{
    partial class FMRLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1usuario = new System.Windows.Forms.TextBox();
            this.textBox2password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4LEYENDA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE RIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // textBox1usuario
            // 
            this.textBox1usuario.CausesValidation = false;
            this.textBox1usuario.Location = new System.Drawing.Point(48, 175);
            this.textBox1usuario.Name = "textBox1usuario";
            this.textBox1usuario.Size = new System.Drawing.Size(335, 26);
            this.textBox1usuario.TabIndex = 3;
            this.textBox1usuario.Enter += new System.EventHandler(this.textBox1usuario_Enter);
            // 
            // textBox2password
            // 
            this.textBox2password.Location = new System.Drawing.Point(48, 321);
            this.textBox2password.Name = "textBox2password";
            this.textBox2password.PasswordChar = '*';
            this.textBox2password.Size = new System.Drawing.Size(335, 26);
            this.textBox2password.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4LEYENDA
            // 
            this.label4LEYENDA.AutoSize = true;
            this.label4LEYENDA.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4LEYENDA.Location = new System.Drawing.Point(119, 476);
            this.label4LEYENDA.Name = "label4LEYENDA";
            this.label4LEYENDA.Size = new System.Drawing.Size(16, 24);
            this.label4LEYENDA.TabIndex = 6;
            this.label4LEYENDA.Text = ".";
            this.label4LEYENDA.Visible = false;
            // 
            // FMRLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 560);
            this.Controls.Add(this.label4LEYENDA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2password);
            this.Controls.Add(this.textBox1usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRLogin";
            this.Text = "FMRLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1usuario;
        private System.Windows.Forms.TextBox textBox2password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4LEYENDA;
    }
}