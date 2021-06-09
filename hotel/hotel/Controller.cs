using MySqlCommands;
using System.Collections.Generic;
using DeleteController;
using hotel;
using System.Data;

namespace MainController
{
    public class Controller
    {
        private DB database;
        DataTable table = new DataTable("ParentTable");
        DataColumn column;
        DataRow row;
        private DataSet dataSet;
        public void all_guest()
        {
            UsersWindow newer = new UsersWindow(this, database.Grub());
            newer.Show();
        }
        public void regShow()
        {
            Registration reg = new Registration(this);
            reg.ShowDialog();
        }

        public Controller()
        {
            database = new DB();

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "surname";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "name";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "gender";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "birthdate";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "pasport_s";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "pasport_n";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "phone";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "arrival_date";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "departure_date";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "number";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["id"];
            table.PrimaryKey = PrimaryKeyColumns;
        }
        public DataTable GenTable(List<string> st)
        {

            st.ForEach(delegate (string s)
            {

                string[] subs = s.Split(' ');

                row = table.NewRow();
                row["id"] = subs[0];
                row["surname"] = subs[1];
                row["name"] = subs[2];
                row["gender"] = subs[3];
                row["birthdate"] = subs[4];
                row["pasport_s"] = subs[5];
                row["pasport_n"] = subs[6];
                row["phone"] = subs[7];
                row["arrival_date"] = subs[8];
                row["departure_date"] = subs[9];
                row["number"] = subs[10];

                table.Rows.Add(row);
                //16 Riders of Apocalypse female 01.01.1000 0:00:00 7068 3485607 66666666 21.06.2015 0:00:00 31.10.2015 0:00:00 666 6
                //human.id, human.surname, human.name, gender.title, human.birthdate,human.pasport_s, human.pasport_n,human.phone, interval_arrive.arrival_date, interval_arrive.departure_date, room.number, room.capacity
            });
            dataSet = new DataSet();
            dataSet.Tables.Add(table);

            return table;
        }
        public Controller(bool z)
        {
            //Заглушка? Кoстыль? Пофиг? да
        }

        public bool AddPersons(string surname, string name, string sex, string birthday, int age, string Serial, string Serial_nums, string telephone, string room, string num, string input, string output)
        {
            database.insert(surname, name, sex, birthday, age, Serial, Serial_nums, telephone, room, num,  input, output);
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
