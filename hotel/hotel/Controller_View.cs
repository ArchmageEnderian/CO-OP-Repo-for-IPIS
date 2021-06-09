using System;
using System.Collections.Generic;
using System.Data;
using MySqlCommands;
using hotel;

namespace DeleteController
{
    public partial class DelController
    {
        private DataSet dataSet;
        private DelWindow wind;

        DataTable table = new DataTable("ParentTable");
        DataColumn column;
        DataRow row;
        private DB database;
        public void start()
        {
            wind.start(database.Grub());
            wind.Show();
        }
        public void useId(int id)
        {
            database.delete(id);
        }
        public DelController(DelWindow window, DB data)
        {
            database = data;
            wind = window;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "family";
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
                row["family"] = subs[1];
                row["number"] = subs[subs.Length - 2];

                table.Rows.Add(row);

            });
            dataSet = new DataSet();
            dataSet.Tables.Add(table);

            return table;
        }
    }
}
