namespace ApplicationCore.Models.DomainModels;

public record RegularUser(int Id, string Password)
{
    public RegularUser(int id, string password, int accountBalance)
        : this(id, password)
    {
        AccountBalance = accountBalance;
    }

    public int AccountBalance { get; set; }
}