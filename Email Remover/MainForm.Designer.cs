namespace Email_Remover
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.headersListBox = new System.Windows.Forms.ListBox();
            this.ConnectionsButton = new System.Windows.Forms.Button();
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(705, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Location = new System.Drawing.Point(117, 12);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(180, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Очистить в текущем аккаунте";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // headersListBox
            // 
            this.headersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headersListBox.FormattingEnabled = true;
            this.headersListBox.Location = new System.Drawing.Point(12, 47);
            this.headersListBox.MultiColumn = true;
            this.headersListBox.Name = "headersListBox";
            this.headersListBox.Size = new System.Drawing.Size(768, 472);
            this.headersListBox.TabIndex = 2;
            // 
            // ConnectionsButton
            // 
            this.ConnectionsButton.Location = new System.Drawing.Point(12, 12);
            this.ConnectionsButton.Name = "ConnectionsButton";
            this.ConnectionsButton.Size = new System.Drawing.Size(99, 23);
            this.ConnectionsButton.TabIndex = 3;
            this.ConnectionsButton.Text = "Подключения";
            this.ConnectionsButton.UseVisualStyleBackColor = true;
            this.ConnectionsButton.Click += new System.EventHandler(this.ConnectionsButton_Click);
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAllButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveAllButton.Location = new System.Drawing.Point(303, 12);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(201, 23);
            this.RemoveAllButton.TabIndex = 4;
            this.RemoveAllButton.Text = "Очистить во всех аккаунтах";
            this.RemoveAllButton.UseVisualStyleBackColor = false;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 538);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(767, 23);
            this.progressBar.TabIndex = 5;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(676, 12);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(23, 23);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "?";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.ConnectionsButton);
            this.Controls.Add(this.headersListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение не выбрано";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox headersListBox;
        private System.Windows.Forms.Button ConnectionsButton;
        private System.Windows.Forms.Button RemoveAllButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button AboutButton;
    }
}

