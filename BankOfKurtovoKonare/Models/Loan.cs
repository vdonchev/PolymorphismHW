namespace BankOfKurtovoKonare.Models
{
    using Interfaces;

    public class Loan : Account
    {
        public Loan(ICustomer customer, decimal ballance, decimal interesetRate)
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