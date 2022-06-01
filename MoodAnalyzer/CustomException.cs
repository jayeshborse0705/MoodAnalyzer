using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{ 
  public  class MoodanalyzerCustomException:Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            Empty_Null,
            Empty_Mood
        }
        public MoodanalyzerCustomException(Exceptiontype type, string message) : base(message)
        { 
            this.type = type;
        }
    }
}
