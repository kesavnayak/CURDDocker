using Microsoft.AspNetCore.Mvc;
using ServerApp.Data;
using ServerApp.Services;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await Task.FromResult(_employeeService.GetEmployeeDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee user = _employeeService.GetEmployeeData(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Employee employee)
        {
            _employeeService.AddEmployee(employee);
        }
        [HttpPut]
        public void Put(Employee employee)
        {
            _employeeService.UpdateEmployeeDetails(employee);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
            return Ok();
        }
    }
}
