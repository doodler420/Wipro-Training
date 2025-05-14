using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "this is the student index";
        }
        public string GetStudentName()
        {
            return "Student name is Manjunath";
        }
        public string GetStudentPhone()
        {
            return "Student phone is 123456789";
        }
    }
}