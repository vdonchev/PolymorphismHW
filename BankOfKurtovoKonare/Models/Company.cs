namespace BankOfKurtovoKonare.Models
{
    public class Company : Customer
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