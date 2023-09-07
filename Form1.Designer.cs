namespace login
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 42);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(176, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 271);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "COMPLETE LOS CAMPOS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(266, 160);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 4;
            button1.Text = "ENTER ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 22);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 22);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 121);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 1;
            label3.Text = "CONTRASEÑA";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 69);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 0;
            label2.Text = "NOMBRE";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(43, 211);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 5;
            button2.Text = "CREAR USUARIO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button CREARUSUARIO;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
    }
}