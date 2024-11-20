namespace AffaManagement
{
    partial class Signup
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
            name = new TextBox();
            label3 = new Label();
            email = new TextBox();
            label4 = new Label();
            password = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(175, 82);
            label1.Name = "label1";
            label1.Size = new Size(130, 41);
            label1.TabIndex = 1;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(35, 168);
            label2.Name = "label2";
            label2.Size = new Size(101, 41);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(35, 231);
            name.Name = "name";
            name.Size = new Size(411, 27);
            name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(35, 286);
            label3.Name = "label3";
            label3.Size = new Size(95, 41);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(35, 351);
            email.Name = "email";
            email.Size = new Size(411, 27);
            email.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(35, 416);
            label4.Name = "label4";
            label4.Size = new Size(150, 41);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(35, 479);
            password.Name = "password";
            password.Size = new Size(411, 27);
            password.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 553);
            button1.Name = "button1";
            button1.Size = new Size(164, 58);
            button1.TabIndex = 8;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(259, 553);
            button2.Name = "button2";
            button2.Size = new Size(164, 58);
            button2.TabIndex = 9;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 669);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(email);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private Label label3;
        private TextBox email;
        private Label label4;
        private TextBox password;
        private Button button1;
        private Button button2;
    }
}