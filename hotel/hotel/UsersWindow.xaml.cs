using MainController;
using System.Windows;
using System.Collections.Generic;

namespace hotel
{
    public partial class UsersWindow : Window
    {
        public UsersWindow(Controller controler)
        {
            InitializeComponent();
            List<string> qwe = controler.ShowUsers();
            foreach (string str in qwe)
            TextBox.AppendText(System.Convert.ToString(str));
        }
    }
}
