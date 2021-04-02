using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySqlCommands
{
    public class DB
    {
        // Пример использования класса  
        // MySqlCommands.DB comm = new MySqlCommands.DB();
        // comm.delete("gender", "`id` > '2'");
        MySqlConnection connection = new MySqlConnection("server=localhost;" + "port=3306;" + "username=root;" + "password= ;" + "database=hotel");
        void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        void CloseConnection()
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
            return command.ExecuteScalar().ToString();
            CloseConnection();
        }
        public string select(string table, string column)
        {
            //Пример использования: 
            OpenConnection();
            string querygeder = "SELECT " + column + " FROM " + table;
            MySqlCommand command = new MySqlCommand(querygeder, connection);

            using MySqlDataReader rdr = command.ExecuteReader();

            string name = "";
            while (rdr.Read())
            {
                name += rdr[0];
            }
            CloseConnection();
            return name;
        }
    }
}
