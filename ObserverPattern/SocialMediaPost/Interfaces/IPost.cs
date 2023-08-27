using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPost.Interfaces
{
    internal interface IPost
    {
        public void AddFollower(IFollower follower);
        public void RemoveFollower(IFollower follower);
        public void NotifyFollower();
        public void UpdateContent(string content);
    }
}
