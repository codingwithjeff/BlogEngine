﻿using System.ComponentModel.DataAnnotations;

namespace BlogEngine.Shared.DTOs
{
    public class CommentCreationDTO
    {
        public int ID { get; set; }
        public int MainCommentID { get; set; }
        public int BlogID { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Comment {0} should not be more than 300 Characters")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}