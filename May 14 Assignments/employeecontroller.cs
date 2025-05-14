using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "this is the employee index";
        }
        public string FirstName()
        {
            return "My first name is Manjunath";
        }
        public string LastName()
        {
            return "My last name is Pallala";
        }
    }
}