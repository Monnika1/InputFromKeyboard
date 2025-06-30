using System.Text;

namespace OnlineBookstore.Models.Interfaces
{
    internal interface IReportGen
    {
        StringBuilder logger { get; }
        void Log(string message);
        void GenerateReport();
    }
}
