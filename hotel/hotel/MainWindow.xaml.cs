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
            controler.regShow();
        }
        private void minus_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            controler.deleteWindow();
        }
        private void maybe_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           controler. regShow();
        }
        private void all_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            controler.all_guest();
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
