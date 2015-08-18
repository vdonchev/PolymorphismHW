namespace BankOfKurtovoKonare.Models
{
    public class IndividualCustomer : Customer
    {
        private const int ReqMonths = 3;

        public override int RequiredMonths
        {
            get
            {
                return ReqMonths;
            }
        }
    }
}