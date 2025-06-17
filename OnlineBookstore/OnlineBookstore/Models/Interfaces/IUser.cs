using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Models.Interfaces
{
    internal interface IUser    
    {
        string FullName { get; }
    }
}
