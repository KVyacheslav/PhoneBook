using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfPhoneBook.AuthApp;
using WpfPhoneBook.Model;
using static System.Net.Mime.MediaTypeNames;

namespace WpfPhoneBook.Data
{
    public class UsersDataApi
    {
        private IEnumerable<string> names;
        private HttpClient client;
        private string url;

        public UsersDataApi()
        {
            client = new HttpClient();
            url = "https://localhost:50001/api/account";
            InitNames(url);
        }

        public void InitNames(string url)
        {
            var r = client.GetAsync(url + "/users").Result;
            names = r.Content.ReadAsStringAsync().Result
                .Replace("[", "")
                .Replace("]", "")
                .Replace("\"", "")
                .Split(',');
        }

        public IEnumerable<string> GetNames()
        {
            return names;
        }

        public bool ExistUser(string userName)
        {
            return names.Contains(userName);
        }

        public bool IsLogin(string userName, string password)
        {
            var userLogin = new UserLogin { UserName = userName, Password = password };
            var stringContent = JsonConvert.SerializeObject(userLogin);
            var r = client.PostAsync(
                requestUri: url,
                content: new StringContent(stringContent, Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
            return bool.Parse(r.Content.ReadAsStringAsync().Result);
        }

        public bool IsAdmin(string userName)
        {
            var userLogin = new UserLogin { UserName = userName };
            var stringContent = JsonConvert.SerializeObject(userLogin);
            var r = client.PostAsync(
                    requestUri: url + $"/{userName}",
                    content: new StringContent(stringContent, Encoding.UTF8,
                    mediaType: "application/json")
            ).Result;

            return r.Content.ReadAsStringAsync().Result == "Admin";
        }
    }
}
