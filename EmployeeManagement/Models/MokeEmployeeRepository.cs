using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MokeEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MokeEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name ="Ahmed",Department="IT",Email="Ahmed@gmail.com"},
                new Employee(){Id = 2, Name ="Mohamed",Department ="HR",Email="Mohamed@gmail.com"},
                 new Employee(){Id = 3, Name ="Basem",Department ="IT",Email="Basem@gmail.com"},
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
