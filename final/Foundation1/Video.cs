using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author ;
    public int _length;
    public List<Comment> _comments ;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string username, string text)
    {
        Comment comment = new Comment(username, text);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}
