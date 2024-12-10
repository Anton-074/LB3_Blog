using System;
using System.Collections.Generic;

namespace LB3_Blog;

public partial class Post
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime DateOfPublication { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
