using SocialMediaPost.Interfaces;
using SocialMediaPost.Observers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPost.Subjects
{
    internal class Post : IPost
    {
        private List<IFollower> followers = new List<IFollower>();
        private string content = string.Empty;
        public void AddFollower(IFollower follower)
        {
            followers.Add(follower);
        }

        public void NotifyFollower()
        {
            foreach (var follower in followers)
            {
                follower.Update(content);
            }
        }

        public void RemoveFollower(IFollower follower)
        {
            followers.Remove(follower);
        }

        public void UpdateContent(string content)
        {
            this.content = content;
            NotifyFollower();
        }
    }
}
