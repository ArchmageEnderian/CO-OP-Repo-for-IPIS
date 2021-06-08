using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MainController;


namespace hotel
{
    public partial class MainWindow : Window
    {
        Controller controler = new Controller();
        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void new_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
        private void minus_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DelWindow del = new DelWindow();
            del.ShowDialog();
        }
        private void maybe_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
        private void all_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UsersWindow newer = new UsersWindow(controler);
            newer.Show();
        }
        private void MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock btn = (TextBlock)sender;
            btn.Background = Brushes.AntiqueWhite;
        }
        private void MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock btn = (TextBlock)sender;
            btn.Background = Brushes.White;
        }
        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
