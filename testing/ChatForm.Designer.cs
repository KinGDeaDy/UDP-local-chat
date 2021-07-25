namespace testing
{
    partial class ChatForm
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
            this.chatBox = new System.Windows.Forms.TextBox();
            this.messageChatBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatBox.ForeColor = System.Drawing.Color.White;
            this.chatBox.Location = new System.Drawing.Point(16, 289);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(932, 241);
            this.chatBox.TabIndex = 8;
            // 
            // messageChatBox
            // 
            this.messageChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.messageChatBox.Location = new System.Drawing.Point(17, 664);
            this.messageChatBox.Name = "messageChatBox";
            this.messageChatBox.Size = new System.Drawing.Size(597, 35);
            this.messageChatBox.TabIndex = 11;
            this.messageChatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageChatBox_KeyDown);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessageButton.Depth = 0;
            this.sendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendMessageButton.Location = new System.Drawing.Point(660, 572);
            this.sendMessageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Primary = true;
            this.sendMessageButton.Size = new System.Drawing.Size(288, 127);
            this.sendMessageButton.TabIndex = 18;
            this.sendMessageButton.Text = "Отправить";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(648, 178);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 27);
            this.materialLabel1.TabIndex = 19;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(622, 164);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(164, 27);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Вы вошли как:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(792, 164);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(156, 27);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "materialLabel3";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 745);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageChatBox);
            this.Controls.Add(this.chatBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ChatForm";
            this.Text = "Чат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox messageChatBox;
        private MaterialSkin.Controls.MaterialRaisedButton sendMessageButton;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

