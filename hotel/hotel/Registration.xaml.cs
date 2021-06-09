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
        Controller con;
        public Registration(Controller contr)
        {
            InitializeComponent();
            con = contr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string surname1 = surname.Text;
            string name1 = name.Text;
            string sex = Sex.Text;
            string birthday1 = birthday.Text;
            int age1 = System.Convert.ToInt32(age.Text);
            string Serial1 = Serial.Text;
            string Serial_nums1 = Serial_nums.Text;
            string telephone1 = telephone.Text;
            string room1 = room.Text;
            string num1 = num.Text;
            string input1 = input.Text;
            string output1 = output.Text;
            if (con.AddPersons(surname1, name1, sex, birthday1, age1, Serial1, Serial_nums1, telephone1, room1, num1, input1, output1))
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
    }
}
