namespace DI_and_Dataannotation_demo.Models
{
    public class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }


        static List<Accounts> accList = new List<Accounts>()
        {
            new Accounts(){ accNo=101, accName="Nikhil", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=102, accName="Amit", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=103, accName="Sahil", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=104, accName="Priya", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=105, accName="Riya", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=106, accName="Jiya", accType="Savings", accBalance=5000, accIsActive=true},
        };

        public List<Accounts> GetAllAccounts()
        {
            return accList;
        }
    }
}
