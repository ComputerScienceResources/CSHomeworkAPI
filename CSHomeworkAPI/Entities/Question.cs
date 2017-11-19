using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSHomeworkAPI.Entities
{
    public class Question
    {
        [Key]
        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Label { get; set; }

        [JsonIgnore]
        public int QuestionTypeID { get; set; }
        [ForeignKey("QuestionTypeID")]
        public virtual QuestionType QuestionType { get; set; }

        [JsonIgnore]
        public int QuestionOptionID { get; set; }
        [ForeignKey("QuestionOptionID")]
        public virtual QuestionOption QuestionOption { get; set; }

    }
}


        //[Required]
        //[MaxLength(255)]
        //public string Label { get; set; }

        //[Required]
        //[MaxLength(10)]
        //public string ClassName { get; set; }

        //[Required]
        //[MaxLength(10)]
        //public string Type { get; set; }

        //[Required]
        //[MaxLength(255)]
        //public string PlaceHolder { get; set; }

        //[MaxLength(255)]
        //public string Pattern { get; set; }

        //public int Min { get; set; }

        //public int Max { get; set; }

        //public int MinLength { get; set; }

        //public int MaxLength { get; set; }

        //public string Rows { get; set; }

        //public string Cols { get; set; }

        //public bool CorrectAnswer { get; set; }

        //public bool Explanation { get; set; }

        //public ICollection<Answer> Answers { get; set; }
        //= new List<Answer>();
//    }
//}