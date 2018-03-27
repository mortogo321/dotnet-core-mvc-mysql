using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        [MaxLength(32)]
        public string Title { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Content { get; set; }
        public JsonObject<List<string>> Tags { get; set; }
    }
}