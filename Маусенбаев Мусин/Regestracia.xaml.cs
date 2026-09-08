using Microsoft.SqlServer.Server;
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
using System.Windows.Shapes;

namespace Маусенбаев_Мусин
{
    /// <summary>
    /// Логика взаимодействия для Regestracia.xaml
    /// </summary>
    public partial class Regestracia : Window
    {
        public Regestracia()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        { 
                Autorizatia naz = new Autorizatia();
                naz.Show();
                this.Close();
        }

        private void RegisterUser()
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox2.Password;
            string confirmPassword = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            // Проверка на повторяющийся логин
            if (Autorizatia.Users.Exists(u => u.Login == login))
            {
                MessageBox.Show("Этот логин уже занят");
                return;
            }

            Autorizatia.Users.Add(new User { Login = login, Password = password });
            MessageBox.Show("Регистрация успешна");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Autorizatia nazad = new Autorizatia();
            nazad.Show();
            this.Close();
        }
    }
}
