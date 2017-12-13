using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Authentication2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int MissionQuestionID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int MissionID { get; set; }
        public int UserID { get; set; }
    }
}