using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebPhoneBook.Context;
using Newtonsoft.Json.Linq;

namespace WebPhoneBook.Models
{
    //public static class Repository
    //{
    //    private static DataContext db = new DataContext();

    //    private static List<Person> people = new List<Person>();

    //    public static IEnumerable<Person> People => people;


        
    //    public static void LoadPeople()
    //    {
    //        people = db.People.ToList();
    //    }

    //    public static void AddPerson(Person person)
    //    {
    //        people.Add(person);
    //        db.People.Add(person);
    //        db.SaveChanges();
    //    }

    //    public static void RemovePerson(Person person)
    //    {
    //        people.Remove(person);
    //        db.People.Remove(db.People.First(p => p.Id == person.Id));
    //        db.SaveChanges();
    //    }

    //    public static void UpdatePerson(Person person)
    //    {
    //        db.People.Update(person);
    //        db.SaveChanges();
    //        people = db.People.ToList();
    //    }
    //}
}