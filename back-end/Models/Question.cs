// Object Oriented Programming: Model Class

namespace back_end.Models 
{
    public class Question
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Prompt { get; set; }
        public string Answer { get; set; }
        public int Value { get; set; }
        public bool IsAnswered { get; set; }
    }
}