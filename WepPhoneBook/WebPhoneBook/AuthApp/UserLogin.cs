using System.ComponentModel.DataAnnotations;

namespace WebPhoneBook.AuthApp
{
    public class UserLogin
    {
        [Required, MaxLength(20)]
        public string UserName{ get; set; }

        [Required, DataType(DataType.Password)]
        public string Password{ get; set; }

        public string ReturnUrl { get; set; }
    }
}
