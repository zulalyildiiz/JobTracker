namespace JobTracker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            label2 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(37, 58);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.PaleTurquoise;
            button1.Location = new Point(464, 91);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 2;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(213, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ButtonFace;
            textBox2.Location = new Point(213, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 34);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(1575, 677);
            button3.Name = "button3";
            button3.Size = new Size(151, 38);
            button3.TabIndex = 6;
            button3.Text = "Kayıt Ol";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(1289, 686);
            label3.Name = "label3";
            label3.Size = new Size(234, 23);
            label3.TabIndex = 7;
            label3.Text = "Henüz kayıt olmadınız mı?";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.PaleTurquoise;
            button2.Location = new Point(598, 91);
            button2.Name = "button2";
            button2.Size = new Size(131, 54);
            button2.TabIndex = 9;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            radioButton1.ForeColor = SystemColors.HotTrack;
            radioButton1.Location = new Point(444, 179);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(171, 29);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yönetici Girişi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            radioButton2.ForeColor = SystemColors.HotTrack;
            radioButton2.Location = new Point(213, 179);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(177, 29);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Personel Girişi";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleTurquoise;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(195, 272);
            label5.Name = "label5";
            label5.Size = new Size(195, 23);
            label5.TabIndex = 13;
            label5.Text = "Kalan Giriş Hakkınız:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PaleTurquoise;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(396, 272);
            label6.Name = "label6";
            label6.Size = new Size(178, 23);
            label6.TabIndex = 14;
            label6.Text = "kalan deneme hakkı";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-32, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1110, 944);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.ForeColor = SystemColors.HotTrack;
            panel1.Location = new Point(1109, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 311);
            panel1.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.PaleTurquoise;
            button4.Location = new Point(464, 48);
            button4.Name = "button4";
            button4.Size = new Size(128, 32);
            button4.TabIndex = 17;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(126, 183);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 16;
            label2.Text = "Yetki:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PaleTurquoise;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(127, 120);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 15;
            label8.Text = "Şifre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.ForeColor = SystemColors.HotTrack;
            panel2.Location = new Point(1109, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 75);
            panel2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PaleTurquoise;
            label7.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(76, 10);
            label7.Name = "label7";
            label7.Size = new Size(619, 53);
            label7.TabIndex = 15;
            label7.Text = "Job Tracker App /  Üye Girişi";
            label7.Click += label7_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Label label3;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label2;
        private Label label8;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
        private Button button4;
    }
}
