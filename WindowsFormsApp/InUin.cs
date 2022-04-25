using System;
using System.Linq;
namespace WindowsFormsApp
{
    class InUin:Question
    {
        public InUin(string text, int type)
        {
            Text = text;
            Type = type;
        }
        public override bool Enter(string str)
        {
            if (str.All(char.IsDigit) && str != "")
                if (Convert.ToInt32(str) >= 0)
                    return true;
            return false;
        }
    }
}