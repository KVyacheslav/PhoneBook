using System.ComponentModel.DataAnnotations;

namespace WebPhoneBook.Models
{
    public class Person
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