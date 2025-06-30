using OnlineBookstore.Models.Interfaces;
using System.Text;

namespace OnlineBookstore.Models
{
    internal class ConsoleGenerator : IReportGen
    {
        public StringBuilder logger { get; }
        public ConsoleGenerator()
        {
            logger = new StringBuilder();
        }
        public void GenerateReport()
        {
            Console.WriteLine(logger.ToString());
        }

        public void Log(string message)
        {
            logger.AppendLine(message);
        }
    }
}
