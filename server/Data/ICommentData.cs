using server.Models;

namespace server.Data
{
    public interface ICommentData
    {
        List<Comment> GetComments();
        List<Comment> GetCommentsByPost(int id);
        Comment GetComment(int id);
        Comment AddComment(Comment comment);
        Comment UpdateComment(Comment comment);
        void DeleteComment(int id);
    }
}
