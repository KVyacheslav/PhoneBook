using System.ComponentModel.DataAnnotations;

namespace WebPhoneBook.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required, Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Required, Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Required, Display(Name = "Адрес")]
        public string Address { get; set; }

        [Required, Display(Name = "Описание")]
        public string Description { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string middleName,
                string phoneNumber, string address, string description)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Description = description;
        }

        public Person(int id, string firstName, string lastName, string middleName, 
                string phoneNumber, string address, string description)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Description = description;   
        }
    }
}