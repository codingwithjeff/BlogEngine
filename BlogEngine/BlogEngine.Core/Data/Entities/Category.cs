﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogEngine.Core.Data.Entities.JoiningEntities;
using BlogEngine.Core.Validations;

namespace BlogEngine.Core.Data.Entities
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} should not be more than 100 Characters")]
        [FirstLetterUppercase]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateCreated { get; set; }

        public byte[] GeneralCover { get; set; }

        // TODO: add rate column

        public List<BlogCategory> BlogCategories { get; set; } = new List<BlogCategory>();
    }
}