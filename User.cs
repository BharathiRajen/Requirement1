using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement1
{
    class User
    {
        //members
        private string Username;
        private string MailId;
        private string Password;

        //Properties

        public string Username1 { get => this.Username; set => this.Username = value; }
        public string MailId1 { get => this.MailId; set => this.MailId = value; }
        public string Password1 { get => this.Password; set => this.Password = value; }


        public User()
        {
        }

        public User(string username, string mailId, string password)
        {
            this.Username = username;
            this.MailId = mailId;
            this.Password = password;
        }

        //constructor




        
        public override string ToString()
        {
            return String.Format("Username: {0}\nMailId: {1}\n Password: {2}" , Username, MailId, Password);
        }
        public override bool Equals(object obj)
        {
            User obj_user = (User)obj;
            return this.Username.Equals(obj_user.Username);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
