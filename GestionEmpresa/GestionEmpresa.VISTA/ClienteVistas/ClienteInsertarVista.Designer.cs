﻿namespace GestionEmpresa.VISTA.ClienteVistas
{
    partial class ClienteInsertarVista
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(404, 418);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 55;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(232, 418);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 54;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(229, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(322, 27);
            textBox5.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(229, 235);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 27);
            textBox4.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 298);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 46;
            label5.Text = "DIRECCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 178);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 45;
            label4.Text = "CORREO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 242);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 44;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 118);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 43;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 58);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 42;
            label1.Text = "NOMBRE";
            // 
            // ClienteInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 528);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteInsertarVista";
            Text = "ClienteInsertarVista";
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}