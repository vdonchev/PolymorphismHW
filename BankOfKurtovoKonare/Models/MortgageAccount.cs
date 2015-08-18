namespace BankOfKurtovoKonare.Models
{
    using Interfaces;

    public class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal ballance, decimal interesetRate)
            : base(customer, ballance, interesetRate)
        {
        }

        public override decimal CalcInterest(int months)
        {
            if (this.Customer is IndividualCustomer && months <= 6)
            {
                return 0;
            }

            if (this.Customer is CompanyCustomer && months <= 12)
            {
                return base.CalcInterest(months) / 2;
            }

            return base.CalcInterest(months);
        }
    }
}