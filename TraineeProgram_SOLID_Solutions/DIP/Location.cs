namespace TraineeProgram_SOLID_Solutions.DIP
{
    public class Location : IData
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string ExportData()
        {
            return "Location data exported";
        }
    }
}
