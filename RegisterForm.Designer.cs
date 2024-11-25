namespace demo3_2
{
    partial class RegisterForm
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
            this.mainRegLab = new System.Windows.Forms.Label();
            this.loginRegTxb = new System.Windows.Forms.TextBox();
            this.passwordRegTxb = new System.Windows.Forms.TextBox();
            this.loginReg = new System.Windows.Forms.Label();
            this.passwordReg = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.authLink = new System.Windows.Forms.LinkLabel();
            this.phoneRegLab = new System.Windows.Forms.Label();
            this.adressRegLab = new System.Windows.Forms.Label();
            this.nameRegLab = new System.Windows.Forms.Label();
            this.phoneRegTxb = new System.Windows.Forms.TextBox();
            this.adressRegTxb = new System.Windows.Forms.TextBox();
            this.nameRegTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainRegLab
            // 
            this.mainRegLab.AutoSize = true;
            this.mainRegLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mainRegLab.Location = new System.Drawing.Point(227, 4);
            this.mainRegLab.Name = "mainRegLab";
            this.mainRegLab.Size = new System.Drawing.Size(314, 57);
            this.mainRegLab.TabIndex = 0;
            this.mainRegLab.Text = "Регистрация";
            // 
            // loginRegTxb
            // 
            this.loginRegTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginRegTxb.Location = new System.Drawing.Point(281, 154);
            this.loginRegTxb.Name = "loginRegTxb";
            this.loginRegTxb.Size = new System.Drawing.Size(223, 29);
            this.loginRegTxb.TabIndex = 1;
            // 
            // passwordRegTxb
            // 
            this.passwordRegTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordRegTxb.Location = new System.Drawing.Point(285, 214);
            this.passwordRegTxb.Name = "passwordRegTxb";
            this.passwordRegTxb.Size = new System.Drawing.Size(223, 29);
            this.passwordRegTxb.TabIndex = 2;
            // 
            // loginReg
            // 
            this.loginReg.AutoSize = true;
            this.loginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginReg.Location = new System.Drawing.Point(280, 126);
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(68, 25);
            this.loginReg.TabIndex = 3;
            this.loginReg.Text = "Логин";
            // 
            // passwordReg
            // 
            this.passwordReg.AutoSize = true;
            this.passwordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordReg.Location = new System.Drawing.Point(280, 186);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.Size = new System.Drawing.Size(80, 25);
            this.passwordReg.TabIndex = 4;
            this.passwordReg.Text = "Пароль";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registerButton.Location = new System.Drawing.Point(289, 379);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(216, 36);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // authLink
            // 
            this.authLink.AutoSize = true;
            this.authLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.authLink.Location = new System.Drawing.Point(335, 421);
            this.authLink.Name = "authLink";
            this.authLink.Size = new System.Drawing.Size(109, 20);
            this.authLink.TabIndex = 6;
            this.authLink.TabStop = true;
            this.authLink.Text = "Авторизация";
            this.authLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authLink_LinkClicked);
            // 
            // phoneRegLab
            // 
            this.phoneRegLab.AutoSize = true;
            this.phoneRegLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneRegLab.Location = new System.Drawing.Point(280, 246);
            this.phoneRegLab.Name = "phoneRegLab";
            this.phoneRegLab.Size = new System.Drawing.Size(177, 25);
            this.phoneRegLab.TabIndex = 7;
            this.phoneRegLab.Text = "Номер телефона";
            // 
            // adressRegLab
            // 
            this.adressRegLab.AutoSize = true;
            this.adressRegLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adressRegLab.Location = new System.Drawing.Point(284, 306);
            this.adressRegLab.Name = "adressRegLab";
            this.adressRegLab.Size = new System.Drawing.Size(160, 25);
            this.adressRegLab.TabIndex = 8;
            this.adressRegLab.Text = "Адрес доставки";
            // 
            // nameRegLab
            // 
            this.nameRegLab.AutoSize = true;
            this.nameRegLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameRegLab.Location = new System.Drawing.Point(280, 66);
            this.nameRegLab.Name = "nameRegLab";
            this.nameRegLab.Size = new System.Drawing.Size(54, 25);
            this.nameRegLab.TabIndex = 9;
            this.nameRegLab.Text = "Имя";
            // 
            // phoneRegTxb
            // 
            this.phoneRegTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneRegTxb.Location = new System.Drawing.Point(285, 274);
            this.phoneRegTxb.Name = "phoneRegTxb";
            this.phoneRegTxb.Size = new System.Drawing.Size(223, 29);
            this.phoneRegTxb.TabIndex = 10;
            // 
            // adressRegTxb
            // 
            this.adressRegTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adressRegTxb.Location = new System.Drawing.Point(289, 334);
            this.adressRegTxb.Name = "adressRegTxb";
            this.adressRegTxb.Size = new System.Drawing.Size(219, 29);
            this.adressRegTxb.TabIndex = 11;
            // 
            // nameRegTxb
            // 
            this.nameRegTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameRegTxb.Location = new System.Drawing.Point(281, 94);
            this.nameRegTxb.Name = "nameRegTxb";
            this.nameRegTxb.Size = new System.Drawing.Size(223, 29);
            this.nameRegTxb.TabIndex = 12;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameRegTxb);
            this.Controls.Add(this.adressRegTxb);
            this.Controls.Add(this.phoneRegTxb);
            this.Controls.Add(this.nameRegLab);
            this.Controls.Add(this.adressRegLab);
            this.Controls.Add(this.phoneRegLab);
            this.Controls.Add(this.authLink);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordReg);
            this.Controls.Add(this.loginReg);
            this.Controls.Add(this.passwordRegTxb);
            this.Controls.Add(this.loginRegTxb);
            this.Controls.Add(this.mainRegLab);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainRegLab;
        private System.Windows.Forms.TextBox nameRegTxb;
        private System.Windows.Forms.TextBox loginRegTxb;
        private System.Windows.Forms.TextBox passwordRegTxb;
        private System.Windows.Forms.Label loginReg;
        private System.Windows.Forms.Label passwordReg;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.LinkLabel authLink;
        private System.Windows.Forms.Label phoneRegLab;
        private System.Windows.Forms.Label adressRegLab;
        private System.Windows.Forms.Label nameRegLab;
        private System.Windows.Forms.TextBox phoneRegTxb;
        private System.Windows.Forms.TextBox adressRegTxb;
    }
}