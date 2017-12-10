using System.Web.Http;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    public class EmployeeController : ApiController
    {
        public Employee Get()
        {
            //Changed file
            var e = new Employee();
            e.FirstName = "Sukesh";
            e.LastName = "Marla";
            e.Salary = 25000;
            return e;
        }
    }
}
