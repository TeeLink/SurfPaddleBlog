﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfNPaddleBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string ImageLink { get; set; }
    }
}