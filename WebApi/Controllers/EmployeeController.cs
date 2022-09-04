using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRep _employeeRep;
        public EmployeeController(IEmployeeRep employeeRep)
        {
            _employeeRep = employeeRep;
        }

        [Route("getempid")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var emps = _employeeRep.GetEmployee(Id);
            return Ok(emps);
        }
   
        [HttpGet]
        public IActionResult Get()
        {
            var emps = _employeeRep.GetAllEmployee();
            return Ok(emps);
        }


        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var newEmp = _employeeRep.Add(employee);
            return Ok(newEmp);
        }


        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            var newEmp = _employeeRep.Update(employee);
            return Ok(newEmp);
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var newEmp = _employeeRep.Delete(Id);
            return Ok(newEmp);
        }


    }
}
