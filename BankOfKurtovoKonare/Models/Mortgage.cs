namespace BankOfKurtovoKonare.Models
{
    using Interfaces;

    public class Mortgage : Account
    {
        public Mortgage(ICustomer customer, decimal ballance, decimal interesetRate)
            : base(customer, ballance, interesetRate)
        {
        }

        public override decimal CalcInterest(int months)
        {
            if (this.Customer is Individual && months <= 6)
            {
                return 0;
            }

            if (this.Customer is Company && months <= 12)
            {
                return base.CalcInterest(months) / 2;
            }

            return base.CalcInterest(months);
        }
    }
}