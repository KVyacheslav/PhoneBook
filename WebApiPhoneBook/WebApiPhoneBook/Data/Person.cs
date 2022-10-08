using System.ComponentModel.DataAnnotations;
using WebApiPhoneBook.Interfaces;

namespace WebApiPhoneBook.Data
{
    public class Person : IPerson
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "���")]
        public string FirstName { get; set; }

        [Required, Display(Name = "�������")]
        public string LastName { get; set; }

        [Required, Display(Name = "��������")]
        public string MiddleName { get; set; }

        [Required, Display(Name = "����� ��������")]
        public string PhoneNumber { get; set; }

        [Required, Display(Name = "�����")]
        public string Address { get; set; }

        [Required, Display(Name = "��������")]
        public string Description { get; set; }
    }
}