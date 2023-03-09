using MaterialDesignColors.Recommended;
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

namespace AppUser1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass_1 = passbox_1.Password.Trim();
            string pass_2 = passbox_2.Password.Trim();
            string email = TextBoxEmail.Text.Trim().ToLower();
            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Поле логин должно быть больше 5 символов!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
 
            else if (pass_1.Length < 5)
            {
                passbox_1.ToolTip = "Поле пароль должно быть больше 5 символов";
                passbox_1.Background = Brushes.DarkRed;
                
            }

          
            else if (pass_2.Length < 5)
            {
                passbox_2.ToolTip = "Поле пароль должно быть больше 5 символов";
                passbox_2.Background = Brushes.DarkRed;
            }
            else if (pass_1 != pass_2)
            {
                passbox_2.ToolTip = "Поля пароль должны совпадать";
                passbox_2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Поле почта должно содержать символ @";
                TextBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                passbox_1.ToolTip = "";
                passbox_1.Background = Brushes.Transparent;
                passbox_2.ToolTip = "";
                passbox_2.Background = Brushes.Transparent;
                TextBoxEmail.ToolTip = "";
                TextBoxEmail.Background = Brushes.Transparent;
                MessageBox.Show("Вы зарегистрированы");
            }

        }

        
    }
}
