using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Email_Remover
{
    public partial class MessagesRemoveConfirmForm : Form
    {
        private bool messagesRemoveConfirmCheckBoxResult = false;

        public MessagesRemoveConfirmForm(String messagesRemoveConfirmLabelText)
        {
            InitializeComponent();

            this.MessagesRemoveConfirmLabel.Text = messagesRemoveConfirmLabelText;
        }

        public bool MessagesRemoveConfirmCheckBoxResult
        {
            get
            {
                return messagesRemoveConfirmCheckBoxResult;
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            messagesRemoveConfirmCheckBoxResult = this.MessagesRemoveConfirmCheckBox.Checked;

            this.Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            messagesRemoveConfirmCheckBoxResult = this.MessagesRemoveConfirmCheckBox.Checked;

            this.Close();
        }
    }
}
