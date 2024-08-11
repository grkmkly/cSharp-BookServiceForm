using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;

namespace httpServices
{
    public class httpClass
    {
        async public Task<Respon> PostSignin(User u)
        {
            HttpClient client = new HttpClient();
            User user1 = new User(u.Username,u.Password);
            var jsonPayload = JsonConvert.SerializeObject(user1);
            HttpContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:8080/signinuser", content);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            Respon data = JsonConvert.DeserializeObject<Respon>(result);
            return data;
        }
        async public Task<Respon> PostRegister(User u)
        {

            HttpClient client = new HttpClient();
            User user1 = new User(u.Username,u.Password);
            var jsonPaylod = JsonConvert.SerializeObject(user1);
            HttpContent content = new StringContent(jsonPaylod, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:8080/registeruser", content);
            string result = await response.Content.ReadAsStringAsync();
            Respon data = JsonConvert.DeserializeObject<Respon>(result);
            return data;
        }
        async public Task<User> getUserbyId(string id)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("http://localhost:8080/getuser/{0}", id);
            var response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();
            User data = JsonConvert.DeserializeObject<User>(result);
            return data;
        }
        async public Task<List<Book>> getBooks<Book>()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://localhost:8080/getbooks");
            string result = await response.Content.ReadAsStringAsync();
            List<Book> data = JsonConvert.DeserializeObject<List<Book>>(result);
            return data;
        }
        async public Task<Respon> addbookUser(User u , Book b)
        {
            HttpClient client = new HttpClient();
            var usersbook = new Usersbook();
            usersbook.userID = u.ObjectId;
            usersbook.bookID = b.ObjectID;
            var jsonPayload = JsonConvert.SerializeObject(usersbook);
            HttpContent content = new StringContent(jsonPayload,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("http://localhost:8080/addbookuser", content);
            string result = await response.Content.ReadAsStringAsync();
            Respon data = JsonConvert.DeserializeObject<Respon>(result);
            return data;
        }
        async public Task<Respon> CreateBook(Book b)
        {
            HttpClient client = new HttpClient();
            var jsonPayload = JsonConvert.SerializeObject(b);
            HttpContent content = new StringContent (jsonPayload,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("http://localhost:8080/createbook", content);
            string result = await response.Content.ReadAsStringAsync();
            Respon data = JsonConvert.DeserializeObject<Respon>(result);
            return data;
        }
    }
    public class Book
    {
        public string ObjectID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Pages { get; set; }
        public string Topic { get; set; }
    }
    public class User
    {
        public string ObjectId { get; set;}
        public string Username { get; set;}
        public string Password { get; set;}
        public List<Book> Books { get; set; }
        public User()
        {

        }
        public User(string username ,string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
    public class Respon
    {
        public bool isActive { get; set; }
        public string ID { get; set; }
        public string Token { get; set; }
        public string username { get; set;}
    }
    public class Usersbook{
        public string userID { get; set; }
        public string bookID { get; set; }
    }
}
