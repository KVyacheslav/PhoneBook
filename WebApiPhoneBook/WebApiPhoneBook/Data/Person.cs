using System.ComponentModel.DataAnnotations;
using WebApiPhoneBook.Interfaces;

namespace WebApiPhoneBook.Data
{
    public class Person : IPerson
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
    }
}