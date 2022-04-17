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
        ////////
        public async Task<IActionResult> Index()
        {
            List<Student> studentList = new List<Student>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/all"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    studentList = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
                }
            }
            return View(studentList);
        }

        ////////
       
        public ViewResult GetStudent() => View();

        [HttpPost]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = new Student();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/" + id))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        student = JsonConvert.DeserializeObject<Student>(apiResponse);

                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(student);
        }

        ////////////

        public ViewResult AddStudent() => View();

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            Student receivedStudent = new Student();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44351/api/Student/create", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedStudent = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return View(receivedStudent);
        }

        ///////

        public async Task<IActionResult> UpdateStudent(int id)
        {
            Student student = new Student();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    student = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStudent(Student student)
        {
            Student receivedStudent = new Student();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://localhost:44351/api/Student/edit", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedStudent = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return Redirect("/student/index");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteStudent(int studentID)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44351/api/Student/" + studentID))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return Redirect("/student/index");
        }

    }

    #region
    //HttpClientHandler _clientHandler = new HttpClientHandler();

    //Student _student = new Student();
    //List<Student> _students = new List<Student>();

    //public StudentController()
    //{
    //    _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
    //}
    //public IActionResult Index()
    //{
    //    return View();
    //}


    //[HttpGet]
    //public async Task<List<Student>> GetAllStudent()
    //{
    //    _students = new List<Student>();

    //    using(var httpClient=new HttpClient(_clientHandler))
    //    {
    //        using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/all"))
    //        {
    //            string apiResponse = await response.Content.ReadAsStringAsync();
    //            _students = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
    //        }
    //    }


    //    return _students;
    //}


    //[HttpGet]
    //public async Task<Student> GetByID(int studentID)
    //{
    //    _student = new Student();

    //    using (var httpClient = new HttpClient(_clientHandler))
    //    {
    //        using (var response = await httpClient.GetAsync("https://localhost:44351/api/Student/" + studentID))
    //        {
    //            string apiResponse = await response.Content.ReadAsStringAsync();
    //            _student = JsonConvert.DeserializeObject<Student>(apiResponse);
    //        }
    //    }


    //    return _student;
    //}

    //[HttpPost]
    //public async Task<Student> AddUpdate(Student student)
    //{
    //    _student = new Student();

    //    using (var httpClient = new HttpClient(_clientHandler))
    //    {
    //        StringContent content = new StringContent(JsonConvert.SerializeObject(student),Encoding.UTF8,"application/json");

    //        using (var response = await httpClient.PostAsync("https://localhost:44351/api/Student/all", content))
    //        {
    //            string apiResponse = await response.Content.ReadAsStringAsync();
    //            _student = JsonConvert.DeserializeObject<Student>(apiResponse);
    //        }
    //    }


    //    return _student;
    //}


    //[HttpDelete]
    //public async Task<string> Delete(int studentID)
    //{
    //    string message = "";

    //    using (var httpClient = new HttpClient(_clientHandler))
    //    {
    //        using (var response = await httpClient.DeleteAsync("https://localhost:44351/api/Student/" + studentID))
    //        {
    //            message = await response.Content.ReadAsStringAsync();
    //        }
    //    }


    //    return message;
    //}
    #endregion
}

