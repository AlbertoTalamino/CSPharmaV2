using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSPharma_v2.Pages.SignUpIn
{
    public class SignUpModel : PageModel
    {
        public DAL.Models.CspharmaInformationalContext db = new DAL.Models.CspharmaInformationalContext();

        [BindProperty]
        public string inputUser { get; set; }
        [BindProperty]
        public string inputPwd1 { get; set; }


        public void OnGet()
        {

        }

        public void OnPostSubmit()
        {
            db.DlkCatAccEmployees.Add(new DAL.Models.DlkCatAccEmployee(inputUser, inputPwd1));
            db.SaveChanges();
        }

        
    }
}
