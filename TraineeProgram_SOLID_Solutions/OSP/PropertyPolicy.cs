namespace TraineeProgram_SOLID_Solutions.OSP
{
    public class PropertyPolicy
    {
        private readonly BusinessTypeEnum BusinessType;

        public PropertyPolicy(string policyNumber)
        {
            PolicyNumber = policyNumber;
            BusinessType = BusinessTypeEnum.Captive;
        }

        public string PolicyNumber { get; }

        public string Activate()
        {
            return $"{PolicyNumber} that has {BusinessType} business has been excuted successfully";
        }
    }
}
