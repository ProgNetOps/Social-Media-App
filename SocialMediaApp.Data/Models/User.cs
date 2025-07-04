﻿using SocialMediaApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? ProfilePictureUrl { get; set; }

        //Navigation properties
        public ICollection<Post> Posts { get; set; } = [];
    }
}
