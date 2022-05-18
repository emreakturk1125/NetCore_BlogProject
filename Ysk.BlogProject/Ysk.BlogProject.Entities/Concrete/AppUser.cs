﻿using System;
using System.Collections.Generic;
using Ysk.BlogProject.Entities.Abstract;

namespace Ysk.BlogProject.Entities.Concrete
{
    public class AppUser : ITable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
