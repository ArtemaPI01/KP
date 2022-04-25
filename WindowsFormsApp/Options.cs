namespace WindowsFormsApp
{
    class Options:Question
    {
        public string[] AnsOp { get; set; }
        public Options(string text,int type, string[] ansop)
        {
            Text = text;
            Type = type;
            AnsOp = ansop;
        }
        public override string[] OnlyOptions(){return AnsOp;}
    }
}