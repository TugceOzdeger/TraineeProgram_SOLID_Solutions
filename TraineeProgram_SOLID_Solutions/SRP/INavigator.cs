namespace TraineeProgram_SOLID_Solutions.SRP
{
    public interface INavigator : ISurvey
    {
        int Score { get; set; }
        bool IsRecommendationNeeded { get; set; }
    }
}
