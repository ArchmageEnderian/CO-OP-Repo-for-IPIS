using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hotel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void new_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Це кнопка new_guest");
        }
        private void minus_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Це кнопка minus_guest");
        }
        private void maybe_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Це кнопка maybe_guest");
        }
        private void all_guest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Це кнопка all_guest");
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
