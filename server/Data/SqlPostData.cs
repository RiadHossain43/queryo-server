using server.Models;

namespace server.Data
{
    public class SqlPostData : IPostData
    {
        private ApplicationDbContext _applicationDbContext;
        public SqlPostData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Post AddPost(Post post)
        {
            _applicationDbContext.Posts.Add(post);
            _applicationDbContext.SaveChanges();
            return post;
        }
        public List<Post> GetPosts()
        {
            return _applicationDbContext.Posts.Where(post => post.Type == "Question").ToList();
        }
        public List<Post> GetPostsByRefId(int id)
        {
            return _applicationDbContext.Posts.Where(post=>post.RefPostId==id).ToList();
        }
        public Post GetPost(int id)
        {
            var post = _applicationDbContext.Posts.Find(id);
            return post;
        }
        public Post UpdatePost(Post post)
        {
            _applicationDbContext.Posts.Update(post);
            _applicationDbContext.SaveChanges();
            return post;
        }
        public void DeletePost(int id)
        {
            var post = _applicationDbContext.Posts.Find(id);
            if(post != null)
            {
                _applicationDbContext.Posts.Remove(post);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
