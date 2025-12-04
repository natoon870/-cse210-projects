public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> Comments = new List<Comment>();

    public int CommentCount()
    {
        return Comments.Count;
    }
}