using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Models.Interfaces
{
    internal interface IReportGen
    {
        StringBuilder logger { get; }
        void Log(string message);
        void GenerateReport();
    }
}
