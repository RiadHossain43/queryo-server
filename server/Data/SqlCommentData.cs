using server.Models;

namespace server.Data
{
    public class SqlCommentData : ICommentData
    {
        private ApplicationDbContext _applicationDbContext;
        public SqlCommentData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Comment AddComment(Comment comment)
        {
            _applicationDbContext.Comments.Add(comment);
            _applicationDbContext.SaveChanges();
            return comment;
        }

        public Comment GetComment(int id)
        {
            return _applicationDbContext.Comments.Find(id);
        }

        public List<Comment> GetComments()
        {
            return _applicationDbContext.Comments.ToList();
        }
        public List<Comment> GetCommentsByPost(int id)
        {
            return _applicationDbContext.Comments.Where(comment=>comment.PostId==id).ToList();
        }

        public Comment UpdateComment(Comment comment)
        {
            _applicationDbContext.Comments.Update(comment);
            _applicationDbContext.SaveChanges();
            return comment;
        }
        public void DeleteComment(int id)
        {
            var comment = _applicationDbContext.Comments.Find(id);
            if (comment != null)
            {
                _applicationDbContext.Comments.Remove(comment);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
