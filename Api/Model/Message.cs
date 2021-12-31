using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string UserId { get; set;}
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
