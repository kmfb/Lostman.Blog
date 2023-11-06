using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lostman.Blog.Posts
{
    public class CreateUpdatePostDto
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public PostType Type { get; set; } = PostType.Undefined;
        [Required]
        public string Content { get; set; }
    }
}
