using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace MyProj.Models
{
    public class Post
    {
        public Post(int id, string title, string content, DateTime postedOn, int userId)
        {
            Id = id;
            Title = title;
            Content = content;
            PostedOn = postedOn;
            UserId = userId;
        }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostedOn { get; set; }
        public int UserId { get; set; }

    }
}
