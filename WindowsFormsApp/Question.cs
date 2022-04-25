using System.IO;
namespace WindowsFormsApp
{
    public abstract class Question
    {
        public string Text { get; set; }
        public int Type { get; set; }
        public virtual bool Enter(string str){return true;}
        public virtual string[] OnlyOptions() {return null;}
        public static Question[] ChoiceSurvey(Survey obj)
        {
            string[] lines = File.ReadAllLines(@"Questions\" + obj.FileName);
            Question[] questions = new Question[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split('|');
                switch (words[1])
                {
                    case "uint":
                        questions[i] = new InUin(words[0], 0);
                        break;
                    case "var":
                        questions[i] = new Options(words[0], 1,words[2].Split('/'));
                        break;
                    case "str":
                        questions[i] = new InS(words[0], 2);
                        break;
                    default: break;
                }
            }
            return questions;
        }
    }
}