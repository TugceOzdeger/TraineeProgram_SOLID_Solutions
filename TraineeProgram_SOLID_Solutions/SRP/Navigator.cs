namespace TraineeProgram_SOLID_Solutions.SRP
{
    public class Navigator : INavigator
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public char QuestionAnswer { get; set; }
        public int Score { get; set; }
        public bool IsRecommendationNeeded { get; set; }
    }
}
