using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Blog
{
    public int BlogId { get; set; }

    public string BlogName { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int UserUserId { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual User UserUser { get; set; } = null!;
}
