namespace BankOfKurtovoKonare.Models
{
    public class Individual : Customer
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