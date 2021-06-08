using MySqlCommands;
using System.Collections.Generic;
using DeleteController;
using hotel;

namespace MainController
{
    public class Controller
    {
        private DB database;
        public Controller()
        {
            database = new DB();
        }
        public Controller(bool z)
        {
            //Заглушка? Кoстыль? Пофиг? да
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

        public void deleteWindow()
        {
            DelWindow delView = new DelWindow();
            DelController delCon = new DelController(delView, database);
            delView.seter(delCon);
            delCon.start();
        }
        
    }
}
