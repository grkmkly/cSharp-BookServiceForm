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
        //async public Task<List<T>> GetValues<T>()
        //{
        //        HttpClient client = new HttpClient();
        //        var response = await client.GetAsync("http://localhost:8080/getbooks");
        //        string responseBody = await response.Content.ReadAsStringAsync();
        //        List<T> data = JsonConvert.DeserializeObject<List<T>>(responseBody);
        //        return data;
        //}
        async public Task<Respon> PostSignin(User u)
        {
            HttpClient client = new HttpClient();
            User user1 = new User(u.username,u.password);
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
            User user1 = new User(u.username,u.password);
            var jsonPaylod = JsonConvert.SerializeObject(user1);
            HttpContent content = new StringContent(jsonPaylod, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:8080/registeruser", content);
            string result = await response.Content.ReadAsStringAsync();
            Respon data = JsonConvert.DeserializeObject<Respon>(result);
            return data;
        }
    }
    public class Book
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string pages { get; set; }
        public string author { get; set; }
        public string topic { get; set; }
    }
    public class User
    {
        public string _id { get; set;}
        public string username { get; set;}
        public string password { get; set;}
        public List<Book> books { get; set; }
        public User()
        {

        }
        public User(string username ,string password)
        {
            this.username = username;
            this.password = password;
        }
    }
    public class Respon
    {
        public bool isActive { get; set; }
    }
}
