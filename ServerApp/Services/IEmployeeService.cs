using ServerApp.Data;

namespace ServerApp.Services
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public void AddEmployee(Employee employee);
        public void UpdateEmployeeDetails(Employee employee);
        public Employee GetEmployeeData(int id);
        public void DeleteEmployee(int id);
    }
}
