using System;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Build();
        }
        private void Build()
        {
            if (StaticClass.cheak)
                Survey.Save();
            label1.Text += Question.Sur.Name + "\"";
            for (int i = 0; i < Answers.Ans.Length; ++i)
                dataGridView1.Rows.Add(i+1, Answers.Ans[i]);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            var th = new Thread(Back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Back(object obj){Application.Run(new Form1());}
    }
}