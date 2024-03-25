using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Post
{
    public int PostId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int BlogBlogId { get; set; }

    public virtual Blog BlogBlog { get; set; } = null!;
}
