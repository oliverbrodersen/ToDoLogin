using BlazorApp1.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Todo
    {
        public int UserId { get; set; }
        public int TodoId { get; set; }
        [Required, MaxLength(128)] public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public Todo()
        {
        }
        public Todo(int user)
        {
            UserId = user;
        }
    }
}
