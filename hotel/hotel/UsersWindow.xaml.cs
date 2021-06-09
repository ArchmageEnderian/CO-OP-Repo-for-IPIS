using MainController;
using System.Windows;
using System.Collections.Generic;
using System.Data;

namespace hotel
{
    public partial class UsersWindow : Window
    {
        public UsersWindow(Controller controler, List<string> names)
        {
            InitializeComponent();
            DataTable table = controler.GenTable(names);
            CustomerGrid.DataContext = table;
        }
    }
}
