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

        public IActionResult OnPostSubmit()
        {
            //Instance of the employe class with the parameters collected by the view
            DAL.DTOs.DTOEmployee employeeDTO = new DAL.DTOs.DTOEmployee(inputUser, inputPwd1);
            //DTO to DAO
            DAL.Models.DlkCatAccEmployee employeeDAO = DAL.ToDAOs.DTOEmployeeToDAO.DtoEmployeeToDao(employeeDTO);
            //Insert
            db.DlkCatAccEmployees.Add(employeeDAO);
            db.SaveChanges();
            return RedirectToPage("../Index");
        }

        
    }
}
