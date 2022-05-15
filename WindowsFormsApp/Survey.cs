using System.Text;
using System.IO;
namespace WindowsFormsApp
{
    public class Survey
    {
        public string FileName { get; set; }
        public string Name { get; set; }
        public Survey(string file, string name)
        {
            FileName = file;
            Name = name;
        }
        public static Survey[] CreateSur()
        {
            Survey[] sur = new Survey[]
             {
                new Survey("File1.txt", "Анкета №1"),
                new Survey("File2.txt", "Анкета №2"),
                new Survey("File3.txt", "Анкета №3"),
                new Survey("File4.txt", "Анкета №4"),
             };

            return sur;
        }
        public static void Save(int count)
        {
            string path = @"Reports\" + count + ".txt";
            using (StreamWriter w = new StreamWriter(path, false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine(Question.Sur.Name);
                for (int i = 0; i < Answers.Ans.Length; i++)
                    w.WriteLine(i + 1 + ") - " + Answers.Ans[i]);
            }
        }
    }
}