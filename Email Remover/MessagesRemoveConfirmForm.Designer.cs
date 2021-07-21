namespace Email_Remover
{
    partial class MessagesRemoveConfirmForm
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.MessagesRemoveConfirmCheckBox = new System.Windows.Forms.CheckBox();
            this.MessagesRemoveConfirmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesButton.Location = new System.Drawing.Point(12, 76);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoButton.Location = new System.Drawing.Point(267, 76);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // MessagesRemoveConfirmCheckBox
            // 
            this.MessagesRemoveConfirmCheckBox.AutoSize = true;
            this.MessagesRemoveConfirmCheckBox.Location = new System.Drawing.Point(12, 37);
            this.MessagesRemoveConfirmCheckBox.Name = "MessagesRemoveConfirmCheckBox";
            this.MessagesRemoveConfirmCheckBox.Size = new System.Drawing.Size(222, 17);
            this.MessagesRemoveConfirmCheckBox.TabIndex = 2;
            this.MessagesRemoveConfirmCheckBox.Text = "Кроме сообщений за последнии сутки";
            this.MessagesRemoveConfirmCheckBox.UseVisualStyleBackColor = true;
            // 
            // MessagesRemoveConfirmLabel
            // 
            this.MessagesRemoveConfirmLabel.AutoSize = true;
            this.MessagesRemoveConfirmLabel.ForeColor = System.Drawing.Color.Red;
            this.MessagesRemoveConfirmLabel.Location = new System.Drawing.Point(9, 9);
            this.MessagesRemoveConfirmLabel.Name = "MessagesRemoveConfirmLabel";
            this.MessagesRemoveConfirmLabel.Size = new System.Drawing.Size(0, 13);
            this.MessagesRemoveConfirmLabel.TabIndex = 3;
            // 
            // MessagesRemoveConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.ControlBox = false;
            this.Controls.Add(this.MessagesRemoveConfirmLabel);
            this.Controls.Add(this.MessagesRemoveConfirmCheckBox);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Name = "MessagesRemoveConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подтвердите действие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.CheckBox MessagesRemoveConfirmCheckBox;
        private System.Windows.Forms.Label MessagesRemoveConfirmLabel;
    }
}