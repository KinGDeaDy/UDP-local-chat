namespace testing
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
            this.loginFilled = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordFilled = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.wrongDataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // loginFilled
            // 
            this.loginFilled.Depth = 0;
            this.loginFilled.Hint = "Логин";
            this.loginFilled.Location = new System.Drawing.Point(40, 158);
            this.loginFilled.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginFilled.Name = "loginFilled";
            this.loginFilled.PasswordChar = '\0';
            this.loginFilled.SelectedText = "";
            this.loginFilled.SelectionLength = 0;
            this.loginFilled.SelectionStart = 0;
            this.loginFilled.Size = new System.Drawing.Size(701, 32);
            this.loginFilled.TabIndex = 0;
            this.loginFilled.UseSystemPasswordChar = false;
            // 
            // passwordFilled
            // 
            this.passwordFilled.Depth = 0;
            this.passwordFilled.Hint = "Пароль";
            this.passwordFilled.Location = new System.Drawing.Point(40, 223);
            this.passwordFilled.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordFilled.Name = "passwordFilled";
            this.passwordFilled.PasswordChar = '*';
            this.passwordFilled.SelectedText = "";
            this.passwordFilled.SelectionLength = 0;
            this.passwordFilled.SelectionStart = 0;
            this.passwordFilled.Size = new System.Drawing.Size(701, 32);
            this.passwordFilled.TabIndex = 1;
            this.passwordFilled.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(346, 320);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(142, 52);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(40, 406);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(448, 2);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 495);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(160, 27);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Нет аккаунта?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(343, 495);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(145, 27);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Регистрация";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // wrongDataLabel
            // 
            this.wrongDataLabel.AutoSize = true;
            this.wrongDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongDataLabel.Depth = 0;
            this.wrongDataLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrongDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongDataLabel.Location = new System.Drawing.Point(35, 271);
            this.wrongDataLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrongDataLabel.Name = "wrongDataLabel";
            this.wrongDataLabel.Size = new System.Drawing.Size(361, 27);
            this.wrongDataLabel.TabIndex = 6;
            this.wrongDataLabel.Text = "Неправильный логин или пароль";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 588);
            this.Controls.Add(this.wrongDataLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordFilled);
            this.Controls.Add(this.loginFilled);
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialSingleLineTextField loginFilled;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordFilled;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel wrongDataLabel;
    }
}