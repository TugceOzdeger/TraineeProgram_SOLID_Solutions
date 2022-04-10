namespace TraineeProgram_SOLID_Solutions.DIP
{
    public class Risk : IData
    {
        public decimal MaximumLoss { get; set; }
        public decimal RiskFactor { get; set; }

        public string ExportData()
        {
            return "Risk data exported";
        }
    }
}
