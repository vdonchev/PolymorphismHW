namespace BankOfKurtovoKonare.Models
{
    using Interfaces;

    public abstract class Customer : ICustomer
    {
        public abstract int RequiredMonths { get; }
    }
}