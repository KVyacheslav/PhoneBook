using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfPhoneBook.Core;

namespace WpfPhoneBook.Model
{
    public class Person : ObservableObject
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string phoneNumber;
        private string address;
        private string description;

        public int Id { get; set; }
        public string FirstName { get => firstName; set => Set(ref firstName, value); }
        public string LastName { get => lastName; set => Set(ref lastName, value); }
        public string MiddleName { get => middleName; set => Set(ref middleName, value); }
        public string PhoneNumber { get => phoneNumber; set => Set(ref phoneNumber, value); }
        public string Address { get => address; set => Set(ref address, value); }
        public string Description { get => description; set => Set(ref description, value); }
    }
}
