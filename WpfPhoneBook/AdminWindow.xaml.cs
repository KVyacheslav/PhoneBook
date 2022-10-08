using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfPhoneBook.Data;
using WpfPhoneBook.Model;

namespace WpfPhoneBook
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private static PersonDataApi api;
        private static Person abonent;

        public AdminWindow()
        {
            InitializeComponent();
            api = new PersonDataApi();
            lvAbonents.ItemsSource = api.GetPeople();
        }

        private void OnCreate(object sender, RoutedEventArgs e)
        {
            var isEmpty = string.IsNullOrEmpty(tbFirstName.Text.Trim());
            isEmpty = isEmpty && string.IsNullOrEmpty(tbLastName.Text.Trim());
            isEmpty = isEmpty && string.IsNullOrEmpty(tbMiddleName.Text.Trim());
            isEmpty = isEmpty && string.IsNullOrEmpty(tbPhoneNumber.Text.Trim());
            isEmpty = isEmpty && string.IsNullOrEmpty(tbAddress.Text.Trim());
            isEmpty = isEmpty && string.IsNullOrEmpty(tbDescr.Text.Trim());

            if (isEmpty)
                return;

            var person = new Person();
            person.FirstName = tbFirstName.Text;
            person.LastName = tbLastName.Text;
            person.MiddleName = tbMiddleName.Text;
            person.PhoneNumber = tbPhoneNumber.Text;
            person.Address = tbAddress.Text;
            person.Description = tbDescr.Text;

            api.AddPerson(person);
            OnRefresh(sender, e);
        }

        private void OnRefresh(object sender, RoutedEventArgs e)
        {
            lvAbonents.ItemsSource = api.GetPeople();
        }

        private void OnDelete(object sender, RoutedEventArgs e)
        {
            if (abonent != null)
            {
                api.RemovePerson(abonent);
                OnRefresh(sender, e);
            }
        }

        private void lvAbonents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvAbonents.SelectedItem != null)
            {
                abonent = lvAbonents.SelectedItem as Person;
                tbFirstName.Text = abonent.FirstName;
                tbLastName.Text = abonent.LastName;
                tbAddress.Text = abonent.Address;
                tbDescr.Text = abonent.Description;
                tbMiddleName.Text = abonent.MiddleName;
                tbPhoneNumber.Text = abonent.PhoneNumber;
            }
        }

        private void OnEdit(object sender, RoutedEventArgs e)
        {
            if (abonent != null)
            {
                abonent.FirstName = tbFirstName.Text;
                abonent.LastName = tbLastName.Text;
                abonent.MiddleName = tbMiddleName.Text;
                abonent.PhoneNumber = tbPhoneNumber.Text;
                abonent.Address = tbAddress.Text;
                abonent.Description = tbDescr.Text;
                api.EditPerson(abonent);
                OnRefresh(sender, e);
            }
        }
    }
}
