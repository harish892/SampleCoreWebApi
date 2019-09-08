using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDBContext _context;

        public EmployeeController(EmployeeDBContext context)
        {
            //_context = context;

            //if (_context.Employees.Count() == 0)
            //{
            //    // Create a new TodoItem if collection is empty,
            //    // which means you can't delete all TodoItems.
            //    _context.Employees.Add(new Employee
            //    {
            //        EmpId = 2,
            //        Fname = "Santosh",
            //        Lname = "Singh"
            //    });
            //}
        }

        // GET: api/Todo
        [HttpGet]
        public List<Employee> GetEmployee()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee {
                //EmpId = 2,
                //Fname = "Santosh",
                //Lname = "Singh",
                //City ="Bangalore"
            });
            return empList;
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmpById(int id)
        {
            var emp = await _context.Employees.FindAsync(id);

            if (emp == null)
            {
                return NotFound();
            }

            return emp;
        }
    }
}