namespace TraineeProgram_SOLID_Solutions.SRP
{
    public interface ISurvey
    {
        int QuestionNumber { get; set; }
        string QuestionText { get; set; }
        char QuestionAnswer { get; set; }
    }
}
