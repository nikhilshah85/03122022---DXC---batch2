namespace DI_Demo.Models.Interfaces
{
    public interface IAccounts
    {
        List<Accounts> GetAllAccounts();

        Accounts GetAccountById(int id);

        //string GreetUser();


    }
}
