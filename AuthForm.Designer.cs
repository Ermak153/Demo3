namespace demo3_2
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainAuthLab = new System.Windows.Forms.Label();
            this.loginAuth = new System.Windows.Forms.Label();
            this.passwdAuthLab = new System.Windows.Forms.Label();
            this.loginAuthTxb = new System.Windows.Forms.TextBox();
            this.passwdAuthTxb = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainAuthLab
            // 
            this.mainAuthLab.AutoSize = true;
            this.mainAuthLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mainAuthLab.Location = new System.Drawing.Point(255, 9);
            this.mainAuthLab.Name = "mainAuthLab";
            this.mainAuthLab.Size = new System.Drawing.Size(321, 57);
            this.mainAuthLab.TabIndex = 0;
            this.mainAuthLab.Text = "Авторизация";
            // 
            // loginAuth
            // 
            this.loginAuth.AutoSize = true;
            this.loginAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginAuth.Location = new System.Drawing.Point(284, 116);
            this.loginAuth.Name = "loginAuth";
            this.loginAuth.Size = new System.Drawing.Size(68, 25);
            this.loginAuth.TabIndex = 1;
            this.loginAuth.Text = "Логин";
            // 
            // passwdAuthLab
            // 
            this.passwdAuthLab.AutoSize = true;
            this.passwdAuthLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwdAuthLab.Location = new System.Drawing.Point(284, 188);
            this.passwdAuthLab.Name = "passwdAuthLab";
            this.passwdAuthLab.Size = new System.Drawing.Size(80, 25);
            this.passwdAuthLab.TabIndex = 2;
            this.passwdAuthLab.Text = "Пароль";
            // 
            // loginAuthTxb
            // 
            this.loginAuthTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginAuthTxb.Location = new System.Drawing.Point(289, 144);
            this.loginAuthTxb.Name = "loginAuthTxb";
            this.loginAuthTxb.Size = new System.Drawing.Size(240, 29);
            this.loginAuthTxb.TabIndex = 3;
            // 
            // passwdAuthTxb
            // 
            this.passwdAuthTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwdAuthTxb.Location = new System.Drawing.Point(287, 216);
            this.passwdAuthTxb.Name = "passwdAuthTxb";
            this.passwdAuthTxb.Size = new System.Drawing.Size(240, 29);
            this.passwdAuthTxb.TabIndex = 4;
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AuthButton.Location = new System.Drawing.Point(359, 261);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(92, 44);
            this.AuthButton.TabIndex = 6;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.passwdAuthTxb);
            this.Controls.Add(this.loginAuthTxb);
            this.Controls.Add(this.passwdAuthLab);
            this.Controls.Add(this.loginAuth);
            this.Controls.Add(this.mainAuthLab);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainAuthLab;
        private System.Windows.Forms.Label loginAuth;
        private System.Windows.Forms.Label passwdAuthLab;
        private System.Windows.Forms.TextBox loginAuthTxb;
        private System.Windows.Forms.TextBox passwdAuthTxb;
        private System.Windows.Forms.Button AuthButton;
    }
}

