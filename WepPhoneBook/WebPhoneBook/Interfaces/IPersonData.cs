using WebPhoneBook.Models;
using System.Collections.Generic;

namespace WebPhoneBook.Interfaces
{
    public interface IPersonData
    {
        IEnumerable<Person> GetPeople();
        Person GetPersonById(int? id);
        void AddPerson(Person person);
        void RemovePerson(Person person);
        void RemovePerson(int? id);
        void EditPerson(Person person);
    }
}
