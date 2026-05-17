using Microsoft.AspNetCore.Mvc;
using back_end.Data;
using back_end.Models;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuestionsController(AppDbContext context)
        {
            _context = context;
        }

        /*[HttpGet]
        public IActionResult GetQuestions()
        {
            return Ok(_context.Questions.ToList());
        }*/

        [HttpGet]
        public IActionResult GetQuestions()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Id = 1,
                    Category = "Science",
                    Prompt = "What planet is known as the Red Planet?",
                    Answer = "Mars",
                    Value = 200
                },

                new Question
                {
                    Id = 2,
                    Category = "History",
                    Prompt = "Who was the first president of the USA?",
                    Answer = "George Washington",
                    Value = 400
                },

                new Question
                {
                    Id = 3,
                    Category = "Games",
                    Prompt = "What company made the PlayStation?",
                    Answer = "Sony",
                    Value = 600
                }
            };

            return Ok(questions);
        }

        [HttpPost]
        public IActionResult AddQuestion(Question question)
        {
            _context.Questions.Add(question);

            _context.SaveChanges();

            return Ok(question);
        }
    }
}