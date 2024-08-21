namespace CPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_AltaPersona = new Button();
            name_text = new TextBox();
            apellido_text = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            nroDocumento_textBox2 = new TextBox();
            TipoDocumento_comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ciudad_comboBox = new ComboBox();
            label6 = new Label();
            email_textBox = new TextBox();
            label7 = new Label();
            Direccion_textBox = new TextBox();
            label8 = new Label();
            sector_comboBox = new ComboBox();
            btn_agregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btn_AltaPersona
            // 
            btn_AltaPersona.Location = new Point(1400, 718);
            btn_AltaPersona.Name = "btn_AltaPersona";
            btn_AltaPersona.Size = new Size(150, 46);
            btn_AltaPersona.TabIndex = 1;
            btn_AltaPersona.Text = "Dar de Alta";
            btn_AltaPersona.UseVisualStyleBackColor = true;
            // 
            // name_text
            // 
            name_text.Location = new Point(140, 20);
            name_text.Name = "name_text";
            name_text.Size = new Size(200, 39);
            name_text.TabIndex = 2;
            // 
            // apellido_text
            // 
            apellido_text.AutoSize = true;
            apellido_text.Location = new Point(23, 94);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(102, 32);
            apellido_text.TabIndex = 3;
            apellido_text.Text = "Apellido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 159);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 5;
            label2.Text = "Tipo_Doc";
            // 
            // nroDocumento_textBox2
            // 
            nroDocumento_textBox2.Location = new Point(169, 240);
            nroDocumento_textBox2.Name = "nroDocumento_textBox2";
            nroDocumento_textBox2.Size = new Size(200, 39);
            nroDocumento_textBox2.TabIndex = 6;
            // 
            // TipoDocumento_comboBox1
            // 
            TipoDocumento_comboBox1.FormattingEnabled = true;
            TipoDocumento_comboBox1.Location = new Point(140, 156);
            TipoDocumento_comboBox1.Name = "TipoDocumento_comboBox1";
            TipoDocumento_comboBox1.Size = new Size(242, 40);
            TipoDocumento_comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 232);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 8;
            label3.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 264);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 9;
            label4.Text = "Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 328);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 10;
            label5.Text = "Ciudad";
            // 
            // ciudad_comboBox
            // 
            ciudad_comboBox.FormattingEnabled = true;
            ciudad_comboBox.Location = new Point(140, 320);
            ciudad_comboBox.Name = "ciudad_comboBox";
            ciudad_comboBox.Size = new Size(242, 40);
            ciudad_comboBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 393);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(140, 393);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(200, 39);
            email_textBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 454);
            label7.Name = "label7";
            label7.Size = new Size(114, 32);
            label7.TabIndex = 14;
            label7.Text = "Direccion";
            // 
            // Direccion_textBox
            // 
            Direccion_textBox.Location = new Point(140, 451);
            Direccion_textBox.Name = "Direccion_textBox";
            Direccion_textBox.Size = new Size(200, 39);
            Direccion_textBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(611, 27);
            label8.Name = "label8";
            label8.Size = new Size(81, 32);
            label8.TabIndex = 16;
            label8.Text = "Sector";
            // 
            // sector_comboBox
            // 
            sector_comboBox.FormattingEnabled = true;
            sector_comboBox.Location = new Point(698, 20);
            sector_comboBox.Name = "sector_comboBox";
            sector_comboBox.Size = new Size(242, 40);
            sector_comboBox.TabIndex = 17;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(611, 94);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(245, 46);
            btn_agregar.TabIndex = 18;
            btn_agregar.Text = "Agregar Empleado";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 794);
            Controls.Add(btn_agregar);
            Controls.Add(sector_comboBox);
            Controls.Add(label8);
            Controls.Add(Direccion_textBox);
            Controls.Add(label7);
            Controls.Add(email_textBox);
            Controls.Add(label6);
            Controls.Add(ciudad_comboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TipoDocumento_comboBox1);
            Controls.Add(nroDocumento_textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(apellido_text);
            Controls.Add(name_text);
            Controls.Add(btn_AltaPersona);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_AltaPersona;
        private TextBox name_text;
        private Label apellido_text;
        private TextBox textBox1;
        private Label label2;
        private TextBox nroDocumento_textBox2;
        private ComboBox TipoDocumento_comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox ciudad_comboBox;
        private Label label6;
        private TextBox email_textBox;
        private Label label7;
        private TextBox Direccion_textBox;
        private Label label8;
        private ComboBox sector_comboBox;
        private Button btn_agregar;
    }
}
