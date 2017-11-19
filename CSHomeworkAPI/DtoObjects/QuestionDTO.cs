using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHomeworkAPI.DtoObjects
{
    public class QuestionDTO
    {
        public Field[] fields { get; set; }
    }

    public class Field
    {
        public string className { get; set; }
        public string type { get; set; }
        public Question question { get; set; }
        public Options options { get; set; }
    }

    public class Question
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class Options
    {
        public int min { get; set; }
        public int max { get; set; }
    }

}