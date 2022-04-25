namespace WindowsFormsApp
{
    class InS: Question
    {
        public InS(string text, int type)
        {
            Text = text;
            Type = type;
        }
        public override bool Enter(string str)
        {
            if (str == "")
                return false;
            return true;
        }
    }
}