using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Email_Remover
{
    class Connector
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";

        public Connector()
        {
            if (!File.Exists("db.mdb"))
            {
                CreateDB();
            }
        }

        private void CreateDB()
        {
            ADOX.CatalogClass catalogClass = new ADOX.CatalogClass();
            catalogClass.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;Jet OLEDB:Engine Type=5");

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE EmailsConnections(EmailID int IDENTITY(1,1), EmailProtocol text NOT NULL, EmailHost text NOT NULL, EmailPort int NOT NULL,"
                + "EmailSSL yesno NOT NULL, EmailUser text NOT NULL, EmailPassword text NOT NULL, PRIMARY KEY(EmailID))";

                command.ExecuteNonQuery();
            }
        }

        public int AddConnection(ConnectionData newConnectionData)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO EmailsConnections(EmailProtocol, EmailHost, EmailPort, EmailSSL, EmailUser, EmailPassword) VALUES(@EmailProtocol, @EmailHost, @EmailPort, @EmailSSL, @EmailUser, @EmailPassword)";
                command.Parameters.AddWithValue("@EmailProtocol", newConnectionData.Protocol);
                command.Parameters.AddWithValue("@EmailHost", newConnectionData.Host);
                command.Parameters.AddWithValue("@EmailPort", newConnectionData.Port);
                command.Parameters.AddWithValue("@EmailSSL", newConnectionData.SSL);
                command.Parameters.AddWithValue("@EmailUser", newConnectionData.User);
                command.Parameters.AddWithValue("@EmailPassword", newConnectionData.Password);
                return command.ExecuteNonQuery();
            }
        }

        public DataSet LoadConnections()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM EmailsConnections", connection);
                dataAdapter.Fill(dataSet, "EmailsConnections");
                return dataSet;
            }
        }

        public int ChangeConnection(ConnectionData newConnectionData)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE EmailsConnections SET EmailProtocol = @EmailProtocol, EmailHost = @EmailHost, EmailPort = @EmailPort, EmailSSL = @EmailSSL, EmailUser = @EmailUser, EmailPassword = @EmailPassword WHERE EmailID = @EmailID";
                command.Parameters.AddWithValue("@EmailProtocol", newConnectionData.Protocol);
                command.Parameters.AddWithValue("@EmailHost", newConnectionData.Host);
                command.Parameters.AddWithValue("@EmailPort", newConnectionData.Port);
                command.Parameters.AddWithValue("@EmailSSL", newConnectionData.SSL);
                command.Parameters.AddWithValue("@EmailUser", newConnectionData.User);
                command.Parameters.AddWithValue("@EmailPassword", newConnectionData.Password);
                command.Parameters.AddWithValue("@EmailID", newConnectionData.Id);
                return command.ExecuteNonQuery();
            }
        }

        public int RemoveConnection(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM EmailsConnections WHERE EmailID = @EmailID";
                command.Parameters.AddWithValue("@EmailID", id);
                return command.ExecuteNonQuery();
            }
        }
    }
}
