namespace DAL.DTOs
{
    public class DTOEmployee
    {
        //Properties
        string mdUuid; //For now we fill them randomlly
        DateTime mdDate;
        string codEmployee;
        string KeyEmployee;
        int levelAccessEmployed;


        //Constructor
        public DTOEmployee(string codEmployee, string keyEmployee)
        {
            mdUuid = RamdomValue();
            mdDate = DateTime.Now;
            codEmployee = codEmployee;
            KeyEmployee = keyEmployee;
            levelAccessEmployed = 2;        
        }

        //GETTERS AND SETTERS
        public string CodEmployee1 { get => codEmployee; set => codEmployee = value; }
        public string KeyEmployee1 { get => KeyEmployee; set => KeyEmployee = value; }
        public int LevelAccessEmployed1 { get => levelAccessEmployed; set => levelAccessEmployed = value; }

        //Method that generate a random value for the field MdUuid       
        string RamdomValue()
        {
            Random ran = new Random();
            return ("A"+ ran.Next());
        }
    }
}
