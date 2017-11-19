using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSHomeworkAPI.Entities
{
    public class QuestionOption
    {
        [Key]
        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Label { get; set; }

        [JsonIgnore]
        [InverseProperty("QuestionOption")]
        public virtual Question Question { get; set; }
    }
}