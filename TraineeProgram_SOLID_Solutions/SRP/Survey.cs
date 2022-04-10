namespace TraineeProgram_SOLID_Solutions.SRP
{
    public class Survey : ISurvey
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public char QuestionAnswer { get; set; }
    }
}
