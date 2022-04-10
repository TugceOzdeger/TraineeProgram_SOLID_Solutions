using System.Collections.Generic;

namespace TraineeProgram_SOLID_Solutions.DIP
{
    class Opportunity
    {
        private ICollection<IData> _data;

        public Opportunity(ICollection<IData> data) => _data = data;

        public void Export()
        {
            foreach (var d in _data)
            {
                d.ExportData();
            }
        }
    }
}
