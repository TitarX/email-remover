using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Remover
{
    public partial class ConnectionsForm : Form
    {
        private Connector connector = null;
        private ConnectionData newConnesctionData = new ConnectionData(true);
        private MainForm mainForm = null;

        public ConnectionsForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            connector = new Connector();
            LoadConnections();
        }

        public ConnectionData NewConnectionDataProperty
        {
            get
            {
                return newConnesctionData;
            }

            set
            {
                this.newConnesctionData = value;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddConnectionButton_Click(object sender, EventArgs e)
        {
            newConnesctionData = new ConnectionData(true);

            AddConnectionForm addConnectionForm = new AddConnectionForm(this);
            addConnectionForm.ShowDialog(this);

            if(!newConnesctionData.isEmpty)
            {
                AddConnection();
            }
        }

        private void AddConnection()
        {
            try
            {
                int result = connector.AddConnection(newConnesctionData);
                if(result > 0)
                {
                    MessageBox.Show(this, "Подключение успешно добавлено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Не удалось добавить подключение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadConnections();
            }
        }

        private void LoadConnections()
        {
            DataSet dataSet = connector.LoadConnections();
            ConnectionsDataGridView.DataSource = dataSet.Tables["EmailsConnections"];
            ConnectionsDataGridView.Columns["EmailID"].Visible = false;

            int dataSetRowsCount = dataSet.Tables["EmailsConnections"].Rows.Count;
            if (dataSetRowsCount > 0)
            {
                SelectConnectionButton.Enabled = true;
                ChangeConnectionButton.Enabled = true;
                RemoveConnectionButton.Enabled = true;
            }
            else
            {
                SelectConnectionButton.Enabled = false;
                ChangeConnectionButton.Enabled = false;
                RemoveConnectionButton.Enabled = false;
            }
        }

        private void ChangeConnectionButton_Click(object sender, EventArgs e)
        {
            newConnesctionData = new ConnectionData(true);

            ConnectionData changeConnectionData = new ConnectionData(
                Convert.ToInt32(ConnectionsDataGridView.SelectedCells[0].Value),
                ConnectionsDataGridView.SelectedCells[1].Value.ToString(),
                ConnectionsDataGridView.SelectedCells[2].Value.ToString(),
                Convert.ToInt32(ConnectionsDataGridView.SelectedCells[3].Value),
                Convert.ToBoolean(ConnectionsDataGridView.SelectedCells[4].Value),
                ConnectionsDataGridView.SelectedCells[5].Value.ToString(),
                ConnectionsDataGridView.SelectedCells[6].Value.ToString());

            AddConnectionForm addConnectionForm = new AddConnectionForm(this, changeConnectionData, Convert.ToInt32(ConnectionsDataGridView.SelectedCells[0].Value));
            addConnectionForm.ShowDialog(this);

            if (!newConnesctionData.isEmpty)
            {
                ChangeConnection();
            }
        }

        private void ChangeConnection()
        {
            try
            {
                int result = connector.ChangeConnection(newConnesctionData);
                if (result > 0)
                {
                    MessageBox.Show(this, "Подключение успешно сохраненно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (newConnesctionData.Id > 0)
                    {
                        MessageBox.Show(this, "Подключение не изменено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(this, "Не удалось сохранить подключение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadConnections();
            }
        }

        private void RemoveConnectionButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show(this, "Выбранное подключение будет удалено. Продолжть?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dialogResult == DialogResult.Yes)
            {
                RemoveConnection();
            }
        }

        private void RemoveConnection()
        {
            try
            {
                int result = connector.RemoveConnection(Convert.ToInt32(ConnectionsDataGridView.SelectedCells[0].Value));
                if (result > 0)
                {
                    MessageBox.Show(this, "Подключение успешно удалено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Не удалось удалить подключение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadConnections();
            }
        }

        private void SelectConnectionButton_Click(object sender, EventArgs e)
        {
            mainForm.ConnectionDataProperty = new ConnectionData(
                Convert.ToInt32(ConnectionsDataGridView.SelectedCells[0].Value),
                ConnectionsDataGridView.SelectedCells[1].Value.ToString(),
                ConnectionsDataGridView.SelectedCells[2].Value.ToString(),
                Convert.ToInt32(ConnectionsDataGridView.SelectedCells[3].Value),
                Convert.ToBoolean(ConnectionsDataGridView.SelectedCells[4].Value),
                ConnectionsDataGridView.SelectedCells[5].Value.ToString(),
                ConnectionsDataGridView.SelectedCells[6].Value.ToString());

            this.Close();
        }
    }
}
