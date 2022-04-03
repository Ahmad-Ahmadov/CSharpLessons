using System;
using System.Linq;

namespace ThisBaseKeywords
{
    public class User
    {
        //this 
        public User(int id , string name , string email, string password) : this(name,id)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }
        public User( string str,int id)
        {
            idWithName = id +" "+ str;
        }
        public User()
        {

        }
        public int id;
        public string name;
        public string email;
        public string password;
        public string idWithName;
    }
}
