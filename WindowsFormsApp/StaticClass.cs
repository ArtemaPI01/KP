using System.IO;
namespace WindowsFormsApp
{
    class StaticClass
    {
        public static Survey[] sur = Survey.CreateSur();
        public static Question[] quest;
        public static string[] answers;
        public static int index;
        public static int count = new DirectoryInfo(@"Reports\").GetFiles().Length;
        public static bool cheak;
    }
}
