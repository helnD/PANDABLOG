using System.Collections.Generic;
using System.Linq;
using Domain;

namespace WebApplication.Models
{
    public class SqlRepository : PostRepository
    {

        private readonly BlogContext _context;

        internal SqlRepository(BlogContext context)
        {
            _context = context;
        }
        
        public PostList GetAllPosts()
        {
            var posts = _context.Posts
                .Select(it => new Domain.Post(it.Header, it.Text, it.Date));

            return !posts.Any() ? new PostList(new List<Domain.Post>()) :
                new PostList(posts);
        }
    }
}