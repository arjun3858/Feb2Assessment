﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Feb2Assessment.Models
{
    [Table("BlogPost")]
    public class BlogPost
    {
        [Key]
       public int Id { get; set; }
        public string Title { get; set; }
        public string Content {  get; set; }
        public DateTime PublicationDate { get; set; }
        public string Author {  get; set; }


    }
}