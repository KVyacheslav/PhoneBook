using System.Collections.Generic;
using WebApiPhoneBook.Data;

namespace WebApiPhoneBook.Interfaces
{
    public interface IPersonData
    {
        IEnumerable<Person> GetPeople();
        Person GetPersonById(int? id);
        void AddPerson(Person person);
        void RemovePerson(Person person);
        void RemovePerson(int? id);
        void EditPerson(Person person);
        Person InfoPerson(int? id);
    }
}
