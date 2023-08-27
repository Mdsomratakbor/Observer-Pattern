using SocialMediaPost.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPost.Observers
{
    public class User : IFollower
    {
        string userName = string.Empty;
        public User(string userName) { 
            this.userName = userName;
        }
        public void Update(string content)
        {
            Console.WriteLine($"{userName} received a notification: New post -  {content}");
        }
    }
}
