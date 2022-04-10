using System;
using TraineeProgram_SOLID_Solutions.LSP;
using TraineeProgram_SOLID_Solutions.OSP;
using TraineeProgram_SOLID_Solutions.SRP;
using Policy = TraineeProgram_SOLID_Solutions.ISP.Policy;

namespace TraineeProgram_SOLID_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //LSP Principle
            Recommendation rec = new Observation();
            Console.WriteLine(rec.PublishDocument());
            Console.ReadLine();

            //OSP Principle
            PropertyPolicy policy = new PropertyPolicy("LP01");
            Console.WriteLine(policy.Activate());
            Agreement ag = new Agreement("LA01");
            Console.WriteLine(ag.Activate());

            //SRP Principle
            NavigatorQuestion nav = new NavigatorQuestion();
            Console.WriteLine(nav.SubmitScore());
            SurveyQuestion survey = new SurveyQuestion();
            Console.WriteLine(survey.SubmitScore());
            Console.ReadLine();
        }
    }
}
