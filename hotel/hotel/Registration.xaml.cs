using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MainController;

namespace hotel
{
    public partial class Registration : Window
    {
        Controller con = new Controller(true);
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(con.AddPersons(surname.Text, name.Text, Sex.Text, birthday.Text, System.Convert.ToInt32(age.Text), Serial.Text, Serial_nums.Text, telephone.Text, room.Text, num.Text, input.Text, output.Text))
            {
                MessageBox.Show("Запись произведена успешно", "Успех");
                this.Close();
            }
            
        }

        private void age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string strTB = tb.Text;
            if (!(char.IsDigit(e.Text, 0) || e.Text == "." ||   e.Text == "," &&  (strTB + e.Text).Count(c => c == '.') <= 1 &&  (strTB + e.Text).Count(c => c == ',') <= 1 ))
            {
                e.Handled = true;
            }
        }

        private void input_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string strTB = tb.Text;
            if (!(char.IsDigit(e.Text, 0) || e.Text == "." || e.Text == "," && (strTB + e.Text).Count(c => c == '.') <= 1 && (strTB + e.Text).Count(c => c == ',') <= 1))
            {
                e.Handled = true;
            }
        }

        private void output_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string strTB = tb.Text;
            if (!(char.IsDigit(e.Text, 0) || e.Text == "." || e.Text == "," && (strTB + e.Text).Count(c => c == '.') <= 1 && (strTB + e.Text).Count(c => c == ',') <= 1))
            {
                e.Handled = true;
            }
        }
    }
}
