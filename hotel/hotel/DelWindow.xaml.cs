using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hotel
{
    /// <summary>
    /// Логика взаимодействия для DelWindow.xaml
    /// </summary>
    /// 
    public partial class DelController
    {
        private DataSet dataSet;

        DataTable table = new DataTable("ParentTable");
        DataColumn column;
        DataRow row;

        public DelController()
        {
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

        public DataTable GenTable(List<String> st)
        {

            st.ForEach(delegate (String s)
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

    public partial class DelWindow : Window
    {
        public DelWindow()
        {
            List<String> names = new List<String>();
            names.Add("16 Riders of Apocalypse female 01.01.1000 0:00:00 7068 3485607 66666666 21.06.2015 0:00:00 31.10.2015 0:00:00 666 6");
            names.Add("6 OLOLO PSfF male 19.05.2019 0:00:00 12345 576472 89452621 21.03.2021 0:00:00 22.03.2021 0:00:00 89 1");
            
            InitializeComponent();
            DelController hernya = new DelController();
            DataTable table = hernya.GenTable(names);
            //Это говно заменить на массив строк, что придет в результате запроса   ^
            CustomerGrid.DataContext = table;

            string nopr = CustomerGrid[0, CustomerGrid.CurrentRow.Index].Value.ToString();
            MessageBox.Show(nopr);
        }
    }
}
