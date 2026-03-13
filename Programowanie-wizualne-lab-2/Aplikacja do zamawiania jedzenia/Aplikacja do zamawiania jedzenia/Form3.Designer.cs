namespace Aplikacja_do_zamawiania_jedzenia
{
    partial class Form3
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(52, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(209, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Ekspresowa dostawa (15zł)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(52, 110);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(204, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Sztućce jednorazowe (2zł)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(52, 140);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(231, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Opakowanie ekologiczne (3zł)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(52, 170);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(199, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Powiadomienie SMS (0zł)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 4;
            label1.Text = "Opcje dostawy";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(52, 222);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "zatwierdź";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 317);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
        private Button button1;
    }
}