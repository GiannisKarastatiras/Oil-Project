using OilTeamProject.Models.Employees;
using OilTeamProject.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OilTeamProject.ViewModels
{
    public class PerformanceData
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Required]
        public Employee Employee { get; set; }

        [Required]
        public Evaluation Evaluation { get; set; }

        [Required]
        public Form Form { get; set; }
        public Answer Answer { get; set; }
        public IEnumerable<Form> Forms { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public List<Evaluation> Evaluations { get; set; }
        public DateTime DateTime { get; set; }
        public decimal OveralRating { get; set; }
        public int FormId { get; set; }
        public List<Question> Questions { get; set; }

        [Required]
        [Range(1, 5 ,ErrorMessage ="Enter A Value")]
        public List<Answer> Answers { get; set; }

        public bool ExistingPerformance = false;

        public DateTime EvaluationdDatetime { get; set; }


        public List<Question> GetFormQuestions(int formId)
        {
            var questionsForm = db.Forms.Single(m => m.ID == formId).Questions.ToList();
            return questionsForm;
        }

        public void SetAnswerProperties(int questionId, Answer answer)
        {
            answer.QuestionID = questionId;
        }

    }


}