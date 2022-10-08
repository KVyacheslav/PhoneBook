using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using WebApiPhoneBook.Interfaces;

namespace WebApiPhoneBook.Data
{
    public class NullPerson : IPerson
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

        private NullPerson()
        {
            this.FirstName = "Null";
            this.MiddleName = "Null";
            this.LastName = "Null";
            this.PhoneNumber = "Null";
            this.Address = "Null";
            this.Description = "Null";
        }

        static public NullPerson Create()
        {
            return new NullPerson();
        }
    }
}
