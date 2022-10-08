using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WebPhoneBook.Interfaces;
using WebPhoneBook.Models;

namespace WebPhoneBook.Data
{
    public class PersonDataApi : IPersonData
    {
        private HttpClient client { get; set; }
        private string url { get; set; }

        public PersonDataApi()
        {
            client = new HttpClient();
            url = "http://localhost:50000/api/values";
        }

        public void AddPerson(Person person)
        {
            var r = client.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public void EditPerson(Person person)
        {
            var putUrl = url + $"/{person.Id}";
            var r = client.PutAsync(
                requestUri: putUrl,
                content: new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public IEnumerable<Person> GetPeople()
        {
            string json = client.GetStringAsync(url).Result;

            return JsonConvert.DeserializeObject<IEnumerable<Person>>(json);
        }

        public Person GetPersonById(int? id)
        {
            string json = client.GetStringAsync(url + $"/{id}").Result;

            return JsonConvert.DeserializeObject<Person>(json);
        }

        public void RemovePerson(Person person)
        {
            var r = client.DeleteAsync(
                requestUri: url + $"/{person.Id}"                
                ).Result;
        }

        public void RemovePerson(int? id)
        {
            var r = client.DeleteAsync(
                requestUri: url + $"/{id}"
                ).Result;
        }
    }
}
