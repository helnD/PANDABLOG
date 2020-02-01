using System.Collections.Generic;

namespace Domain
{
    public interface PostRepository
    {
        PostList GetAllPosts();
    }
}