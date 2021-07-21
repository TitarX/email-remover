using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Remover
{
    public partial class AddConnectionForm : Form
    {
        private ConnectionsForm connectionForm = null;
        private int id = 0;

        public AddConnectionForm(ConnectionsForm connectionForm)
        {
            InitializeComponent();

            this.connectionForm = connectionForm;
        }

        public AddConnectionForm(ConnectionsForm connectionForm, ConnectionData connectionData, int id)
        {
            InitializeComponent();

            this.connectionForm = connectionForm;

            this.HostTextBox.Text = connectionData.Protocol;
            this.HostTextBox.Text = connectionData.Host;
            this.PortTextBox.Text = connectionData.Port.ToString();
            this.SSLComboBox.Text = connectionData.SSL ? "Да" : "Нет";
            this.UserTextBox.Text = connectionData.User;
            this.PasswordTextBox.Text = connectionData.Password;

            this.id = id;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string protocol = ProtocolComboBox.SelectedItem.ToString().Trim();
            string host = HostTextBox.Text.Trim();
            string portString = PortTextBox.Text.Trim();
            int port = 0;
            string sslString = SSLComboBox.SelectedItem.ToString().Trim();
            bool ssl = sslString.Equals("Нет") ? false : true;
            string user = UserTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            if(System.String.IsNullOrWhiteSpace(host) || System.String.IsNullOrWhiteSpace(portString))
            {
                MessageBox.Show(this, "Поля \"Хост\" и \"Порт\" обязательны для заполнения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!Int32.TryParse(portString, out port))
            {
                MessageBox.Show(this, "Поля \"Порт\" имеет недопустимое значение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConnectionData newConnectionData = new ConnectionData(id, protocol, host, port, ssl, user, password);
                connectionForm.NewConnectionDataProperty = newConnectionData;
                this.Close();
            }
        }
    }
}
