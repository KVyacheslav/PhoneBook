using System.Collections.Generic;
using WebApiPhoneBook.Context;
using WebApiPhoneBook.Interfaces;

namespace WebApiPhoneBook.Data
{
    public class PersonData : IPersonData
    {
        private readonly DataContext _context;

        public PersonData(DataContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public void EditPerson(Person person)
        {
            _context.People.Update(person);
            _context.SaveChanges();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People;
        }

        public Person GetPersonById(int? id)
        {
            return _context.People.Find(id);
        }

        public Person InfoPerson(int? id)
        {
            return _context.People.Find(id);
        }

        public void RemovePerson(Person person)
        {
            _context.People.Remove(person);
            _context.SaveChanges();
        }

        public void RemovePerson(int? id)
        {
            _context.Remove(InfoPerson(id));
            _context.SaveChanges();
        }
    }
}
