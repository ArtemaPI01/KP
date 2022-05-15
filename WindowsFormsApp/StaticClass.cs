using System.IO;
namespace WindowsFormsApp
{
    static class StaticClass
    {
        public static int count = new DirectoryInfo(@"Reports\").GetFiles().Length;
        public static bool cheak;
    }
}