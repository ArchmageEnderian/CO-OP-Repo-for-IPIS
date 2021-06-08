using System;
using System.Data;
using System.Windows;
using System.Windows.Input;
using DeleteController;
using System.Collections.Generic;

namespace hotel
{
    /// <summary>
    /// Логика взаимодействия для DelWindow.xaml
    /// </summary>
    /// 
    public partial class DelWindow : Window
    {
        DelController contr;
        public void seter(DelController control)
        {
            contr = control;
        }
        public DelWindow()
        {
            InitializeComponent();
        }
        public void start(List<string> names)
        {
            DataTable table = contr.GenTable(names);
            CustomerGrid.DataContext = table;
        }
        private void NoButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int id = Convert.ToInt32(InputTextBox.Text);
        }
    }
}
