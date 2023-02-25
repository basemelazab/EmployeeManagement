using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository=employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(3).Name;
        }
        public ObjectResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return new ObjectResult(model);
        }
    }
}
