using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MySqlCommands
{
    public class DB
    {
        // Пример использования класса  
        // MySqlCommands.DB comm = new MySqlCommands.DB();
        // comm.delete("gender", "`id` > '2'");
        MySqlConnection connection = new MySqlConnection("server=localhost;" + "port=3306;" + "username=root;" + "password= ;" + "database=hotel");
        private void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        private void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public void insert(string table, string columns, string values)
        {
            //Пример использования: comm.insert("gender","`title`","'d'");
            OpenConnection();
            string querygeder = "INSERT INTO " + table + " (" + columns + ") VALUES (" + values + ")";
            MySqlCommand command = new MySqlCommand(querygeder, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void update(string table, string set, string where)
        {
            //Пример использования: comm.update("gender", "title = 'IGOR'", "`id` = '4'");
            OpenConnection();
            string querygeder = "UPDATE " + table + " SET " + set + " WHERE " + where;
            MySqlCommand command = new MySqlCommand(querygeder, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void delete(string table, string where)
        {
            //Пример использования: comm.delete("gender", "`id` > '2'");
            OpenConnection();
            string querygeder = "DELETE FROM " + table + " WHERE " + where;
            MySqlCommand command = new MySqlCommand(querygeder, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public string selectWhere(string table, string column, string where)
        {
            //Пример использования: 
            OpenConnection();
            string querygeder = "SELECT " + column + " FROM " + table + " WHERE " + where;
            MySqlCommand command = new MySqlCommand(querygeder, connection);
            command.ExecuteNonQuery();
            string str = command.ExecuteScalar().ToString();
            CloseConnection();
            return str;

        }
        public List<string> select(string table, string column)
        {
            int iterattor = 0;
            //Пример использования: 
            OpenConnection();
            string querygeder = "SELECT " + column + " FROM " + table;
            MySqlCommand command = new MySqlCommand(querygeder, connection);

            using MySqlDataReader rdr = command.ExecuteReader();

            string name = "";
            List<string> masString = new List<string>();
            while (rdr.Read())
            {
                masString.Add(System.Convert.ToString(rdr[0])); //rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5] + " " + rdr[6] + " " + rdr[7] + " " + rdr[8] + " " + rdr[9] + " " + rdr[10] + " " + rdr[11] + " "
            }
            CloseConnection();
            return masString;
        }
    }
}
