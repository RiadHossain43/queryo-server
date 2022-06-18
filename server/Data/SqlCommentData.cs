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
            throw new NotImplementedException();
        }

        public Comment DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetComments()
        {
            throw new NotImplementedException();
        }

        public Comment UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
