using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
    }
}