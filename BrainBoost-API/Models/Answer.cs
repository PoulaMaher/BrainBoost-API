﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string? Content { get; set; }

        [ForeignKey("Question")]
        public int? QuestionId { get; set; }

        public Question? Question { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
