namespace BankOfKurtovoKonare
{
    using System;
    using Models;

    public static class BankMain
    {
        public static void Main()
        {
            var accounts = GenerateAccounts();

            PrintAccounts(accounts);
        }

        private static Account[] GenerateAccounts()
        {
            var accounts = new Account[]
            {
                new DepositAccount(new IndividualCustomer(), 999, 0.00005M),
                new MortgageAccount(new CompanyCustomer(), 100, 0.0001M),
                new LoanAccount(new IndividualCustomer(), 199, 0.00009M),
                new DepositAccount(new IndividualCustomer(), 1000, 0.0006M),
                new LoanAccount(new CompanyCustomer(), 2987, 0.004M),
                new MortgageAccount(new IndividualCustomer(), 98745, 0.0001M),
            };
            return accounts;
        }

        private static void PrintAccounts(Account[] accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine(
                    "|{0,-10}|ballance: {1,-10:F2}|interest: {2:F2}",
                    account.GetType().Name,
                    account.Ballance,
                    account.CalcInterest(36));
            }
        }
    } 
}
