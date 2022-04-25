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
        public static string[] CreateMenu(Survey[] sur)
        {
            string[] str = new string[sur.Length];
            for (int i = 0; i < sur.Length; i++)
                str[i] = sur[i].Name;
            return str;
        }
        public static void Save(Survey obj)
        {
            string path = @"Reports\" + StaticClass.count++ + ".txt";
            using (StreamWriter w = new StreamWriter(path, false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine(obj.Name);
                for (int i = 0; i < StaticClass.answers.Length; i++)
                    w.WriteLine(i + 1 + ") - " + StaticClass.answers[i]);
            }
        }
    }
}