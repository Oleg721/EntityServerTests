using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public class MessageDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
