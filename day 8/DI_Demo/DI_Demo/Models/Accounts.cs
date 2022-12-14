namespace DI_Demo.Models
{
    public class Accounts : DI_Demo.Models.Interfaces.IAccounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }


        static List<Accounts> aList = new List<Accounts>()
        {
            new Accounts(){ accNo=101, accName="Nikhil", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=102, accName="Sohail", accType="Current", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=103, accName="Seema", accType="PF", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=104, accName="Mohit", accType="Savings", accBalance=5000, accIsActive=true},
            new Accounts(){ accNo=105, accName="Rohit", accType="Current", accBalance=5000, accIsActive=true},
        };

        public List<Accounts> GetAllAccounts()
        {
            return aList;
        }

        public Accounts GetAccountById(int id)
        {
            var acc = aList.Find(a => a.accNo == id);
            return acc;
        }
    }
}
