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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Маусенбаев_Мусин
{
    /// <summary>
    /// Логика взаимодействия для Autorizatia.xaml
    /// </summary>
    public partial class Autorizatia : Window
    {
        public static List<User> Users = new List<User>();
        public Autorizatia()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox2.Password;
            string confirmPassword = PasswordBox.Password;
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            User user = Users.Find(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Успешный вход");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Regestracia reg = new Regestracia();
            reg.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

