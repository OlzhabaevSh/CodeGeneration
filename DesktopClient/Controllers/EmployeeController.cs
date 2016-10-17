using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DesktopClient.Controllers
{
    [RoutePrefix("api/Employees")]
    public class EmployeeController : ApiController
    {
        private AsdicContext db = new AsdicContext();

        // GET: api/Employees
        /// <summary>
        /// Ойпта
        /// </summary>
        /// <returns>ыыы</returns>
        public IQueryable<EmployeeVM> GetEmployee()
        {
            return new List<EmployeeVM>().AsQueryable();
        }

        // GET: api/Employees/5
        [ResponseType(typeof(EmployeeVM))]
        public IHttpActionResult GetEmployee(int id)
        {
            EmployeeVM res = new EmployeeVM();

            return Ok(res);
        }

        [Route("{Id:int}/Terminals")]
        public IEnumerable<TerminalVM> GetEmployeeTerminals(int id)
        {
            return new List<TerminalVM>();
        }

        [Route("{Id:int}/Equipments")]
        public IEnumerable<TerminalVM> GetEmployeeEquipments(int id)
        {
            // todo: need change to equipments
            return null;
        }


        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            return CreatedAtRoute("DefaultApi", new { id = 1 }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = new Employee();
            
            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return true;
            //return db.Employee.Count(e => e.Id == id) > 0;
        }
    }
}




