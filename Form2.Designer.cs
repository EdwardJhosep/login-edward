namespace login
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(110, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 398);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "COMLETE TODOS LOS CAMPOS ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 101);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 152);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(313, 255);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 5;
            button1.Text = "REGSITRARSE ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(38, 336);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 6;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 207);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "CORREO";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 23);
            textBox3.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
    }
}