using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Email_Remover
{
    public struct ConnectionData
    {
        private string protocol;
        private string host;
        private int port;
        private bool ssl;
        private string user;
        private string password;

        public bool isEmpty;

        private int id;

        public string Protocol
        {
            get
            {
                return this.protocol;
            }

            set
            {
                this.protocol = value;
            }
        }

        public string Host
        {
            get
            {
                return this.host;
            }

            set
            {
                this.host = value;
            }
        }

        public int Port
        {
            get
            {
                return this.port;
            }

            set
            {
                this.port = value;
            }
        }

        public bool SSL
        {
            get
            {
                return this.ssl;
            }

            set
            {
                this.ssl = value;
            }
        }

        public string User
        {
            get
            {
                return this.user;
            }

            set
            {
                this.user = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public ConnectionData(bool isEmpty)
        {
            this.protocol = "";
            this.host = "";
            this.port = 0;
            this.ssl = false;
            this.user = "";
            this.password = "";

            this.isEmpty = isEmpty;

            this.id = 0;
        }

        public ConnectionData(int id, string protocol, string host, int port, bool ssl, string user, string password)
        {
            this.protocol = protocol;
            this.host = host;
            this.port = port;
            this.ssl = ssl;
            this.user = user;
            this.password = password;

            this.isEmpty = false;

            this.id = id;
        }
    }
}
