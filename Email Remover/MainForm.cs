using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Pop3;
using ImapX;
using ImapX.Collections;

namespace Email_Remover
{
    public partial class MainForm : Form
    {
        private ConnectionData connectionData = new ConnectionData(true);

        public MainForm()
        {
            InitializeComponent();
        }

        public ConnectionData ConnectionDataProperty
        {
            get
            {
                return this.connectionData;
            }

            set
            {
                this.connectionData = value;
            }
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RemoveEmailsByPOP3(string hostname, int port, bool useSsl, string username, string password, bool isRemoveOldMessagesOnly)
        {
            try
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 50;

                using (Pop3Client client = new Pop3Client())
                {
                    client.Connect(hostname, port, useSsl);
                    client.Authenticate(username, password);

                    if (isRemoveOldMessagesOnly)
                    {
                        int messageCount = client.GetMessageCount();
                        
                        for(int m = 1; m <= messageCount; m++)
                        {
                            if (DateTime.Today.AddDays(-1).CompareTo(client.GetMessageHeaders(m).DateSent) >= 0)
                            {
                                client.DeleteMessage(m);
                            }
                        }
                    }
                    else
                    {
                        client.DeleteAllMessages();
                    }

                    client.Disconnect();
                }

                MessageBox.Show(this, "Сообщения в текущем аккаунте успешно удалены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        private void LoadEmailsByPOP3(string hostname, int port, bool useSsl, string username, string password)
        {
            try
            {

                headersListBox.Items.Clear();

                using (Pop3Client client = new Pop3Client())
                {
                    client.Connect(hostname, port, useSsl);
                    client.Authenticate(username, password);
                    int emailsCount = client.GetMessageCount();

                    progressBar.Minimum = 0;
                    progressBar.Maximum = emailsCount + 10;
                    progressBar.Value = 10;

                    for (int i = 1; i <= emailsCount; i++)
                    {
                        headersListBox.Items.Add(client.GetMessageHeaders(i).Subject);
                        progressBar.Value = i + 10;
                    }

                    if (progressBar.Value == (emailsCount + 10))
                    {
                        MessageBox.Show(this, "Заголовки сообщений успешно загружены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (progressBar.Value == 10)
                        {
                            MessageBox.Show(this, "Не удалось загрузить заголовки сообщений", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(this, "Не удалось загрузить все заголовки сообщений", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    client.Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        private void RemoveEmailsByImapX(string hostname, int port, bool useSsl, string username, string password, bool isRemoveOldMessagesOnly)
        {
            try
            {
                using (ImapClient client = new ImapClient(hostname, port, useSsl))
                {
                    if (client.Connect())
                    {
                        if (client.Login(username, password))
                        {
                            FolderCollection folderCollection = client.Folders;

                            int foldersCount = folderCollection.Count();

                            progressBar.Minimum = 0;
                            progressBar.Maximum = foldersCount + 10;
                            progressBar.Value = 10;
                            
                            if (isRemoveOldMessagesOnly)
                            {
                                for (int i = 0; i < foldersCount; i++)
                                {
                                    foreach(ImapX.Message message in folderCollection[i].Messages)
                                    {
                                        if(DateTime.Today.AddDays(-1).CompareTo(message.Date) >= 0)
                                        {
                                            message.Remove();
                                        }
                                    }
                                    progressBar.Value = i + 1 + 10;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < foldersCount; i++)
                                {
                                    folderCollection[i].EmptyFolder();
                                    progressBar.Value = i + 1 +10;
                                }
                            }

                            if (progressBar.Value == (foldersCount + 10))
                            {
                                MessageBox.Show(this, "Сообщения в текущем аккаунте успешно удалены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (progressBar.Value == 10)
                                {
                                    MessageBox.Show(this, "Не удалось удалить сообщения в текущем аккаунте", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(this, "Не удалось удалить сообщения в текущем аккаунте", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            client.Disconnect();
                        }
                        else
                        {
                            MessageBox.Show(this, "Не удалось авторазоваться на сервере", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Не удалось подключиться к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        private void LoadEmailsByImapX(string hostname, int port, bool useSsl, string username, string password)
        {
            try
            {
                headersListBox.Items.Clear();

                using (ImapClient client = new ImapClient(hostname, port, useSsl))
                {
                    if (client.Connect())
                    {
                        if (client.Login(username, password))
                        {
                            FolderCollection folderCollection = client.Folders;

                            int foldersCount = folderCollection.Count();

                            progressBar.Minimum = 0;
                            progressBar.Maximum = foldersCount + 10;
                            progressBar.Value = 10;

                            for (int i = 0; i < foldersCount; i++)
                            {
                                foreach (ImapX.Message message in folderCollection[i].Search())
                                {
                                    headersListBox.Items.Add(message.Subject);
                                }

                                progressBar.Value = i + 1 +10;
                            }

                            if (progressBar.Value == (foldersCount + 10))
                            {
                                MessageBox.Show(this, "Заголовки сообщений успешно загружены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (progressBar.Value == 10)
                                {
                                    MessageBox.Show(this, "Не удалось загрузить заголовки сообщений", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(this, "Не удалось загрузить все заголовки сообщений", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            client.Disconnect();
                        }
                        else
                        {
                            MessageBox.Show(this, "Не удалось авторазоваться на сервере", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Не удалось подключиться к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show(this, "Сообщения во всех аккаунтах будут удалены. Продолжть?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessagesRemoveConfirmForm messagesRemoveConfirmForm = new MessagesRemoveConfirmForm("Сообщения во всех аккаунтах будут удалены. Продолжть?");
            DialogResult dialogResult = messagesRemoveConfirmForm.ShowDialog(this);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Connector connector = new Connector();
                    DataSet dataSet = connector.LoadConnections();
                    int dataSetRowsCount = dataSet.Tables["EmailsConnections"].Rows.Count;

                    progressBar.Minimum = 0;
                    progressBar.Maximum = dataSetRowsCount +10;
                    progressBar.Value = 10;

                    for (int i = 0; i < dataSetRowsCount; i++)
                    {
                        DataRow dataRow = dataSet.Tables["EmailsConnections"].Rows[i];

                        if (dataRow["EmailProtocol"].ToString().Equals("IMAP"))
                        {
                            using (ImapClient client = new ImapClient(dataRow["EmailHost"].ToString(), Convert.ToInt32(dataRow["EmailPort"]), Convert.ToBoolean(dataRow["EmailSSL"])))
                            {
                                if (client.Connect())
                                {
                                    if (client.Login(dataRow["EmailUser"].ToString(), dataRow["EmailPassword"].ToString()))
                                    {
                                        FolderCollection folderCollection = client.Folders;

                                        if (messagesRemoveConfirmForm.MessagesRemoveConfirmCheckBoxResult)
                                        {
                                            foreach (Folder folder in folderCollection)
                                            {
                                                foreach(ImapX.Message message in folder.Messages)
                                                {
                                                    if (DateTime.Today.AddDays(-1).CompareTo(message.Date) >= 0)
                                                    {
                                                        message.Remove();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            foreach (Folder folder in folderCollection)
                                            {
                                                folder.EmptyFolder();
                                            }
                                        }

                                        client.Disconnect();
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Не удалось авторазоваться на сервере " + dataRow["EmailHost"].ToString() + " с имененм пользователя " + dataRow["EmailUser"].ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "Не удалось подключиться к серверу " + dataRow["EmailHost"].ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (dataRow["EmailProtocol"].ToString().Equals("POP3"))
                        {
                            using (Pop3Client client = new Pop3Client())
                            {
                                client.Connect(dataRow["EmailHost"].ToString(), Convert.ToInt32(dataRow["EmailPort"]), Convert.ToBoolean(dataRow["EmailSSL"]));
                                client.Authenticate(dataRow["EmailUser"].ToString(), dataRow["EmailPassword"].ToString());

                                if (messagesRemoveConfirmForm.MessagesRemoveConfirmCheckBoxResult)
                                {
                                    int messageCount = client.GetMessageCount();

                                    for (int m = 1; m <= messageCount; m++)
                                    {
                                        if (DateTime.Today.AddDays(-1).CompareTo(client.GetMessageHeaders(m).DateSent) >= 0)
                                        {
                                            client.DeleteMessage(m);
                                        }
                                    }
                                }
                                else
                                {
                                    client.DeleteAllMessages();
                                }

                                client.Disconnect();
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Неизвестный протокол для сервера " + dataRow["EmailHost"].ToString() + " с имененм пользователя " + dataRow["EmailUser"].ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        progressBar.Value = i + 1 +10;
                    }

                    if (progressBar.Value == dataSetRowsCount + 10)
                    {
                        MessageBox.Show(this, "Сообщения во всех аккаунтах успешно удалены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (progressBar.Value == 10)
                        {
                            MessageBox.Show(this, "Не удалось удалить сообщения во всех аккаунтах", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(this, "Не удалось удалить все сообщения во всех аккаунтах", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    progressBar.Value = 0;
                }

                if (!connectionData.isEmpty)
                {
                    if (connectionData.Protocol.Trim().Equals("POP3"))
                    {
                        LoadEmailsByPOP3(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password);
                    }
                    else if (connectionData.Protocol.Trim().Equals("IMAP"))
                    {
                        LoadEmailsByImapX(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password);
                    }
                    else
                    {
                        MessageBox.Show(this, "Подключение не установлено. Неизвестный протокол.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show(this, "Сообщения в текущем аккаунте будут удалены. Продолжть?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessagesRemoveConfirmForm messagesRemoveConfirmForm = new MessagesRemoveConfirmForm("Сообщения в текущем аккаунте будут удалены. Продолжть?");
            DialogResult dialogResult = messagesRemoveConfirmForm.ShowDialog(this);

            if (dialogResult == DialogResult.Yes)
            {
                if (!connectionData.isEmpty)
                {
                    if (connectionData.Protocol.Trim().Equals("POP3"))
                    {
                        RemoveEmailsByPOP3(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password, messagesRemoveConfirmForm.MessagesRemoveConfirmCheckBoxResult);
                        LoadEmailsByPOP3(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password);
                    }
                    else if (connectionData.Protocol.Trim().Equals("IMAP"))
                    {
                        RemoveEmailsByImapX(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password, messagesRemoveConfirmForm.MessagesRemoveConfirmCheckBoxResult);
                        LoadEmailsByImapX(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password);
                    }
                    else
                    {
                        MessageBox.Show(this, "Подключение не установлено. Неизвестный протокол.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ConnectionsButton_Click(object sender, EventArgs e)
        {
            connectionData = new ConnectionData(true);
            this.Text = "Подключение не выбрано";
            RemoveButton.Enabled = false;

            ConnectionsForm connectionForm = new ConnectionsForm(this);
            connectionForm.ShowDialog(this);

            if (!connectionData.isEmpty)
            {
                string titleString =  "Сервер: " + connectionData.Host + " | Пользователь: " + connectionData.User;
                this.Text = titleString;
                RemoveButton.Enabled = true;

                if (connectionData.Protocol.Trim().Equals("POP3"))
                {
                    LoadEmailsByPOP3(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password);
                }
                else if (connectionData.Protocol.Trim().Equals("IMAP"))
                {
                    LoadEmailsByImapX(connectionData.Host, connectionData.Port, connectionData.SSL, connectionData.User, connectionData.Password);
                }
                else
                {
                    MessageBox.Show(this, "Подключение не установлено. Неизвестный протокол.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }
    }
}
