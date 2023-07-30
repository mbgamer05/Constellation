namespace Constellation
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSend = new Button();
            btnLogin = new Button();
            lblHello = new Label();
            lblHelloSplash = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(76, 195);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(168, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            txtUsername.Click += TextSelected;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(76, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            txtPassword.Click += TextSelected;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(76, 265);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Tag = "Secondary";
            btnSend.Text = "Signup";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Location = new Point(169, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Tag = "Primary";
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHello.Location = new Point(76, 9);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(58, 28);
            lblHello.TabIndex = 6;
            lblHello.Text = "Hello";
            // 
            // lblHelloSplash
            // 
            lblHelloSplash.AutoSize = true;
            lblHelloSplash.Location = new Point(76, 37);
            lblHelloSplash.Name = "lblHelloSplash";
            lblHelloSplash.Size = new Size(41, 15);
            lblHelloSplash.TabIndex = 7;
            lblHelloSplash.Text = "Splash";
            lblHelloSplash.Click += lblHelloSplash_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(lblHelloSplash);
            Controls.Add(lblHello);
            Controls.Add(btnLogin);
            Controls.Add(btnSend);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSend;
        private Button btnLogin;
        private Label lblHello;
        private Label lblHelloSplash;
    }
}