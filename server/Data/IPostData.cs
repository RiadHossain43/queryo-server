using server.Models;

namespace server.Data
{
    public interface IPostData
    {
        List<Post> GetPosts();
        List<Post> GetPostsByRefId(int id);
        Post GetPost(int id);
        Post AddPost(Post post);
        Post UpdatePost(Post post);
        void DeletePost(int id);
    }
}
