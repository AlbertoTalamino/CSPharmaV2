namespace DAL.ToDAOs
{
    public class DTOEmployeeToDAO
    {
        //Method that convert DTO employee in a DAO employee
        public static DAL.Models.DlkCatAccEmployee DtoEmployeeToDao(DAL.DTOs.DTOEmployee employeeDTO)
        {
            DAL.Models.DlkCatAccEmployee employeeDAO = new DAL.Models.DlkCatAccEmployee();

            employeeDAO.MdUuid = employeeDTO.MdUuid;
            employeeDAO.MdDate = employeeDTO.MdDate;
            employeeDAO.CodEmployee = employeeDTO.CodEmployee; 
            employeeDAO.KeyEmployee = employeeDTO.KeyEmployee;
            employeeDAO.LevelAccessEmployed = employeeDTO.LevelAccessEmployed;

            return employeeDAO;
        }
    }
}
