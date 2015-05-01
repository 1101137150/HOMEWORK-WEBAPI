using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApp.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }

        [HttpGet]
        [ActionName("byId")]
        public IList<Employee> GetEmployeeByName(string Name)
        {
            IList<Employee> employee = EmployeeService.GetEmployeeByName(Name);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }
    }
}
