﻿namespace GestionEmpresa.VISTA.PedidoVistas
{
    partial class PedidoInsertarVista
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
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(565, 53);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 31;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 53);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 29;
            label1.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 125);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 32;
            label2.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(201, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(201, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 269);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 51;
            label4.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 197);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 50;
            label3.Text = "TOTAL";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(373, 359);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 57;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(201, 359);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 56;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PedidoInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 475);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PedidoInsertarVista";
            Text = "PedidoInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}