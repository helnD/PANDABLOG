using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class PostList
    {
        private IEnumerable<Post> _posts;

        public PostList(IEnumerable<Post> posts)
        {
            _posts = posts.ToList();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var post in _posts)
            {
                yield return post;
            }
        }

    }
}