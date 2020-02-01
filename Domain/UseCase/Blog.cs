namespace Domain
{
    public class Blog
    {
        
        public Blog() { }
        
        public Blog(PostList posts)
        {
            Posts = posts;
        }
        public PostList Posts { get; }
    }
}