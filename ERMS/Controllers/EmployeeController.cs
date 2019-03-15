using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERMS.Controllers
{
        
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

        // GET: api/<controller>
        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<TbEmployee> Index()
        {
            return objemployee.GetAllEmployees();
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create(TbEmployee emp)
        {
            return objemployee.AddEmployee(emp);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public TbEmployee Details(int id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit(TbEmployee employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("api/Employee/GetCityList")]
        public IEnumerable<TbCities> Details()
        {
            return objemployee.GetCities();
        }
    }
}
