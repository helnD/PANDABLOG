using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        [Column(TypeName = "ntext")]
        public string Header { get; set; }
        
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}