
using System.Windows.Forms;

namespace Client.View
{
    partial class EntranceGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceGame));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.confirmPLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegLabel = new System.Windows.Forms.Label();
            this.loginRegTextBox = new System.Windows.Forms.TextBox();
            this.loginRegLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.loginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.loginPage);
            this.tabControl.Controls.Add(this.register);
            this.tabControl.Location = new System.Drawing.Point(-5, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(655, 323);
            this.tabControl.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.Transparent;
            this.loginPage.Controls.Add(this.pictureBox1);
            this.loginPage.Controls.Add(this.cancelButton);
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Controls.Add(this.passwordTextBox);
            this.loginPage.Controls.Add(this.passwordLabel);
            this.loginPage.Controls.Add(this.loginTextBox);
            this.loginPage.Controls.Add(this.nameLabel);
            this.loginPage.Location = new System.Drawing.Point(4, 25);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(647, 294);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Вход";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(333, 215);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(215, 215);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(86, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(196, 178);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(245, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(117, 178);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(196, 128);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(245, 22);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.Text = "ваш логин";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(127, 128);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Логин";
            // 
            // register
            // 
            this.register.Controls.Add(this.pictureBox2);
            this.register.Controls.Add(this.confirmTextBox);
            this.register.Controls.Add(this.confirmPLabel);
            this.register.Controls.Add(this.button1);
            this.register.Controls.Add(this.registerButton);
            this.register.Controls.Add(this.passwordRegTextBox);
            this.register.Controls.Add(this.passwordRegLabel);
            this.register.Controls.Add(this.loginRegTextBox);
            this.register.Controls.Add(this.loginRegLabel);
            this.register.Location = new System.Drawing.Point(4, 25);
            this.register.Name = "register";
            this.register.Padding = new System.Windows.Forms.Padding(3);
            this.register.Size = new System.Drawing.Size(617, 294);
            this.register.TabIndex = 1;
            this.register.Text = "Регистрация";
            this.register.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(142, 184);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.PasswordChar = '*';
            this.confirmTextBox.Size = new System.Drawing.Size(405, 22);
            this.confirmTextBox.TabIndex = 11;
            // 
            // confirmPLabel
            // 
            this.confirmPLabel.AutoSize = true;
            this.confirmPLabel.Location = new System.Drawing.Point(23, 184);
            this.confirmPLabel.Name = "confirmPLabel";
            this.confirmPLabel.Size = new System.Drawing.Size(113, 17);
            this.confirmPLabel.TabIndex = 12;
            this.confirmPLabel.Text = "Подтверждение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(178, 228);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 25);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(142, 146);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.PasswordChar = '*';
            this.passwordRegTextBox.Size = new System.Drawing.Size(405, 22);
            this.passwordRegTextBox.TabIndex = 9;
            // 
            // passwordRegLabel
            // 
            this.passwordRegLabel.AutoSize = true;
            this.passwordRegLabel.Location = new System.Drawing.Point(79, 146);
            this.passwordRegLabel.Name = "passwordRegLabel";
            this.passwordRegLabel.Size = new System.Drawing.Size(57, 17);
            this.passwordRegLabel.TabIndex = 8;
            this.passwordRegLabel.Text = "Пароль";
            // 
            // loginRegTextBox
            // 
            this.loginRegTextBox.Location = new System.Drawing.Point(142, 107);
            this.loginRegTextBox.Name = "loginRegTextBox";
            this.loginRegTextBox.Size = new System.Drawing.Size(405, 22);
            this.loginRegTextBox.TabIndex = 7;
            // 
            // loginRegLabel
            // 
            this.loginRegLabel.AutoSize = true;
            this.loginRegLabel.Location = new System.Drawing.Point(89, 107);
            this.loginRegLabel.Name = "loginRegLabel";
            this.loginRegLabel.Size = new System.Drawing.Size(47, 17);
            this.loginRegLabel.TabIndex = 6;
            this.loginRegLabel.Text = "Логин";
            // 
            // EntranceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 362);
            this.Controls.Add(this.tabControl);
            this.Name = "EntranceGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.EntranceGame_Load);
            this.tabControl.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.register.ResumeLayout(false);
            this.register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage loginPage;
        private Button cancelButton;
        private Button loginButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox loginTextBox;
        private Label nameLabel;
        private TabPage register;
        private TextBox confirmTextBox;
        private Label confirmPLabel;
        private Button button1;
        private Button registerButton;
        private TextBox passwordRegTextBox;
        private Label passwordRegLabel;
        private TextBox loginRegTextBox;
        private Label loginRegLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}