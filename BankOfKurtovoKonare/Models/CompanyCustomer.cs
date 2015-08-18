namespace BankOfKurtovoKonare.Models
{
    public class CompanyCustomer : Customer
    {
        private const int ReqMonths = 2;

        public override int RequiredMonths {
            get
            {
                return ReqMonths;
            }
        }
    }
}