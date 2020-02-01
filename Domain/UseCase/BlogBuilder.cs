namespace Domain
{
    public class BlogBuilder
    {
        private PostRepository _repository;

        public BlogBuilder Repository(PostRepository repository)
        {
            _repository = repository;
            return this;
        }

        public Blog Build()
        {
            var posts = _repository.GetAllPosts();
            return new Blog(posts);
        }
    }
}