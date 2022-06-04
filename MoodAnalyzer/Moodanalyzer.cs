using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    public class Moodanalyser
    {
        public string message;

        public Moodanalyser(string message)
        {
            this.message = message;
        }

        public Moodanalyser()
        {
            this.message="I am in any mood";
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