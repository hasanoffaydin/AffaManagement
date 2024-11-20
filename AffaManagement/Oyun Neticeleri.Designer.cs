namespace AffaManagement
{
    partial class Oyun_Neticeleri
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            komanda1Score = new TextBox();
            komanda2Score = new TextBox();
            neticeElaveEt = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(278, 44);
            label1.Name = "label1";
            label1.Size = new Size(238, 41);
            label1.TabIndex = 3;
            label1.Text = "Oyun Neticeleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(37, 120);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 4;
            label2.Text = "Oyunlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(37, 204);
            label3.Name = "label3";
            label3.Size = new Size(176, 41);
            label3.TabIndex = 5;
            label3.Text = "Komanda 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(451, 204);
            label4.Name = "label4";
            label4.Size = new Size(176, 41);
            label4.TabIndex = 6;
            label4.Text = "Komanda 2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(385, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // komanda1Score
            // 
            komanda1Score.Location = new Point(120, 320);
            komanda1Score.Name = "komanda1Score";
            komanda1Score.Size = new Size(165, 27);
            komanda1Score.TabIndex = 10;
            // 
            // komanda2Score
            // 
            komanda2Score.Location = new Point(451, 320);
            komanda2Score.Name = "komanda2Score";
            komanda2Score.Size = new Size(165, 27);
            komanda2Score.TabIndex = 11;
            // 
            // neticeElaveEt
            // 
            neticeElaveEt.BackColor = Color.Green;
            neticeElaveEt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            neticeElaveEt.ForeColor = Color.White;
            neticeElaveEt.Location = new Point(315, 371);
            neticeElaveEt.Name = "neticeElaveEt";
            neticeElaveEt.Size = new Size(300, 58);
            neticeElaveEt.TabIndex = 19;
            neticeElaveEt.Text = "Netice Elave Et";
            neticeElaveEt.UseVisualStyleBackColor = false;
            neticeElaveEt.Click += neticeElaveEt_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(624, 371);
            button1.Name = "button1";
            button1.Size = new Size(164, 58);
            button1.TabIndex = 20;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(451, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 22;
            // 
            // Oyun_Neticeleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(neticeElaveEt);
            Controls.Add(komanda2Score);
            Controls.Add(komanda1Score);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Oyun_Neticeleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oyun_Neticeleri";
            Load += Oyun_Neticeleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox komanda1Score;
        private TextBox komanda2Score;
        private Button neticeElaveEt;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}