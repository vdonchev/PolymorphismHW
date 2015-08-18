namespace BankOfKurtovoKonare.Models
{
    using System;
    using Interfaces;

    public abstract class Account : IAccount, IDeposit
    {
        private decimal ballance;
        private decimal interestRate;

        protected Account(ICustomer customer, decimal ballance, decimal interesetRate)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interesetRate;
        }

        public ICustomer Customer { get; set; }

        public decimal Ballance
        {
            get
            {
                return this.ballance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Ballance can't be negative");
                }

                this.ballance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Invalid interest rate. Should be in range [0..1]");
                }

                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.Ballance += money;
        }

        public virtual decimal CalcInterest(int months)
        {
            return this.Ballance * ((1 + this.InterestRate) * months);
        }
    }
}