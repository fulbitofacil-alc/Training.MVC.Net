using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using MVC5Course.WebApi.Filters;
using MVC5Course.WebApi.Models;
using MVC5Course.WebApi.RequestFilters;

namespace MVC5Course.WebApi.Controllers
{

    public class EmployeesController : ApiController
    {
        private static IList<Employee> list = new List<Employee>()
        {
            new Employee
            {
                Id = 12345,
                FirstName = "Koopa",
                LastName = "Cunza",
                Department = new List<int>{1,2},
                Office = "Lima"
            },
            new Employee
            {
                Id = 12346,
                FirstName = "Ariel",
                LastName = "Cabrera",
                Department = new List<int>{1,2},
                Office = "Mendoza"
            },
            new Employee
            {
                Id = 12347,
                FirstName = "Ronaldinho",
                LastName = "Gaucho",
                Department =new List<int>{1,2},
                Office = "Lima"
            }

        };
        public IEnumerable<Employee> Get()
        {
            return list;
        }
        public Employee Get(int id)
        {
            var employee = list.SingleOrDefault(x => x.Id == id);
            if (employee == null) throw new HttpResponseException(HttpStatusCode.NotFound);
            return employee;
        }

        public IEnumerable<Employee> GetByOffice(string office)
        {
            if (office == "all") return Get();
            var employees = list.Where(e => e.Office == office).ToList();
            if (!employees.Any()) throw new HttpResponseException(HttpStatusCode.NotFound);
            return employees;
        }
        public Employee GetByOffice(string office, int id)
        {

            var employees = list.SingleOrDefault(e => e.Office == office && e.Id == id);
            if (employees == null) throw new HttpResponseException(HttpStatusCode.NotFound);
            return employees;
        }
        //public IEnumerable<Employee> GetByDepartment(int department)
        //{
        //    var employees= list.Where(e => e.Department == department).ToList();
        //    if (!employees.Any()) throw new HttpResponseException(HttpStatusCode.NotFound);
        //    return employees;
        //}

        //public IEnumerable<Employee> GetByDepartmentAndLastName([FromUri]Filter filter)
        //{
        //    var employees = list.Where(e => e.Department == filter.Department && e.LastName==filter.Lastname).ToList();
        //    if (!employees.Any()) throw new HttpResponseException(HttpStatusCode.NotFound);
        //    return employees;
        //}
        public HttpResponseMessage Post(Employee employee)
        {
            //if (!ModelState.IsValid) return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            
            var newId = list.Max(x => x.Id) + 1;
            employee.Id = newId;
            list.Add(employee);
            var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, employee);
            var uri = Url.Link("DefaultApi", new { id = employee.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void Delete(int id)
        {
            var employee = Get(id);
            list.Remove(employee);
        }

        public HttpResponseMessage Put(int id, Employee employee)
        {
            var index = list.ToList().FindIndex(x => x.Id == id);
            if (index >= 0)
            {
                employee.Id = id;
                list[index] = employee;
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage Patch(int id, Delta<Employee> deltaEmployee)
        {
            var employee = list.SingleOrDefault(e => e.Id == id);
            if (employee == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            deltaEmployee.Patch(employee);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        public HttpResponseMessage Fired(int id)
        {
            var employee = list.SingleOrDefault(e => e.Id == id);
            if (employee == null) return Request.CreateResponse(HttpStatusCode.NotFound);
            employee.Fired = true;
            return Request.CreateResponse(HttpStatusCode.NoContent);

        }

    }
}
