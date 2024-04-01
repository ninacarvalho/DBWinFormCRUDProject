using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Microsoft.VisualBasic;

namespace DBWinFormCRUDProject
{
    public  class Database
    {
        public String ServerAddress { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String DatabaseName { get; set; }
        public String PortNumber { get; set; }

        public Database(string serverAddress, string userName, string password, string databaseName, string portNumber)
        {
            ServerAddress = serverAddress;
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            PortNumber = portNumber;
        }

        public MySqlConnection Connect() {
            String connStr = $"Server= {this.ServerAddress}; port={this.PortNumber}; User id = {this.UserName}; Password = {this.Password} ; Database = {this.DatabaseName}";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Connecting to database" +ex.Message);
                return null;
            }
        }


        
    }
}
