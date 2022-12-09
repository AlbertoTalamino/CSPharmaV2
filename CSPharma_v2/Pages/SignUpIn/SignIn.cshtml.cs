using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.NetworkInformation;

namespace CSPharma_v2.Pages.SignUpIn
{
    public class SignInModel : PageModel
    {
        public DAL.Models.CspharmaInformationalContext db = new DAL.Models.CspharmaInformationalContext();

        [BindProperty]
        public string inputUser { get; set; }
        [BindProperty]
        public string inputPwd { get; set; }



        public void OnGet()
        {
        }

        public IActionResult OnPostSubmit() 
        {
            var employeeUser = db.DlkCatAccEmployees.Where(e => e.CodEmployee == inputUser).FirstOrDefault();
            var employeePwd = db.DlkCatAccEmployees.Where(e => e.KeyEmployee == inputPwd).FirstOrDefault();

            ViewData["warningMessage"] = " ";

            if (employeeUser != null && employeePwd != null)
            {
                return RedirectToPage("../Index");
            }
            else
            {
                ViewData["warningMessage"] = "ERROR (The user doesn't exits)!";
                return null;     
            }

            
        }
    }
}
