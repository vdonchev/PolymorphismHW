namespace BankOfKurtovoKonare.Models
{
    using System;
    using Interfaces;

    public class Deposit : Account, IWithdraw
    {
        public Deposit(ICustomer customer, decimal ballance, decimal interesetRate)
            : base(customer, ballance, interesetRate)
        {
        }

        public void WithdrawMoney(decimal money)
        {
            if (this.Ballance - money < 0)
            {
                throw new ArgumentOutOfRangeException("money", "You don't have enough money in your ballance");
            }

            this.Ballance -= money;
        }

        public override decimal CalcInterest(int months)
        {
            if (this.Ballance > 0 && this.Ballance < 1000)
            {
                return 0;
            }

            return base.CalcInterest(months);
        }
    }
}