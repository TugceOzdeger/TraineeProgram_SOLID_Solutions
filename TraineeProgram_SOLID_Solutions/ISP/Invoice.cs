using System;

namespace TraineeProgram_SOLID_Solutions.ISP
{
    public class Invoice : IOperation, IInvoice
    {
        public string Delete()
        {
            return("Invoice is successfully deleted.");
        }

        public string Execute()
        {
            return ("Invoice is successfully executed.");
        }

        public string Save()
        {
            return ("Invoice is successfully saved.");
        }
    }
}
