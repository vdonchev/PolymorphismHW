namespace BankOfKurtovoKonare.Models
{
    using Interfaces;

    public class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal ballance, decimal interesetRate)
            : base(customer, ballance, interesetRate)
        {
        }

        public override decimal CalcInterest(int months)
        {
            if (months <= this.Customer.RequiredMonths)
            {
                return 0;
            }

            return base.CalcInterest(months);
        }
    }
}