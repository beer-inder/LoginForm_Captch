namespace LoginForm
{
    partial class LoginForm
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_captcha = new System.Windows.Forms.TextBox();
            this.tb_Privacy = new System.Windows.Forms.TextBox();
            this.lbl_Privacy = new System.Windows.Forms.Label();
            this.cb_Privacy = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(160, 60);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(113, 25);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "UserName";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(160, 116);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 25);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(343, 378);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(188, 60);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseHover += new System.EventHandler(this.btn_Login_MouseHover);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(594, 377);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(150, 61);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(333, 64);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(218, 22);
            this.txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(333, 120);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(218, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(126, 377);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 61);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(171, 198);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 16);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Captcha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_captcha
            // 
            this.txt_captcha.Location = new System.Drawing.Point(333, 198);
            this.txt_captcha.Name = "txt_captcha";
            this.txt_captcha.Size = new System.Drawing.Size(100, 22);
            this.txt_captcha.TabIndex = 10;
            this.txt_captcha.TextChanged += new System.EventHandler(this.txt_captcha_TextChanged);
            // 
            // tb_Privacy
            // 
            this.tb_Privacy.Location = new System.Drawing.Point(333, 246);
            this.tb_Privacy.Multiline = true;
            this.tb_Privacy.Name = "tb_Privacy";
            this.tb_Privacy.Size = new System.Drawing.Size(249, 72);
            this.tb_Privacy.TabIndex = 11;
            // 
            // lbl_Privacy
            // 
            this.lbl_Privacy.AutoSize = true;
            this.lbl_Privacy.Location = new System.Drawing.Point(171, 271);
            this.lbl_Privacy.Name = "lbl_Privacy";
            this.lbl_Privacy.Size = new System.Drawing.Size(92, 16);
            this.lbl_Privacy.TabIndex = 12;
            this.lbl_Privacy.Text = "Privacy Policy";
            // 
            // cb_Privacy
            // 
            this.cb_Privacy.AutoSize = true;
            this.cb_Privacy.Location = new System.Drawing.Point(171, 338);
            this.cb_Privacy.Name = "cb_Privacy";
            this.cb_Privacy.Size = new System.Drawing.Size(18, 17);
            this.cb_Privacy.TabIndex = 13;
            this.cb_Privacy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(330, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "I accept the Privacy Policy";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 378);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 51);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Privacy);
            this.Controls.Add(this.lbl_Privacy);
            this.Controls.Add(this.tb_Privacy);
            this.Controls.Add(this.txt_captcha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_captcha;
        private System.Windows.Forms.TextBox tb_Privacy;
        private System.Windows.Forms.Label lbl_Privacy;
        private System.Windows.Forms.CheckBox cb_Privacy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
    }
}