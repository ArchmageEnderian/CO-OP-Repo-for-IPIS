using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace MySqlCommands
{
    public class DB
    {
        private MySqlConnection connection;
        private List<string> allString;

        public DB()
        {
            connection = new MySqlConnection("server=localhost;" + "port=3306;" + "username=root;" + "password= root;" + "database=hotel");
            allString = select();
        }

        public List<string> Grub()
        {
            return allString;
        }

        public List<string> GetUsers()
        {
            return allString;
        }
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
            //Доделать
            OpenConnection();
            string querygeder = "INSERT INTO " + table + " (" + columns + ") VALUES (" + values + ")";
            MySqlCommand command = new MySqlCommand(querygeder, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void delete(string id)
        {
            //Пример использования: comm.delete("gender", "`id` > '2'");
            OpenConnection();
            string querygeder = "DELETE FROM human WHERE " + id;
            MySqlCommand command = new MySqlCommand(querygeder, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public List<string> select()
        {
            OpenConnection();
            string querygeder = "SELECT human.id, human.surname, human.name, gender.title, human.birthdate,human.pasport_s, human.pasport_n,human.phone, interval_arrive.arrival_date, interval_arrive.departure_date, room.number, room.capacity FROM client JOIN human ON human.id = client.human_id JOIN check_settling ON check_settling.id = client.check_id JOIN interval_arrive ON interval_arrive.id = check_settling.interval_id JOIN room ON room.id = check_settling.room_id JOIN gender ON gender.id = human.gender_id";
            MySqlCommand command = new MySqlCommand(querygeder, connection);

            using MySqlDataReader rdr = command.ExecuteReader();

            List<string> masString = new List<string>();
            while (rdr.Read())
            {
                masString.Add( System.Convert.ToString(rdr[0]) + " " + System.Convert.ToString(rdr[1]) + " " + System.Convert.ToString(rdr[2]) + " " + System.Convert.ToString(rdr[3]) + " " + System.Convert.ToString(rdr[4]) + " " + System.Convert.ToString(rdr[5]) + " " + System.Convert.ToString(rdr[6]) + " " + System.Convert.ToString(rdr[7]) + " " + System.Convert.ToString(rdr[8]) + " " + System.Convert.ToString(rdr[9]) + " " + System.Convert.ToString(rdr[10]) + " " + System.Convert.ToString(rdr[11]) + "\n"); 
                //rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5] + " " + rdr[6] + " " + rdr[7] + " " + rdr[8] + " " + rdr[9] + " " + rdr[10] + " " + rdr[11] + " "
            }
            CloseConnection();
            return masString;
        }
    }
}
