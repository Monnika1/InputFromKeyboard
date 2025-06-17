using OnlineBookstore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
