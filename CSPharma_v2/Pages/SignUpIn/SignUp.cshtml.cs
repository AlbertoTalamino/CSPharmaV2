using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSPharma_v2.Pages.SignUpIn
{
    public class SignUpModel : PageModel
    {
        public DAL.Models.CspharmaInformationalContext db = new DAL.Models.CspharmaInformationalContext();

        public void OnGet(string user, string pwd)
        {
            var employeeUser = db.DlkCatAccEmployees.Where(e => e.CodEmployee == user).FirstOrDefault();
            var employeePwd = db.DlkCatAccEmployees.Where(e => e.KeyEmployee == pwd).FirstOrDefault();

            if (employeeUser != null && employeePwd != null)
            {
                
            }

        }

        //[HttpPost]
        //public IActionResult Index(string user, string pwd)
        //{
        //    var employeeUser = db.DlkCatAccEmployees.Where(e => e.CodEmployee == user).FirstOrDefault();
        //    var employeePwd = db.DlkCatAccEmployees.Where(e => e.CodEmployee == user).FirstOrDefault();

        //    if (employeeUser != null && employeePwd != null)
        //    {

        //    }
   
        //}
    }
}
