using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.SocialMedia
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; }

        public void CreatePost(Post post)
        {
            this.Posts.Add(post);
        }

        public List<Post> GetFeed()
        {
            return this.Posts;
        }
    }
}
