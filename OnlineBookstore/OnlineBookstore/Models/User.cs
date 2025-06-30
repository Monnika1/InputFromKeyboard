using OnlineBookstore.Models.Interfaces;

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

