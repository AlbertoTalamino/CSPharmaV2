namespace DAL.DTOs
{
    public class DTOEmployee
    {
        //Properties
        string mdUuid; //For now we fill them randomlly
        DateTime mdDate;
        string codEmployee;
        string keyEmployee;
        short levelAccessEmployed;


        //Constructor    
        public DTOEmployee(string codEmployee, string keyEmployee)
        {
            this.mdUuid = RamdomValue();
            this.mdDate = DateTime.Now;
            this.codEmployee = codEmployee;
            this.keyEmployee = keyEmployee;
            this.levelAccessEmployed = 2;
        }



        //GETTERS AND SETTERS
        public string MdUuid { get => mdUuid; set => mdUuid = value; }
        public DateTime MdDate { get => mdDate; set => mdDate = value; }
        public string CodEmployee { get => codEmployee; set => codEmployee = value; }
        public string KeyEmployee { get => keyEmployee; set => keyEmployee = value; }
        public short LevelAccessEmployed { get => levelAccessEmployed; set => levelAccessEmployed = value; }


        //Method that generate a random value for the field MdUuid       
        string RamdomValue()
        {
            Random ran = new Random();
            return ("A"+ ran.Next());
        }
    }
}
