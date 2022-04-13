using CallingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CallingApi.Controllers
{
    public class StudentController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();

        Student _student = new Student();
        List<Student> _students = new List<Student>();

        public StudentController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<List<Student>> GetAllStudent()
        {
            _students = new List<Student>();

            using(var httpClient=new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/all"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _students = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
                }
            }


            return _students;
        }


        [HttpGet]
        public async Task<Student> GetByID(int studentID)
        {
            _student = new Student();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/" + studentID))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _student = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }


            return _student;
        }

        [HttpPost]
        public async Task<Student> AddUpdate(Student student)
        {
            _student = new Student();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(student),Encoding.UTF8,"application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44351/api/Student/all", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _student = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }


            return _student;
        }


        [HttpDelete]
        public async Task<string> Delete(int studentID)
        {
            string message = "";
      
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44351/api/Student/" + studentID))
                {
                    message = await response.Content.ReadAsStringAsync();
                }
            }


            return message;
        }
    }
}
