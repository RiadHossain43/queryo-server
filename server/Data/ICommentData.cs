using server.Models;

namespace server.Data
{
    public interface ICommentData
    {
        List<Comment> GetComments();
        Comment GetComment(int id);
        Comment AddComment(Comment comment);
        Comment UpdateComment(Comment comment);
        Comment DeleteComment(int id);
    }
}
