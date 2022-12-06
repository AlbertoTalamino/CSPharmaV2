namespace DAL.DTOs
{
    public class DTOEmployee
    {
        //Properties
        string codEmployee;
        string KeyEmployee;
        int levelAccessEmployed;

        //Constructor
        public DTOEmployee(string codEmployee, string keyEmployee)
        {
            codEmployee = codEmployee;
            KeyEmployee = keyEmployee;
            levelAccessEmployed = 2;
        }

        //GETTERS AND SETTERS
        public string CodEmployee1 { get => codEmployee; set => codEmployee = value; }
        public string KeyEmployee1 { get => KeyEmployee; set => KeyEmployee = value; }
        public int LevelAccessEmployed1 { get => levelAccessEmployed; set => levelAccessEmployed = value; }
    }
}
