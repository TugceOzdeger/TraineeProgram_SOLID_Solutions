namespace TraineeProgram_SOLID_Solutions.OSP
{
    public class Agreement
    {
        private readonly BusinessTypeEnum BusinessType;

        public Agreement(string agreementNumber)
        {
            AgreementNumber = agreementNumber;
            BusinessType = BusinessTypeEnum.Captive;
        }

        public string AgreementNumber { get; }

        public string Activate()
        {
            return $"{AgreementNumber} that has {BusinessType} business has been excuted successfully";
        }
    }
}
