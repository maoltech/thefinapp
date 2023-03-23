

namespace User.Entities
{
    public class User
    {
        public Guid Id {get; init;}
        public string firstName {get; init;}

        public string lastName {get; init;}
        public string userName {get; init;}
        public string BVN {get; init;}
        public DateTimeOffset DOB {get; init;}
        public DateTimeOffset CreateDate {get; init;}

    }
} 