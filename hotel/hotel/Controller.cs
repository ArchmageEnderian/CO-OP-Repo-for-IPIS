using MySqlCommands;
using System.Collections.Generic;
using System.Windows;

namespace MainController
{
    public class Controller
    {
        private DB database;
        public Controller()
        {
            database = new DB();
        }

        public bool AddPersons(string surname, string name, string sex, string birthday, int age, string Serial, string Serial_nums, string telephone, string room, string num, string input, string output)
        {
            //database.insert();
            return true;
        }

        public List<string> ShowUsers()
        {
            return database.GetUsers();
        }
/*
SELECT human.surname, human.name, gender.title, human.birthdate,human.pasport_s, human.pasport_n,human.phone, interval_arrive.arrival_date, interval_arrive.departure_date, room.number, room.capacity
FROM client JOIN human ON human.id = client.human_id
JOIN check_settling ON check_settling.id = client.check_id
JOIN interval_arrive ON interval_arrive.id = check_settling.interval_id
JOIN room ON room.id = check_settling.room_id
JOIN gender ON gender.id = human.gender_id
*/
        
    }
}
