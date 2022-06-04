using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyzer(string className, string constructorName)
        {
            string patterns = "." +constructorName +"$";
            Match result = Regex.Match(className, patterns);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyzerType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyzerType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodanalyzerCustomException(MoodanalyzerCustomException.Exceptiontype.NO_SUCH_CLASS, "class Not Found");
                }
            }
            else
            {
                throw new MoodanalyzerCustomException(MoodanalyzerCustomException.Exceptiontype.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }

        public object CreateMoodAnalyze(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public object MoodAnalyser(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
