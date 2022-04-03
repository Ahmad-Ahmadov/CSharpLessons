using System;
using System.Linq;

namespace ThisBaseKeywords
{
    
    class Program
    {
        public static Result Add(User[] users,User user)
        {
            try
            {
                users[user.id-1]=user;
                return new SuccessResult();
            }
            catch 
            {
                return new ErrorResult();
            }
        }
        static void Main(string[] args)
        {

            //User user1 = new User
            //{
            //    id = 1,
            //    name = "Medine",
            //    email = "eeedada",
            //    idWithName = "1 Medine"
            //};
            //user1.name = "Ehmed";
            //user1.email = "asda";
            //user1.id = 2;
            User[] users = new User[3];
            User ehmed = new User(1,"Ehmed","eehmedov17@gmail.com","ehmed123");
            User medine = new User(2, "Medine", "medine@gmail.com", "medine123");
            User resad = new User(13,"Resad", "eehmedov17@gmail.com", "ehmed123");

            Result m = Add(users, medine);
            if (m.Success)
            {
                Console.WriteLine("User added succesfully");
            }
            else
            {
                Console.WriteLine("Error!!!!");
            }
        }
    }
}
