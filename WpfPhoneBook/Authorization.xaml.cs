using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
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
using WpfPhoneBook.AuthApp;
using WpfPhoneBook.Data;
using WpfPhoneBook.Model;

namespace WpfPhoneBook
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        private static UsersDataApi usersApi;
        private static IEnumerable<string> names;

        public Authorization()
        {
            InitializeComponent();
            try
            {
                usersApi = new UsersDataApi();
                names = usersApi.GetNames();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Authorize(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(acb_Name.Text.Trim()) && !string.IsNullOrEmpty(password.Password.Trim()))
            {
                if (usersApi.ExistUser(acb_Name.Text))
                {
                    if (usersApi.IsLogin(acb_Name.Text, password.Password))
                    {
                        if (usersApi.IsAdmin(acb_Name.Text))
                        {
                            new AdminWindow().Show();
                        }    
                        else
                        {
                            new MainWindow().Show();
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверно введены данные");
                    }
                }
            }
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AutoCompleteBox_Populating(object sender, PopulatingEventArgs e)
        {
            try
            {
                string tempName = acb_Name.Text;
                if (names != null)
                {
                    acb_Name.ItemsSource = names;
                    acb_Name.PopulateComplete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
