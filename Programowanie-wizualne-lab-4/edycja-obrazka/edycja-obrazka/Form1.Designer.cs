namespace edycja_obrazka
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
            pictureBoxMain = new PictureBox();
            btnLoad = new Button();
            openFileDialog1 = new OpenFileDialog();
            rdo90 = new RadioButton();
            rdo180 = new RadioButton();
            rdo270 = new RadioButton();
            btnRotate = new Button();
            btnInvert = new Button();
            btnUpsideDown = new Button();
            btnOnlyGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.Location = new Point(160, 20);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(620, 410);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMain.TabIndex = 0;
            pictureBoxMain.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 400);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 30);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // rdo90
            // 
            rdo90.AutoSize = true;
            rdo90.Location = new Point(12, 20);
            rdo90.Name = "rdo90";
            rdo90.Size = new Size(41, 24);
            rdo90.TabIndex = 2;
            rdo90.Text = "90°";
            rdo90.UseVisualStyleBackColor = true;
            // 
            // rdo180
            // 
            rdo180.AutoSize = true;
            rdo180.Location = new Point(12, 50);
            rdo180.Name = "rdo180";
            rdo180.Size = new Size(47, 24);
            rdo180.TabIndex = 3;
            rdo180.Text = "180°";
            rdo180.UseVisualStyleBackColor = true;
            // 
            // rdo270
            // 
            rdo270.AutoSize = true;
            rdo270.Location = new Point(12, 80);
            rdo270.Name = "rdo270";
            rdo270.Size = new Size(41, 24);
            rdo270.TabIndex = 4;
            rdo270.Text = "270°";
            rdo270.UseVisualStyleBackColor = true;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(12, 120);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(110, 30);
            btnRotate.TabIndex = 5;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.BackColor = Color.LightCoral;
            btnRotate.ForeColor = Color.White;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnInvert
            // 
            btnInvert.Location = new Point(12, 160);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(110, 30);
            btnInvert.TabIndex = 6;
            btnInvert.Text = "Invert Colors";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.BackColor = Color.LightBlue;
            btnInvert.ForeColor = Color.Black;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnUpsideDown
            // 
            btnUpsideDown.Location = new Point(12, 200);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(110, 30);
            btnUpsideDown.TabIndex = 7;
            btnUpsideDown.Text = "Upside Down";
            btnUpsideDown.UseVisualStyleBackColor = true;
            btnUpsideDown.BackColor = Color.LightBlue;
            btnUpsideDown.ForeColor = Color.Black;
            btnUpsideDown.Click += btnUpsideDown_Click;
            // 
            // btnOnlyGreen
            // 
            btnOnlyGreen.Location = new Point(12, 240);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(110, 30);
            btnOnlyGreen.TabIndex = 8;
            btnOnlyGreen.Text = "OnlyGreen";
            btnOnlyGreen.UseVisualStyleBackColor = true;
            btnOnlyGreen.BackColor = Color.LightGreen;
            btnOnlyGreen.ForeColor = Color.Black;
            btnOnlyGreen.Click += btnOnlyGreen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOnlyGreen);
            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvert);
            Controls.Add(btnRotate);
            Controls.Add(rdo270);
            Controls.Add(rdo180);
            Controls.Add(rdo90);
            Controls.Add(btnLoad);
            Controls.Add(pictureBoxMain);
            Name = "Form1";
            Text = "Edycja obrazka - baseline";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rdo90;
        private System.Windows.Forms.RadioButton rdo180;
        private System.Windows.Forms.RadioButton rdo270;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnUpsideDown;
        private System.Windows.Forms.Button btnOnlyGreen;

        #endregion
    }
}
