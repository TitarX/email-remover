namespace Email_Remover
{
    partial class ConnectionsForm
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
            this.ConnectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectConnectionButton = new System.Windows.Forms.Button();
            this.AddConnectionButton = new System.Windows.Forms.Button();
            this.RemoveConnectionButton = new System.Windows.Forms.Button();
            this.ChangeConnectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionsDataGridView
            // 
            this.ConnectionsDataGridView.AllowUserToAddRows = false;
            this.ConnectionsDataGridView.AllowUserToDeleteRows = false;
            this.ConnectionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.ConnectionsDataGridView.Name = "ConnectionsDataGridView";
            this.ConnectionsDataGridView.ReadOnly = true;
            this.ConnectionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConnectionsDataGridView.Size = new System.Drawing.Size(668, 420);
            this.ConnectionsDataGridView.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(588, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(92, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectConnectionButton
            // 
            this.SelectConnectionButton.Enabled = false;
            this.SelectConnectionButton.Location = new System.Drawing.Point(12, 12);
            this.SelectConnectionButton.Name = "SelectConnectionButton";
            this.SelectConnectionButton.Size = new System.Drawing.Size(89, 23);
            this.SelectConnectionButton.TabIndex = 2;
            this.SelectConnectionButton.Text = "Выбрать";
            this.SelectConnectionButton.UseVisualStyleBackColor = true;
            this.SelectConnectionButton.Click += new System.EventHandler(this.SelectConnectionButton_Click);
            // 
            // AddConnectionButton
            // 
            this.AddConnectionButton.Location = new System.Drawing.Point(107, 12);
            this.AddConnectionButton.Name = "AddConnectionButton";
            this.AddConnectionButton.Size = new System.Drawing.Size(90, 23);
            this.AddConnectionButton.TabIndex = 3;
            this.AddConnectionButton.Text = "Добавить";
            this.AddConnectionButton.UseVisualStyleBackColor = true;
            this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButton_Click);
            // 
            // RemoveConnectionButton
            // 
            this.RemoveConnectionButton.Enabled = false;
            this.RemoveConnectionButton.Location = new System.Drawing.Point(301, 12);
            this.RemoveConnectionButton.Name = "RemoveConnectionButton";
            this.RemoveConnectionButton.Size = new System.Drawing.Size(95, 23);
            this.RemoveConnectionButton.TabIndex = 4;
            this.RemoveConnectionButton.Text = "Удалить";
            this.RemoveConnectionButton.UseVisualStyleBackColor = true;
            this.RemoveConnectionButton.Click += new System.EventHandler(this.RemoveConnectionButton_Click);
            // 
            // ChangeConnectionButton
            // 
            this.ChangeConnectionButton.Enabled = false;
            this.ChangeConnectionButton.Location = new System.Drawing.Point(203, 12);
            this.ChangeConnectionButton.Name = "ChangeConnectionButton";
            this.ChangeConnectionButton.Size = new System.Drawing.Size(92, 23);
            this.ChangeConnectionButton.TabIndex = 5;
            this.ChangeConnectionButton.Text = "Изменить";
            this.ChangeConnectionButton.UseVisualStyleBackColor = true;
            this.ChangeConnectionButton.Click += new System.EventHandler(this.ChangeConnectionButton_Click);
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.ChangeConnectionButton);
            this.Controls.Add(this.RemoveConnectionButton);
            this.Controls.Add(this.AddConnectionButton);
            this.Controls.Add(this.SelectConnectionButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConnectionsDataGridView);
            this.Name = "ConnectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление подключениями";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConnectionsDataGridView;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SelectConnectionButton;
        private System.Windows.Forms.Button AddConnectionButton;
        private System.Windows.Forms.Button RemoveConnectionButton;
        private System.Windows.Forms.Button ChangeConnectionButton;
    }
}