using System;

namespace TraineeProgram_SOLID_Solutions.ISP
{
    public class Claim : IOperation
    {
        public string Delete()
        {
            return("Claim is successfully deleted.");
        }

        public string Save()
        {
            return("Claim is successfully saved.");
        }
    }
}
