using System;
using System.Collections.Generic;
using Ysk.BlogProject.Entities.Abstract;

namespace Ysk.BlogProject.Entities.Concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
