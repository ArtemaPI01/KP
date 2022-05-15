using System;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly Survey[] sur = Survey.CreateSur();
        public Form1()
        {
            InitializeComponent();
            Build();
        }
        private void Build() {comboBox1.DataSource = sur; }
        private void Button1_Click(object sender, EventArgs e) {Close();}
        private void Button2_Click(object sender, EventArgs e)
        {
            Question.Sur = sur[comboBox1.SelectedIndex];
            Answers.Quest = Question.ChoiceSurvey();
            StaticClass.cheak = checkBox1.Checked;
            Close();
            var th = new Thread(Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void Open(object obj){Application.Run(new Form2());}
    }
}