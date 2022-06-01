using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzer;

namespace MoodAnalyser
{
    public class Moodanalyser
    {
        public string message;

        public Moodanalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("SAD"))
                {
                    Console.WriteLine("The mood is SAD");
                    return "SAD";
                }
                else
                {
                    Console.WriteLine("The mood is HAPPY");
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodanalyzerCustomException(MoodanalyzerCustomException.Exceptiontype.Empty_Null, "Mood should not be null");
               // return "HAPPY";
            }
        }
    }
}