namespace GestionEmpresa.VISTA.PedidoVistas
{
    partial class PedidoEditarVista
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(470, 355);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 67;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(298, 355);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 66;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 65;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 265);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 63;
            label4.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 193);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 62;
            label3.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(298, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 27);
            dateTimePicker1.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 121);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 60;
            label2.Text = "FECHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 58;
            label1.Text = "CLIENTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 49);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 68;
            label5.Text = "CLIENTE";
            // 
            // PedidoEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PedidoEditarVista";
            Text = "PedidoEditarVista";
            Load += PedidoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}