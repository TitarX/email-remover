namespace Email_Remover
{
    partial class AddConnectionForm
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
            this.HostLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SSLLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.SSLComboBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.protocolLabel = new System.Windows.Forms.Label();
            this.ProtocolComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Location = new System.Drawing.Point(12, 93);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(34, 13);
            this.HostLabel.TabIndex = 0;
            this.HostLabel.Text = "Хост:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(12, 196);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(83, 13);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Пользователь:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 230);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // SSLLabel
            // 
            this.SSLLabel.AutoSize = true;
            this.SSLLabel.Location = new System.Drawing.Point(12, 161);
            this.SSLLabel.Name = "SSLLabel";
            this.SSLLabel.Size = new System.Drawing.Size(30, 13);
            this.SSLLabel.TabIndex = 3;
            this.SSLLabel.Text = "SSL:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(12, 126);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(35, 13);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "Порт:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(135, 90);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(337, 20);
            this.HostTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(135, 227);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(337, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(135, 193);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(337, 20);
            this.UserTextBox.TabIndex = 7;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(135, 123);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(337, 20);
            this.PortTextBox.TabIndex = 9;
            // 
            // SSLComboBox
            // 
            this.SSLComboBox.FormattingEnabled = true;
            this.SSLComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.SSLComboBox.Location = new System.Drawing.Point(135, 158);
            this.SSLComboBox.Name = "SSLComboBox";
            this.SSLComboBox.Size = new System.Drawing.Size(337, 21);
            this.SSLComboBox.TabIndex = 10;
            this.SSLComboBox.Text = "Да";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(356, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(116, 23);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // protocolLabel
            // 
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.Location = new System.Drawing.Point(12, 59);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(59, 13);
            this.protocolLabel.TabIndex = 13;
            this.protocolLabel.Text = "Протокол:";
            // 
            // ProtocolComboBox
            // 
            this.ProtocolComboBox.FormattingEnabled = true;
            this.ProtocolComboBox.Items.AddRange(new object[] {
            "IMAP",
            "POP3"});
            this.ProtocolComboBox.Location = new System.Drawing.Point(135, 56);
            this.ProtocolComboBox.Name = "ProtocolComboBox";
            this.ProtocolComboBox.Size = new System.Drawing.Size(337, 21);
            this.ProtocolComboBox.TabIndex = 14;
            this.ProtocolComboBox.Text = "IMAP";
            // 
            // AddConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.ControlBox = false;
            this.Controls.Add(this.ProtocolComboBox);
            this.Controls.Add(this.protocolLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SSLComboBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.SSLLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.HostLabel);
            this.Name = "AddConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SSLLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.ComboBox SSLComboBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label protocolLabel;
        private System.Windows.Forms.ComboBox ProtocolComboBox;
    }
}