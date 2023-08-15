using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Quiz
{
    public class Question
    {
        public Question(int id, string title, string description, string type, string answer)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Type = type;
            this.Answer = answer;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Answer { get; set; }
    }
}
