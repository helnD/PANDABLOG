using System;

namespace Domain
{
    public class Post : ICloneable
    {
        public Post(string header, string text, DateTime date)
        {
            Header = header;
            Text = text;
            Date = date;
        }

        public string Header { get; }
        public string Text { get; }
        public DateTime Date { get; }
        
        public object Clone()
        {
            return new Post(Header, Text, Date);
        }
    }
}