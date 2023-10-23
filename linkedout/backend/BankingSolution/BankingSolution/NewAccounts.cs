using Banking.Domain;


namespace BankingSolution;
internal class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        // Write the Code You Wish You Had
        // Given - I have a new account
        Account account = new Account();

        //when I ask it for it's balance
        decimal openingBalance = account.GetBalance();

        //then it is 5000 bucks. (decimal)
        Assert.Equal(5000M, openingBalance);
    }

}
