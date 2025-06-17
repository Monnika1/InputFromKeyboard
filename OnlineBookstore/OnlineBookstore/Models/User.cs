using OnlineBookstore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace OnlineBookstore.Models
{
    internal class User: IUser
    {
        public string FullName { get; }

        public User(string fullName)
        {
            FullName = fullName;
        }
      
    }
}

