using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GRU_H8_Test
{
    class Database
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string connectionstring = null;
        string query = null;
        string LastSelectedID = null;
        MySqlConnection sqlConnection;
        MySqlCommand newSQLcommand;
        MySqlDataReader sqlReader = null;

        public void DbCon()
        {
            server = "tsuts.tskoli.is";
            database = "0905953189_gru8_test";
            uid = "0905953189";
            password = "bagg3rb3st";
            connectionstring = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqlConnection = new MySqlConnection(connectionstring);
        }

        private bool OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                sqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }

        public bool AdminLogin(string user, string pass)
        {
            List<string> Container = new List<string>();
            string line = null;
            bool IsTrue = false;
            if (OpenConnection() == true)
            {
                query = "SELECT Username, Password FROM users WHERE Authority = '3'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                sqlReader = newSQLcommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        line += (sqlReader.GetValue(i).ToString().ToUpper()) + ":";
                    }
                    Container.Add(line);
                    line = null;
                }
                CloseConnection();
                if (Container.Contains(user.ToUpper() + ":" + pass.ToUpper() + ":"))
                {
                    IsTrue = true;
                    return IsTrue;
                }
            }
            return IsTrue;
        }

        public List<string> ReadSQLUserTable()
        {
            List<string> Container = new List<string>();
            string line = null;
            if (OpenConnection() == true)
            {
                query = "SELECT `ID`, `Social_security_number`, `Name`, `Email`, `Phone`, `Authority`, `Username`, `Password` FROM `users`";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                sqlReader = newSQLcommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        line += (sqlReader.GetValue(i).ToString()) + "╪";
                    }
                    Container.Add(line);
                    line = null;
                }
                CloseConnection();
                return Container;
            }
            else
            {
                return Container;
            }
        }

        public List<string> ReadSQLEventTable()
        {
            List<string> Container = new List<string>();
            string line = null;
            if (OpenConnection() == true)
            {
                query = "SELECT `ID`, `Name`, `Date`, `Location`, `Description` FROM `event`";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                sqlReader = newSQLcommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        line += (sqlReader.GetValue(i).ToString()) + "╪";
                    }
                    Container.Add(line);
                    line = null;
                }
                CloseConnection();
                return Container;
            }
            else
            {
                return Container;
            }
        }

        public void PutIntoSQLUserTable(string SSN, string name, string email, string phone, int authority, string user, string pass)
        {
            if (OpenConnection() == true)
            {
                query = "INSERT INTO users (`Social_security_number`, `Name`, `Email`, `Phone`, `Authority`, `Username`, `Password`) VALUES ('" + SSN + "','" + name + "','" + email + "','" + phone + "','" + authority + "','" + user + "','" + pass + "')";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                newSQLcommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void PutIntoSQLEventTable(string name, string date, string location, string description)
        {
            if (OpenConnection() == true)
            {
                query = "INSERT INTO event (`Name`, `Date`, `Location`, `Description`) VALUES ('" + name + "','" + date + "','" + location + "','" + description + "')";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                newSQLcommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public string[] FindUser(string SSN)
        {
            string[] data = new string[8];

            if (OpenConnection() == true)
            {
                query = "SELECT * FROM users WHERE Social_security_number = '" + SSN + "'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                sqlReader = newSQLcommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    data[0] = sqlReader.GetValue(0).ToString();
                    data[1] = sqlReader.GetValue(1).ToString();
                    data[2] = sqlReader.GetValue(2).ToString();
                    data[3] = sqlReader.GetValue(3).ToString();
                    data[4] = sqlReader.GetValue(4).ToString();
                    data[5] = sqlReader.GetValue(5).ToString();
                    data[6] = sqlReader.GetValue(6).ToString();
                    data[7] = sqlReader.GetValue(7).ToString();
                }
                sqlReader.Close();
                CloseConnection();
            }
            return data;
        }

        public string[] FindEvent(string EventName)
        {
            string[] data = new string[4];

            if (OpenConnection() == true)
            {
                query = "SELECT * FROM event WHERE Name = '" + EventName + "'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                sqlReader = newSQLcommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    data[0] = sqlReader.GetValue(0).ToString();
                    data[1] = sqlReader.GetValue(1).ToString();
                    data[2] = sqlReader.GetValue(2).ToString();
                    data[3] = sqlReader.GetValue(3).ToString();
                }
                sqlReader.Close();
                CloseConnection();
            }
            return data;
        }

        public void UpdateUser(int id, string SSN, string name, string email, string phone, int authority, string user, string pass)
        {
            if (OpenConnection() == true)
            {
                query = "UPDATE users SET Social_security_number = '" + SSN + "', Name = '" + name + "', Email = '" + email + "', Phone = '" + phone + "', Authority = '" + authority + "', Username = '" + user + "', Password = '" + pass + "' WHERE ID = '" + id + "'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                newSQLcommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateEvent(int id, string name, string date, string location, string description)
        {
            if (OpenConnection() == true)
            {
                query = "UPDATE event SET ID = '" + id + "', Name = '" + name + "', Date = '" + date + "', Location = '" + location + "', Description = '" + description + "' WHERE ID = '" + id + "'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                newSQLcommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void DeleteUser(string SSN)
        {
            if (OpenConnection() == true)
            {
                query = "Delete FROM users WHERE Social_security_number LIKE '" + SSN + "'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                newSQLcommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void DeleteEvent(string id)
        {
            if (OpenConnection() == true)
            {
                query = "Delete FROM event WHERE ID LIKE '" + id + "'";
                newSQLcommand = new MySqlCommand(query, sqlConnection);
                newSQLcommand.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
