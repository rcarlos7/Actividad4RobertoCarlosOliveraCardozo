﻿namespace GestionEmpresa.VISTA.ClienteVistas
{
    partial class ClienteEditarVista
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(433, 379);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 55;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(261, 379);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 54;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(261, 293);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(322, 27);
            textBox5.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(261, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 27);
            textBox4.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 116);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 43;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 57);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 42;
            label1.Text = "NOMBRE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 293);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 58;
            label6.Text = "DIRECCION";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 175);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 57;
            label7.Text = "CORREO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 234);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 56;
            label8.Text = "TELEFONO";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 471);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            Load += ClienteEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}