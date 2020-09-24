using System;

namespace plasticlove.Models
{
    public class Comment
    {
        public long id { get; set; }
        public bool deleted { get; set; }
        public DateTime publishTime { get; set; }
        public string userNickName { get; set; }
        public string userEmail { get; set; }
        public string userLink { get; set; }
        public string userContent { get; set; }
    }
}
